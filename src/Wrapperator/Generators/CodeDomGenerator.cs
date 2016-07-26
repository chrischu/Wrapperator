using System;
using System.CodeDom;
using System.Linq;

namespace Wrapperator.Generators
{
  internal abstract class CodeDomGenerator
  {
    protected CodeTypeReference ConvertTypeToTypeReference (Type type)
    {
      if (type.IsByRef)
        type = type.GetElementType();

      return type.ContainsGenericParameters
          ? new CodeTypeReference(type.ToString(), type.GetGenericArguments().Select(ConvertTypeToTypeReference).ToArray())
          : new CodeTypeReference(type);
    }
  }
}