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

    enum ConsiderDisjointedThroughWhitespaceElementsTheSameIfCannotMatchConceptForSecondElement
    {
        ConsiderSameWrongElement,
        ConsiderTwoDifferentConcepts
    }

    enum UnsuitableOperatorBehavior
    {
        InterruptOverallElementIncludingEnclosingListIfPresent,
        InterruptOverallElementNotIncludingEnclosingListIfPresent,
        ContinueNormally
    }

    enum OptionalQuestionMarkInGenericArgumentClauseInTypeIdentifier
    {
        TreatAsOptional,
        TreatAsUnsuitableOperator
    }

    enum AttributeParsingBracketsAcceptedVariants
    {
        AcceptsParenthesisOnly,
        AcceptsBracketsAndBracesAndParenthesis,
    }

    public readonly ref struct AttributeParsingAcceptedMalformedEntryPoints(
        bool acceptIncorrectFollowupIfToleratedByEntrySetting,
        bool acceptsClosingParenthesis,
        bool acceptsClosingSquareBracket,
        bool acceptsClosingCurlyBrace,
        bool acceptsExtraPunctuators,
        bool acceptsSemicolons)
    {
        public bool AcceptIncorrectFollowupIfToleratedByEntrySetting { get; } =
            acceptIncorrectFollowupIfToleratedByEntrySetting;

        public bool AcceptsClosingParenthesis { get; } = acceptsClosingParenthesis;

        public bool AcceptsClosingSquareBracket { get; } = acceptsClosingSquareBracket;

        public bool AcceptsClosingCurlyBrace { get; } = acceptsClosingCurlyBrace;

        public bool AcceptsExtraPunctuators { get; } = acceptsExtraPunctuators;

        public bool AcceptSemicolons { get; } = acceptsSemicolons;

        public AttributeParsingAcceptedMalformedEntryPoints(
            bool acceptIncorrectFollowupIfToleratedByEntrySetting,
            bool acceptsClosingParenthesis,
            bool acceptsClosingSquareBracketAndCurlyBrace,
            bool acceptsExtraPunctuators,
            bool acceptsSemicolons)
            : this(
                acceptIncorrectFollowupIfToleratedByEntrySetting,
                acceptsClosingParenthesis, 
                acceptsClosingSquareBracketAndCurlyBrace,
                acceptsClosingSquareBracketAndCurlyBrace,
                acceptsExtraPunctuators, acceptsSemicolons
                )
        { }
    }

    GenericsClauseUnendedBehavior GetGenericsClauseUnendedBehavior { get; }

    GenericsClauseDoubleTypesWithoutComma GetGenericsClauseDoubleTypesWithoutComma { get; }

    TrailingWhitespaceAfterElementPolicy GetTrailingWhitespaceAfterElementPolicy { get; }

    ConsiderDisjointedThroughWhitespaceElementsTheSameIfCannotMatchConceptForSecondElement
        GetConsiderDisjointedThroughWhitespaceElementsPolicy { get; }

    UnsuitableOperatorBehavior GetCompletelyUnsuitableOperatorBehavior { get; }

    UnsuitableOperatorBehavior GetSameTypeUnsuitableOperatorBehavior { get; }

    UnsuitableOperatorBehavior GetSameOperatorWrongTypeUnsuitableOperatorBehavior { get; }

    OptionalQuestionMarkInGenericArgumentClauseInTypeIdentifier
        GetOptionalQuestionMarkInGenericArgumentClauseInTypeIdentifierPolicy { get; }

    AttributeParsingBracketsAcceptedVariants GetAttributeParsingBracketsAcceptedVariantsPolicy { get; }

    AttributeParsingAcceptedMalformedEntryPoints GetAttributeParsingAcceptedMalformedEntryPointsPolicy { get; }
}