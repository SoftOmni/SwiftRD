using SoftOmni.SwiftRd.Language.Base.Implementations.Constrained.InternalNodes;
using SoftOmni.SwiftRd.Language.DocC.Parser.Tree.Base.Interfaces;

namespace DefaultNamespace;

public abstract class DocCInternalNode<TSelf> : InternalNode<IDocCNodeFamily<TSelf>, TSelf, DocCLeafNode<TSelf>>, IDocCInternalNode<TSelf>
    where TSelf : DocCInternalNode<TSelf>
{ }