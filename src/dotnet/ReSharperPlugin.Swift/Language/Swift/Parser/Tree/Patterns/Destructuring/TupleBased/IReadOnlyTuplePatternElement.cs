using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns.Destructuring.TupleBased;

public interface IReadOnlyTuplePatternElement : ISwiftNode<SwiftCompositeNode>
{
    IReadOnlyIdentifier? Identifier { get; }
    
    Colon? Colon { get; }
    
    IPattern? Pattern { get; }
}