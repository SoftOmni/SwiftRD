using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.LeafNode;

public interface ISwiftLeafNode<TSelf> :
    ILeafNode<ISwiftNodeFamily<TSelf>, TSelf, SwiftLeafNode<TSelf>>
    where TSelf : ISwiftInternalNode<TSelf>;