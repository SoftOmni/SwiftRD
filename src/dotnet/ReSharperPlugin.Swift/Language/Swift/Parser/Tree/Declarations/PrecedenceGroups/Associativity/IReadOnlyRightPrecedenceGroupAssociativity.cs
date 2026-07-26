namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.PrecedenceGroups.Associativity;

public interface IReadOnlyRightPrecedenceGroupAssociativity : IReadOnlyPrecedenceGroupAssociativity
{
    Right RightKeyword { get; }
}
