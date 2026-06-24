using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InterconnectNodes;

public interface ISwiftRegularExpressionInterconnectNode<TSelf, TRegularExpressionCompositeNode>
    : IInterconnectNode<ISwiftNodeFamily<TSelf>, TSelf, SwiftLeafNode<TSelf>, TRegularExpressionCompositeNode>,
        ISwiftInternalNode<TSelf>
    where TSelf : SwiftInternalNode<TSelf> where TRegularExpressionCompositeNode : RegularExpressionCompositeNode
{ }
