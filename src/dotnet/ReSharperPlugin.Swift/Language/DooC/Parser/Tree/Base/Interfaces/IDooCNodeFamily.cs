using DefaultNamespace;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained;

namespace SoftOmni.SwiftRd.Language.DooC.Parser.Tree.Base.Interfaces;

public interface IDooCNodeFamily<TSelf> : INodeFamily<IDooCNodeFamily<TSelf>, TSelf, DooCLeafNode<TSelf>>
    where TSelf : DooCInternalNode<TSelf>
{ }