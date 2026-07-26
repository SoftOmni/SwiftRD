using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns.Destructuring.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns.PatternMatching.Optionals;

public interface IReadOnlyOptionalPattern : ISwiftInternalNode<SwiftCompositeNode>, IReadOnlyPatternMatchingPattern
{
    public QuestionMark? QuestionMark { get; }
    
    public IReadOnlyIdentifierPattern? IdentifierPattern { get; }
}
