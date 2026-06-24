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

    enum TrailingWhitespaceAfterElementPolicy
    {
        IncludeAsChildOfElement,
        IncludeAsSiblingOfElement
    }
    
    GenericsClauseUnendedBehavior GetGenericsClauseUnendedBehavior { get; }
    
    GenericsClauseDoubleTypesWithoutComma GetGenericsClauseDoubleTypesWithoutComma { get; }
    
    TrailingWhitespaceAfterElementPolicy GetTrailingWhitespaceAfterElementPolicy { get; }
}