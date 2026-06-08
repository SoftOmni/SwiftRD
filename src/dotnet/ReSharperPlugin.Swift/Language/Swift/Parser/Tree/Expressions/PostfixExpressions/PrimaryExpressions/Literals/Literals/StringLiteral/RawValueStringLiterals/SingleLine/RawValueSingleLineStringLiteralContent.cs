using System.Text;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.StringLiterals;

public class RawValueSingleLineStringLiteralContent : SwiftLeafNode<SwiftCompositeNode>
{
    public StringBuilder Value { get; } = new();
    
    public RawValueSingleLineStringLiteral Literal { get; }

    internal RawValueSingleLineStringLiteralContent(IEditableBuffer underlyingBuffer,
        RawValueSingleLineStringLiteral parentNode, int parentIndex, int parentTextIndex)
        : base(underlyingBuffer, parentNode, parentIndex, parentTextIndex)
    {
        Literal = parentNode;
        BuildInitialValue();
    }

    public override NodeType NodeType => SwiftNodeTypes.RawValueStringLiteralContent;

    private void BuildInitialValue()
    {
        Value.EnsureCapacity(Buffer.Length);
        for (int i = 0; i < Buffer.Length; i++)
        {
            Value.Append(Buffer[i]);
        }
    }
}