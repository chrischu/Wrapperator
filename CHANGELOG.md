# Changelog

All notable changes to this project will be documented in this file.
This project adheres to [Semantic Versioning](http://semver.org/).

## [Unreleased](https://github.com/chrischu/Wrapperator/compare/v2.1.0...HEAD)

No changes yet.

## [2.1.0](https://github.com/chrischu/Wrapperator/compare/v2.0.0...v2.1.0) - 2018-01-07

* Added wrapper for System.Xml.Schema.XmlSchema

## [2.0.0](https://github.com/chrischu/Wrapperator/compare/v1.2.0...v2.0.0) - 2018-01-05

* Removed unnecessary casts in the code to avoid LSP violations.
* Removed wrappers for SectionInformation (it would've caused problems with older .NET versions)

## [1.2.0](https://github.com/chrischu/Wrapperator/compare/v1.1.0...v1.2.0) - 2017-01-07

* Added property that enables access to the wrapped instance to the wrapper interfaces (it is named after the wrapped type, e.g. IXDocument._XDocument).

## [1.1.0](https://github.com/chrischu/Wrapperator/compare/v1.0.0...v1.1.0) - 2016-08-04

* Properties with types that are wrapped have their types wrapped as well (just like it used to be the case for method return types already).
* Added wrappers for several classes from System.Configuration:
  * ConfigurationSection\[Collection\]
  * ConfigurationSectionGroup\[Collection\]
  * ConfigurationLocation\[Collection\]
  * ConfigurationLockCollection
  * KeyValueConfigurationCollection
  * KeyValueConfigurationElement
  * AppSettingsSection
  * ConnectionStringsSection
  * ContextInformation
  * ElementInformation
  * SectionInformation
  * PropertyInformationCollection
  * PropertyInformation
  * ProtectedConfigurationProvider
  

## [1.0.0](https://github.com/chrischu/Wrapperator/compare/v0.9.0...v1.0.0) - 2016-07-31

* Added wrappers for several classes from System.Diagnostics.Process:
  * Process
  * ProcessStartInfo
  * Stopwatch
  * Debug
  * Trace

## [0.9.0](https://github.com/chrischu/Wrapperator/compare/v0.8.0...v0.9.0) - 2016-07-26

* Made constructors in wrappers internal to enforce usage of Wrapper factory class.

## [0.8.0](https://github.com/chrischu/Wrapperator/compare/v0.7.0...v0.8.0) - 2016-07-26

* Did some major refactorings to allow static/instance members, inheritance etc. to work.
* Created a factory class for all Wrapperator wrappers, named Wrapper.
* Removed option to generate implicit conversion operators, since they were put on the wrapper implementation classes and users of Wrapperator should not use them directly anyway (only through the interfaces).

## [0.7.0](https://github.com/chrischu/Wrapperator/compare/v0.6.0...v0.7.0) - 2016-07-24

* Types used in parameters are also wrapped now.

## [0.6.0](https://github.com/chrischu/Wrapperator/compare/v0.5.0...v0.6.0) - 2016-07-24

* Added option to generate implicit conversion operator from the wrapper type to the wrapped type and enabled it by default.

## [0.5.0](https://github.com/chrischu/Wrapperator/compare/v0.4.0...v0.5.0) - 2016-07-22

* Reworked the way methods/properties for wrapping are determined to actually wrap every relevant method/property exactly once.

## [0.4.0](https://github.com/chrischu/Wrapperator/compare/v0.3.0...v0.4.0) - 2016-07-22

* Wrappers/interfaces now consider base type relationships between them as well.

## [0.3.0](https://github.com/chrischu/Wrapperator/compare/v0.2.0...v0.3.0) - 2016-07-17

* Added more properties to wrappers.

## [0.2.0](https://github.com/chrischu/Wrapperator/compare/v0.1.0...v0.2.0) - 2016-07-17

* Added properties to wrappers.

## [0.1.0](https://github.com/chrischu/Wrapperator/compare/eff7943874ae5e127a601ebc455e0904faec01a3...v0.1.0) - 2016-07-17

* Initial release
