using SoftOmni.SwiftRd.Language.Base.Implementations.Constrained.InternalNodes;
using SoftOmni.SwiftRd.Language.DooC.Parser.Tree.Base.Interfaces;

namespace DefaultNamespace;

public abstract class DooCInternalNode<TSelf> : InternalNode<IDooCNodeFamily<TSelf>, TSelf, DooCLeafNode<TSelf>>, IDooCInternalNode<TSelf>
    where TSelf : DooCInternalNode<TSelf>
{ }