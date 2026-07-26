using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained.LeafNodes;
using SoftOmni.SwiftRd.Rider.Language.RegularExpressionHarness.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Rider.Language.RegularExpressionHarness.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Rider.Language.RegularExpressionHarness.Parser.Tree.Base.Interfaces.Root;

namespace SoftOmni.SwiftRd.Rider.Language.RegularExpressionHarness.Parser.Tree.Base.Interfaces.LeafNode;

public interface IRegularExpressionLeafNode<TSelf> :
    ILeafNode<IRegularExpressionNodeFamily<TSelf>, TSelf, RegularExpressionLeafNode<TSelf>>,
    IRegularExpressionNode<TSelf> where TSelf : class, IRegularExpressionInternalNode<TSelf>
{
    new TSelf? GetParent();

    new void AttachToParent(TSelf node, int index);

    new IRegularExpressionNode<TSelf> CloneAsAttachedTo(TSelf newParent, int index);

    new IRegularExpressionNode<TSelf> CloneAsDetached();
}
