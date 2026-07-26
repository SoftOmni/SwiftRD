using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TupleTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Enumerations.Cases.UnionStyle;

public class UnionStyleEnumCase : SwiftCompositeNode, IUnionStyleEnumCase
{
    public IIdentifier Identifier { get; }

    public ITupleType? TupleType { get; }

    internal UnionStyleEnumCase(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IIdentifier identifier)
        : base(buffer, children)
    {
        Identifier = identifier;
    }

    internal UnionStyleEnumCase(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IIdentifier identifier, ITupleType? tupleType)
        : base(buffer, children)
    {
        Identifier = identifier;
        TupleType = tupleType;
    }

    IReadOnlyIdentifier IReadOnlyUnionStyleEnumCase.Identifier => Identifier;

    IReadOnlyTupleType? IReadOnlyUnionStyleEnumCase.TupleType => TupleType;

    public void ChangeIdentifier(IIdentifier newIdentifier)
    {
        throw new System.NotImplementedException();
    }

    public void SetTupleTypeTo(ITupleType? tupleType)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveTupleType()
    {
        throw new System.NotImplementedException();
    }
}