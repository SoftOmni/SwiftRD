using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TupleTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Enumerations.Cases.UnionStyle;

public interface IUnionStyleEnumCase : IReadOnlyUnionStyleEnumCase
{
    new IIdentifier Identifier { get; }
    
    new ITupleType? TupleType { get; }

    void ChangeIdentifier(IIdentifier newIdentifier);

    void SetTupleTypeTo(ITupleType? tupleType);

    void RemoveTupleType();
}
