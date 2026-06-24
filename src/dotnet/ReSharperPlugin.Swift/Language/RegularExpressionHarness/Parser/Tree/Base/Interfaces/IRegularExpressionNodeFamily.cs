using SoftOmni.SwiftRd.Rider.Language.RegularExpressionHarness.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Rider.Language.RegularExpressionHarness.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained;

namespace SoftOmni.SwiftRd.Rider.Language.RegularExpressionHarness.Parser.Tree.Base.Interfaces;

public interface IRegularExpressionNodeFamily<TSelf> :
    INodeFamily<IRegularExpressionNodeFamily<TSelf>, TSelf, RegularExpressionLeafNode<TSelf>>
    where TSelf : class, IRegularExpressionInternalNode<TSelf>;
    