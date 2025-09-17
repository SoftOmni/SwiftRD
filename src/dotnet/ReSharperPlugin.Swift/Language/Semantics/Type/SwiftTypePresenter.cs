using System;
using System.Collections.Generic;
using JetBrains.Metadata.Reader.API;
using JetBrains.ReSharper.Psi;
using JetBrains.UI.RichText;

namespace ReSharperPlugin.Swift.Language.Semantics.Type;

public class SwiftTypePresenter : ITypePresenter
{
    public RichText GetPresentableName(IType type, TypePresentationStyle typePresentationStyle)
    {
        throw new NotImplementedException();
    }

    public RichText GetUnresolvedScalarTypePresentation(string name, ICollection<IType>? typeArguments,
        NullableAnnotation nullableAnnotation, TypePresentationStyle typePresentationStyle)
    {
        throw new NotImplementedException();
    }
}