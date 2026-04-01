using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained.InternalNodes;
using SoftOmni.SwiftRd.Language.DooC.Parser.Tree.Base.Interfaces;

namespace DefaultNamespace;

public interface IDooCInternalNode<TSelf> : IInternalNode<IDooCNodeFamily<TSelf>, TSelf, DooCLeafNode<TSelf>>
    where TSelf : DooCInternalNode<TSelf>
{ }