using SoftOmni.SwiftRd.Rider.Language.RegularExpressionHarness.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained.InternalNodes;

namespace SoftOmni.SwiftRd.Rider.Language.RegularExpressionHarness.Parser.Tree.Base.Interfaces.InternalNode;

public interface IRegularExpressionInternalNode<TSelf> :
    IInternalNode<IRegularExpressionNodeFamily<TSelf>, TSelf, RegularExpressionLeafNode<TSelf>>
    where TSelf : class, IRegularExpressionInternalNode<TSelf>;
