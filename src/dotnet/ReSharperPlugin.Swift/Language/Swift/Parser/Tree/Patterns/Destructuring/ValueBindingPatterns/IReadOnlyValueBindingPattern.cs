using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Constants;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns.Destructuring.ValueBinding;

public interface IReadOnlyValueBindingPattern : ISwiftInternalNode<SwiftCompositeNode>, IDestructuringPattern
{
    InitializerKind? Kind { get; }
    
    Let? Let { get; }
    
    Var? Var { get; }
    
    IPattern? Pattern { get; }
    
    enum InitializerKind
    {
        Var,
        Let
    }
}