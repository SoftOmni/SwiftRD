namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.PrecedenceGroups.Associativity;

public interface IReadOnlyLeftPrecedenceGroupAssociativity : IReadOnlyPrecedenceGroupAssociativity
{
    Left LeftKeyword { get; }
}
