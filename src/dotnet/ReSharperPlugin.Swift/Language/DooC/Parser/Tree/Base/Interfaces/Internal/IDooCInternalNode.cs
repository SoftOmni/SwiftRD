using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained.InternalNodes;
using SoftOmni.SwiftRd.Language.DocC.Parser.Tree.Base.Interfaces;

namespace DefaultNamespace;

public interface IDocCInternalNode<TSelf> : IInternalNode<IDocCNodeFamily<TSelf>, TSelf, DocCLeafNode<TSelf>>
    where TSelf : DocCInternalNode<TSelf>
{ }