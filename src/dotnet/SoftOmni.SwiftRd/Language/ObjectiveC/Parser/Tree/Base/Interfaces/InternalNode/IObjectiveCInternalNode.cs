using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained.InternalNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Interfaces.Root;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Interfaces.InternalNode;

public interface IObjectiveCInternalNode<TSelf> : IInternalNode<IObjectiveCNodeFamily<TSelf>, TSelf, ObjectiveCLeafNode<TSelf>>,
    IObjectiveCNode<TSelf>
    where TSelf : ObjectiveCInternalNode<TSelf>;
    