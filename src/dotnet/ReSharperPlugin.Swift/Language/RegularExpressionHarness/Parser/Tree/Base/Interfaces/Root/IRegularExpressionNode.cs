using SoftOmni.SwiftRd.Rider.Language.RegularExpressionHarness.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Rider.Language.RegularExpressionHarness.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained.Root;

namespace SoftOmni.SwiftRd.Rider.Language.RegularExpressionHarness.Parser.Tree.Base.Interfaces.Root;

public interface
    IRegularExpressionNode<TSelf> : INode<IRegularExpressionNodeFamily<TSelf>, TSelf, TSelf,
    RegularExpressionLeafNode<TSelf>>
    where TSelf : class, IRegularExpressionInternalNode<TSelf>;
    