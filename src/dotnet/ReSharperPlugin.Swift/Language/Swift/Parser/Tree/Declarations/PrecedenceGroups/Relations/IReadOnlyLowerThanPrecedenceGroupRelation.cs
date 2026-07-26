namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.PrecedenceGroups.Relations;

public interface IReadOnlyLowerThanPrecedenceGroupRelation : IReadOnlyPrecedenceGroupRelation
{
    LowerThan LowerThanKeyword { get; }
}
