namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.PrecedenceGroups.Associativity;

public interface IReadOnlyNonePrecedenceGroupAssociativity : IReadOnlyPrecedenceGroupAssociativity
{
    None NoneKeyword { get; }
}
