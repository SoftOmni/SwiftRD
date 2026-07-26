using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns.Destructuring.TupleBased;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns.PatternMatching.EnumerationCases;

public interface IEnumCasePattern : IReadOnlyEnumCasePattern, IPatternMatchingPattern
{
    new IIdentifier? TypeIdentifier { get; }
    
    new IIdentifier EnumCaseName { get; }
    
    new ITuplePattern? TuplePattern { get; }

    void SetTypeIdentifierTo(IIdentifier? newTypeIdentifier);

    void RemoveTypeIdentifier();

    void ChangeEnumCase(IIdentifier newEnumCase);

    void ChangeTuplePattern(ITuplePattern newTuplePattern);
}
