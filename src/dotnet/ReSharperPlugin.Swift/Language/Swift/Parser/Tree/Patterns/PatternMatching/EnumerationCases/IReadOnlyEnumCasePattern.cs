using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns.Destructuring.TupleBased;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeIdentifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns.PatternMatching.EnumerationCases;

public interface IReadOnlyEnumCasePattern : IReadOnlyPatternMatchingPattern 
{
    IReadOnlyIdentifier? TypeIdentifier { get; }
    
    Period Period { get; }
    
    IReadOnlyIdentifier EnumCaseName { get; }
    
    IReadOnlyTuplePattern? TuplePattern { get; }
} // TODO: finish me
