using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeAnnotations;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.
    ClosureExpressions.ClojureParameterLists;

public class VariadicClosureParameter : SwiftCompositeNode, IVariadicClosureParameter
{
    public IIdentifier Name { get; }

    public ITypeAnnotation TypeAnnotation { get; }

    public Ellipsis Ellipsis { get; }

    internal VariadicClosureParameter(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IIdentifier name, ITypeAnnotation typeAnnotation, Ellipsis ellipsis)
        : base(buffer, children)
    {
        Name = name;
        TypeAnnotation = typeAnnotation;
        Ellipsis = ellipsis;
    }

    IReadOnlyIdentifier IReadOnlyClosureParameter.Name => Name;

    IReadOnlyTypeAnnotation IReadOnlyVariadicClosureParameter.TypeAnnotation => TypeAnnotation;

    public void ChangeName(IIdentifier newName)
    {
        throw new System.NotImplementedException();
    }

    public void ChangeTypeAnnotation(ITypeAnnotation newTypeAnnotation)
    {
        throw new System.NotImplementedException();
    }
}