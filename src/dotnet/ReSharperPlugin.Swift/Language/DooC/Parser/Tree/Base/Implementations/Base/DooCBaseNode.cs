using DefaultNamespace;
using SoftOmni.SwiftRd.Language.Base.Implementations.Constrained.Base;
using SoftOmni.SwiftRd.Language.DooC.Parser.Tree.Base.Interfaces;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces;

namespace SoftOmni.SwiftRd.Language.DooC.Parser.Tree.Base.Implementations.Base;

public abstract class DooCBaseNode<TSelf> : Node<IDooCNodeFamily<TSelf>, DooCBaseNode<TSelf>, TSelf, DooCLeafNode<TSelf>>
    where TSelf : DooCInternalNode<TSelf>
{ }