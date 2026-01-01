using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Wildcards;

public class Wildcard : PrimaryExpressionLeafNode, ISwiftKeyword
{
    public const string Keyword = "_";

    internal Wildcard(IEditableBuffer buffer)
        : base(buffer, NodeTypes.NodeTypes.Underscore)
    { }

    internal Wildcard(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Underscore)
    { }


    public string KeywordValue => Keyword;

    public static Wildcard Create()
    {
        return new Wildcard(new EditableBuffer(Keyword));
    }

    public static Wildcard Create(SwiftInternalNode parent)
    {
        return new Wildcard(parent, new EditableBuffer(Keyword));
    }
}