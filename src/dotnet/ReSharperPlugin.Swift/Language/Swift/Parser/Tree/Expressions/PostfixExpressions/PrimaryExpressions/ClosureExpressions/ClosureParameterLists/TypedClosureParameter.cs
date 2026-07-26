using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeAnnotations;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.
    ClosureExpressions.ClojureParameterLists;

public class TypedClosureParameter : SwiftCompositeNode, ITypedClosureParameter
{
    public IIdentifier Name { get; }

    public ITypeAnnotation? TypeAnnotation { get; }

    internal TypedClosureParameter(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IIdentifier name)
        : base(buffer, children)
    {
        Name = name;
        TypeAnnotation = null;
    }

    internal TypedClosureParameter(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IIdentifier name, ITypeAnnotation? typeAnnotation)
        : base(buffer, children)
    {
        Name = name;
        TypeAnnotation = typeAnnotation;
    }

    IReadOnlyIdentifier IReadOnlyClosureParameter.Name => Name;

    IReadOnlyTypeAnnotation? IReadOnlyTypedClosureParameter.TypeAnnotation => TypeAnnotation;

    public void ChangeName(IIdentifier newName)
    {
        throw new NotImplementedException();
    }

    public void SetTypeAnnotationTo(ITypeAnnotation? typeAnnotation)
    {
        throw new NotImplementedException();
    }

    public void RemoveTypeAnnotation()
    {
        throw new NotImplementedException();
    }
}
