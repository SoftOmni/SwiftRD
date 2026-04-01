using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained.Root;
using SoftOmni.SwiftRd.Language.DooC.Parser.Tree.Base.Interfaces;

namespace DefaultNamespace;

public interface IDooCBaseNode<TSelf> : INode<IDooCNodeFamily<TSelf>, TSelf, TSelf, DooCLeafNode<TSelf>>
    where TSelf : DooCInternalNode<TSelf>
{ }