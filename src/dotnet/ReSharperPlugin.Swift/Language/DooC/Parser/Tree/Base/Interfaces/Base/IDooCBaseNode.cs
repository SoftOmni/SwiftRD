using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained.Root;
using SoftOmni.SwiftRd.Language.DocC.Parser.Tree.Base.Interfaces;

namespace DefaultNamespace;

public interface IDocCBaseNode<TSelf> : INode<IDocCNodeFamily<TSelf>, TSelf, TSelf, DocCLeafNode<TSelf>>
    where TSelf : DocCInternalNode<TSelf>
{ }