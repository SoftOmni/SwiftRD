using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeIdentifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns.PatternMatching.EnumerationCases;

public interface IReadOnlyEnumCasePattern : IPatternMatchingPattern 
{
    IReadOnlyTypeIdentifier? TypeIdentifier { get; }
    
    Period? Period { get; }
    
    IReadOnlyEnumCaseName? EnumCaseName { get; }
    
    IReadOnlyTypePattern? TypePattern { get; }
} // TODO: finish me