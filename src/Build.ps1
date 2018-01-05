#Requires -Version 5.0

[CmdletBinding()]
Param (
  [Parameter(Mandatory)]
  [ValidateNotNullOrEmpty()]
  [ValidateSet("Local", "AppVeyor")]
  [string] $Mode,
  [Parameter(Mandatory)]
  [Version] $Version,
  [Parameter(Mandatory)]
  [bool] $IsPreRelease,
  [Parameter()]
  [string] $Configuration = "Release",
  [Parameter()]
  [bool] $RunReSharperCodeInspection = $True,
  [Parameter()]
  [bool] $CreateNuGetPackages = $False,
  [Parameter()]
  [bool]$PushNuGetPackages = $False,
  [Parameter()]
  [string] $TargetNuGetFeed = "https://www.nuget.org",
  [Parameter()]
  [string] $NuGetApiKey
)

Set-StrictMode -Version 2.0
$ErrorActionPreference = "Stop"
$ConfirmPreference = "None"
trap { $error[0] | Format-List -Force; $host.SetShouldExit(1) }

. $PSScriptRoot\Shared\Build\BuildLibrary.ps1

$TreatWarningsAsErrors = $True
$MSBuildToolset = "14.0"
$MSBuildExecutable = "C:\Program Files (x86)\MSBuild\$MSBuildToolset\Bin\MSBuild.exe"
$NuGetExecutable = ".\.nuget\NuGet.exe"

$SolutionDirectory = $PSScriptRoot
$SolutionFile = Join-Path $SolutionDirectory "Wrapperator.sln"
$DotSettingsFile = "${SolutionFile}.DotSettings"

$AssemblyInfoSharedFile = Join-Path $SolutionDirectory "AssemblyInfoShared.cs"

$BuildOutputDirectory = Join-Path $SolutionDirectory "Build"
$AnalysisResultsDirectory = Join-Path $BuildOutputDirectory "AnalysisResults"
$FxCopResultsDirectory = Join-Path $AnalysisResultsDirectory "FxCop"
$NuGetPackagesDirectory = Join-Path $BuildOutputDirectory "NuGetPackages"

$Projects = Get-ProjectsFromSolution $SolutionFile $Configuration | ? { $_.ProjectName -ne "SolutionPackages" }

$TestProjects = $Projects | ? { $_.ProjectName.EndsWith("Tests") }
$TestAssemblies = $TestProjects | % { $_.TargetPath }

$AssemblyVersion = "$($Version.Major).0.0.0"
if($Version.Major -eq 0) {
  $AssemblyVersion = "0.0.0.1"  
}

$AssemblyFileVersion = "$($Version.Major).$($Version.Minor).$($Version.Build).$($Version.Revision)"
$AssemblyInformationalVersion = "$($Version.Major).$($Version.Minor).$($Version.Build)"
if ($IsPreRelease) {
  $AssemblyInformationalVersion = "${AssemblyInformationalVersion}-pre$($Version.Revision)"
}

$NuGetVersion = $Version.Major, $Version.Minor, $Version.Build

function Run() {
  try {
    Write-Host "Running in '$Mode' mode"
    Write-Host "Building '$SolutionFile'"
    Write-Host "Version: $Version"
    Write-Host "Configuration: $Configuration"
    Write-Host "Run ReSharper code inspection: $RunReSharperCodeInspection"
    Write-Host "Build NuGetPackages: $CreateNuGetPackages (with version: $AssemblyInformationalVersion)"
    Write-Host "Push NuGet packages: $PushNuGetPackages (to $TargetNuGetFeed)"

    Clean
    Restore-NuGetPackages
    Update-AssemblyInfos
    Build
    Run-ReSharperCodeInspection -Condition $RunReSharperCodeInspection
    Create-NuGetPackages -Condition $CreateNuGetPackages
    Push-Packages -Condition ($PushNuGetPackages -And $CreateNuGetPackages)
  } finally {
    Restore-AssemblyInfos
  }
}

BuildTask Clean {
  Clean-BuildDirectory $BuildOutputDirectory
  Clean-Solution $SolutionFile
  New-Item $AnalysisResultsDirectory, $FxCopResultsDirectory, $NuGetPackagesDirectory -Type Directory | Out-Null
}

BuildTask Restore-NuGetPackages {
  Restore-NuGetPackagesForSolution $SolutionFile
}

BuildTask Update-AssemblyInfos { 
  Update-AssemblyInfo $AssemblyInfoSharedFile $Configuration $AssemblyVersion $AssemblyFileVersion $AssemblyInformationalVersion
}

BuildTask Restore-AssemblyInfos {
  Restore-AssemblyInfo $AssemblyInfoSharedFile
}

BuildTask Build {
  Build-Solution $SolutionFile $Projects $Configuration $TreatWarningsAsErrors $False $FxCopResultsDirectory
}

BuildTask Run-ReSharperCodeInspection {
  $ReSharperCodeInspectionResultsFile = Join-Path $AnalysisResultsDirectory "ReSharperCodeInspectionResults.xml"
  $numberOfIssues = Execute-ReSharperCodeInspection $SolutionFile $Configuration $ReSharperCodeInspectionResultsFile
}

BuildTask Create-NuGetPackages {
  $commitHash = Get-CurrentCommitHash
  $branchName = Get-CurrentBranchName
  
  $vcsUrlTemplate = "https://raw.githubusercontent.com/chrischu/Wrapperator/${commitHash}/${branchName}/{0}"
  Create-NuGetPackagesFromSolution $SolutionDirectory $Projects $AssemblyInformationalVersion $Configuration $vcsUrlTemplate $NuGetPackagesDirectory

  Get-ChildItem $NuGetPackagesDirectory *.nupkg | %{ Report-NuGetPackage $_.FullName }
}

BuildTask Push-Packages {
   Push-AllNuGetPackages $NuGetPackagesDirectory $TargetNuGetFeed $NuGetApiKey
}

return Run