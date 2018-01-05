using System;
using System.CodeDom;
using System.Linq;
using Wrapperator.Extensions;

namespace Wrapperator.Generators
{
  internal abstract class CodeDomGenerator
  {
    protected CodeTypeReference ConvertTypeToTypeReference (Type type)
    {
      if (type.IsByRef)
        type = type.GetElementType();

      return type.AssertNotNull().ContainsGenericParameters
          ? new CodeTypeReference(type.ToString(), type.GetGenericArguments().Select(ConvertTypeToTypeReference).ToArray())
          : new CodeTypeReference(type);
    }
  }
}