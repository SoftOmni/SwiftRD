namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.PrecedenceGroups.Relations;

public interface IReadOnlyHigherThanPrecedenceGroupRelation : IReadOnlyPrecedenceGroupRelation
{
    HigherThan HigherThanKeyword { get; }
}
