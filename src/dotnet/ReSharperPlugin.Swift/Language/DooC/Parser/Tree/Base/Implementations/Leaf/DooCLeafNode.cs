using SoftOmni.SwiftRd.Language.Base.Implementations.Constrained.LeafNodes;
using SoftOmni.SwiftRd.Language.DooC.Parser.Tree.Base.Interfaces;

namespace DefaultNamespace;

public abstract class DooCLeafNode<TSelf> : 
    LeafNode<IDooCNodeFamily<TSelf>, DooCLeafNode<TSelf>, TSelf>, 
    IDooCLeafNode<TSelf>
    where TSelf : DooCInternalNode<TSelf>
{ }