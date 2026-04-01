using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained.LeafNodes;
using SoftOmni.SwiftRd.Language.DooC.Parser.Tree.Base.Interfaces;

namespace DefaultNamespace;

public interface IDooCLeafNode<TSelf> : ILeafNode<IDooCNodeFamily<TSelf>, TSelf, DooCLeafNode<TSelf>>
    where TSelf : DooCInternalNode<TSelf>
{ }