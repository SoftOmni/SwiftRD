using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions;

public class In : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "in";

    internal In(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.In)
    { }

    internal In(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.In)
    { }

    public string KeywordValue => Keyword;

    public static In Create()
    {
        return new In(new EditableBuffer(Keyword));
    }

    public static In Create(SwiftInternalNode parent)
    {
        return new In(parent, new EditableBuffer(Keyword));
    }
}