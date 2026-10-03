using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained.Root;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.LeafNode;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Interfaces.Root;

public interface IObjectiveCNode<TSelf> : INode<IObjectiveCNodeFamily<TSelf>, TSelf, TSelf, ObjectiveCLeafNode<TSelf>>
    where TSelf : ObjectiveCInternalNode<TSelf>;
    