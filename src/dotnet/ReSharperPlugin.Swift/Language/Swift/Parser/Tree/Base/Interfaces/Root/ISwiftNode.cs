using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;

public interface ISwiftNode<TSelf> : INode<ISwiftNodeFamily<TSelf>, TSelf, TSelf, SwiftLeafNode<TSelf>>
    where TSelf : SwiftInternalNode<TSelf>;