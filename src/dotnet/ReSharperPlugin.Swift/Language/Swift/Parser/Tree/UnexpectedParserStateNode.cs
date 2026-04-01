using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.ErrorNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree;

public class UnexpectedParserStateNode : SwiftErrorLeafNode<SwiftCompositeNode>
{
    internal UnexpectedParserStateNode(IEditableBuffer underlyingBuffer, TokenNodeType unexpectedTokenType)
        : base(underlyingBuffer, GenerateMessage(unexpectedTokenType))
    { }

    internal UnexpectedParserStateNode(IEditableBuffer underlyingBuffer, SwiftCompositeNode parentNode, int parentIndex, int parentTextIndex,
        TokenNodeType unexpectedTokenType)
        : base(underlyingBuffer, parentNode, parentIndex, parentTextIndex, GenerateMessage(unexpectedTokenType))
    { }

    private static string GenerateMessage(TokenNodeType unexpectedTokenType)
    {
        return $"The {unexpectedTokenType} token type was completely unexpected according to the parser's logic";
    }
}