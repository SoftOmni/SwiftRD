using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained.LeafNodes;
using SoftOmni.SwiftRd.Language.DocC.Parser.Tree.Base.Interfaces;

namespace DefaultNamespace;

public interface IDocCLeafNode<TSelf> : ILeafNode<IDocCNodeFamily<TSelf>, TSelf, DocCLeafNode<TSelf>>
    where TSelf : DocCInternalNode<TSelf>
{ }