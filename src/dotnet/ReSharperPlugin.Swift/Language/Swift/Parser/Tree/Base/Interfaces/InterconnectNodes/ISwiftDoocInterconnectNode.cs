using DefaultNamespace;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InterconnectNodes;

public interface ISwiftDooCInterconnectNode<TSelf, TDooCInternalNode> : 
    IInterconnectNode<ISwiftNodeFamily<TSelf>, TSelf, SwiftLeafNode<TSelf>, TDooCInternalNode>,
    ISwiftInternalNode<TSelf>
    where TSelf : SwiftInternalNode<TSelf> where TDooCInternalNode : DooCCompositeNode;