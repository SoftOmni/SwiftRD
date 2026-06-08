namespace SoftOmni.SwiftRd.Language.Swift.Parser.Parsing;

public interface ISwiftParsingSettings
{
    enum GenericsClauseUnendedBehavior
    {
        ConsiderTypeWithoutCommaBePart,
        ConsiderTypeWithoutPrecedingCommaToBeExcluded,
        ConsiderTypeWithoutPrecedingCommaToBeExcludedUnlessFollowedByOtherType
    }

    enum GenericsClauseDoubleTypesWithoutComma
    {
        ConsiderBothPartOfGenericsClause,
        ConsiderFirstToBePartOfGenericsClause,
        ConsiderNoneToBePartOfGenericsClause
    }
    
    GenericsClauseUnendedBehavior GetGenericsClauseUnendedBehavior { get; }
    
    GenericsClauseDoubleTypesWithoutComma GetGenericsClauseDoubleTypesWithoutComma { get; }
}