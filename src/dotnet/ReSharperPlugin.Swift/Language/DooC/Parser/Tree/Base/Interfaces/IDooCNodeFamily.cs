using DefaultNamespace;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained;

namespace SoftOmni.SwiftRd.Language.DocC.Parser.Tree.Base.Interfaces;

public interface IDocCNodeFamily<TSelf> : INodeFamily<IDocCNodeFamily<TSelf>, TSelf, DocCLeafNode<TSelf>>
    where TSelf : DocCInternalNode<TSelf>
{ }