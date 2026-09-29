using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained.InternalNodes;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained.LeafNodes;

namespace SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained;

public interface INodeFamily<TFamily, TInternalNode, TLeafNode>
    where TFamily : INodeFamily<TFamily, TInternalNode, TLeafNode>
    where TInternalNode : IInternalNode<TFamily, TInternalNode, TLeafNode>
    where TLeafNode : ILeafNode<TFamily, TInternalNode, TLeafNode>;