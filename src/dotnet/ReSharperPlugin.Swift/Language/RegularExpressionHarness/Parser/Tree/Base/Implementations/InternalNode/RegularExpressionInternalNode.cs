using SoftOmni.SwiftRd.Rider.Language.RegularExpressionHarness.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Rider.Language.RegularExpressionHarness.Parser.Tree.Base.Interfaces;
using SoftOmni.SwiftRd.Rider.Language.RegularExpressionHarness.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Rider.Language.RegularExpressionHarness.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Base.Implementations.Constrained.InternalNodes;

namespace SoftOmni.SwiftRd.Rider.Language.RegularExpressionHarness.Parser.Tree.Base.Implementations.InternalNode;

public abstract class RegularExpressionInternalNode<TSelf> 
    : InternalNode<IRegularExpressionNodeFamily<TSelf>, TSelf, RegularExpressionLeafNode<TSelf>>, IRegularExpressionInternalNode<TSelf>,
        IRegularExpressionNode<TSelf> where TSelf : RegularExpressionInternalNode<TSelf>
{
}