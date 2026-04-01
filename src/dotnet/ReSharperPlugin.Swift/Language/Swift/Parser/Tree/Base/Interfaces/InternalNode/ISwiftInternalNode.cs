using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;

public interface ISwiftInternalNode<TSelf> :
    IInternalNode<ISwiftNodeFamily<TSelf>, TSelf, SwiftLeafNode<TSelf>>
    where TSelf : ISwiftInternalNode<TSelf>;