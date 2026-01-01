using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Expressions;

public class Await : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "await";
    
    public Expression? Expression { get; internal set; }

    internal Await(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Await)
    { }

    internal Await(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Await)
    {
        if (parent is Expression expression)
        {
            Expression = expression;
        }
    }

    internal Await(Expression parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Await)
    {
        Expression = parent;
    }

    public string KeywordValue => Keyword;

    public static Await Create()
    {
        return new Await(new EditableBuffer(Keyword));
    }

    public static Await Create(Expression expression)
    {
        return new Await(expression, new EditableBuffer(Keyword));
    }

    public static Await CreateUnchecked(SwiftInternalNode parent)
    {
        return new Await(parent, new EditableBuffer(Keyword));
    }
}