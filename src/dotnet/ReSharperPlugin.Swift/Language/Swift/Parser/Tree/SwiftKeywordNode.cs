using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.LeafNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree;

public interface ISwiftKeywordNode<TSelf> : ISwiftLeafNode<SwiftCompositeNode>
    where TSelf : ISwiftKeywordNode<TSelf>, new()
{
    string KeywordValue { get; }
}