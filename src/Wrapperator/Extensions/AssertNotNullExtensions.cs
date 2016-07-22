﻿using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;

namespace Wrapperator.Extensions
{
  /// <summary>
  ///   Extensions that make it more convenient to assert that a value is not <c>null</c>.
  /// </summary>
  [ExcludeFromCodeCoverage]
  public static class AssertNotNullExtensions
  {
    /// <summary>
    ///   Asserts that the <paramref name="obj" /> is not <c>null</c>.
    /// </summary>
    [AssertionMethod]
    [ContractAnnotation ("obj: null => halt")]
    [NotNull]
    public static T AssertNotNull<T> ([CanBeNull] this T obj, string message = null) where T : class
    {
      Trace.Assert(obj != null, message ?? "AssertNotNull failed");
      return obj;
    }
  }
}