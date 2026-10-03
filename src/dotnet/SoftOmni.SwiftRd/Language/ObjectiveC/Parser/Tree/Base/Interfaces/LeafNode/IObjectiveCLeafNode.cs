using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained.LeafNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Interfaces.Root;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Interfaces.LeafNode;

public interface IObjectiveCLeafNode<TSelf> : ILeafNode<IObjectiveCNodeFamily<TSelf>, TSelf, ObjectiveCLeafNode<TSelf>>, IObjectiveCNode<TSelf>
    where TSelf : ObjectiveCInternalNode<TSelf>
{
    new TSelf? GetParent();

    new void AttachToParent(TSelf node, int index);

    new IObjectiveCLeafNode<TSelf> CloneAsAttachedTo(TSelf newParent, int index);

    new IObjectiveCLeafNode<TSelf> CloneAsDetached();
}
