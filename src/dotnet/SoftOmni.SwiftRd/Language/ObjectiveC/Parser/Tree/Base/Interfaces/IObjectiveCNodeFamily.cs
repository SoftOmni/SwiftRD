using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.LeafNode;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Interfaces;

public interface IObjectiveCNodeFamily<TSelf> : INodeFamily<IObjectiveCNodeFamily<TSelf>, TSelf, ObjectiveCLeafNode<TSelf>>
    where TSelf : ObjectiveCInternalNode<TSelf>;