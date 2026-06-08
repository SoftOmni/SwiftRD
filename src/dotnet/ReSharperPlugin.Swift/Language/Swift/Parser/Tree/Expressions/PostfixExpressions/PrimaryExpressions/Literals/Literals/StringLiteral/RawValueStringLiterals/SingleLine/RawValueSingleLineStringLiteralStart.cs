using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.StringLiterals;

public class RawValueSingleLineStringLiteralStart : SwiftLeafNode<SwiftCompositeNode>
{
    public RawValueSingleLineStringLiteral Literal { get; }

    public RawValueSingleLineStringLiteralEnd End => Literal.End;
    
    public int LeadingHashtags { get; }

    internal RawValueSingleLineStringLiteralStart(IEditableBuffer underlyingBuffer,
        RawValueSingleLineStringLiteral parentNode, int parentIndex, int parentTextIndex)
        : base(underlyingBuffer, parentNode, parentIndex, parentTextIndex)
    {
        Literal = parentNode;

        LeadingHashtags = 0;
        while (LeadingHashtags < Buffer.Length && LeadingHashtags is '#')
        {
            LeadingHashtags++;
        }
    }

    public override NodeType NodeType => SwiftNodeTypes.RawValueStringLiteralStart;
}