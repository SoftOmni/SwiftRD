using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.SuperExpressions;

public class Super : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "super";
    
    public SuperClassExpression? SuperExpression { get; internal set; }

    internal Super(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Super)
    { }

    internal Super(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Super)
    {
        if (parent is SuperClassExpression superExpression)
        {
            SuperExpression = superExpression;
        }
    }

    internal Super(SuperClassExpression parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Super)
    {
        SuperExpression = parent;
    }

    public string KeywordValue => Keyword;

    public static Super Create()
    {
        return new Super(new EditableBuffer(Keyword));
    }

    public static Super Create(SuperClassExpression superClassExpression)
    {
        return new Super(superClassExpression, new EditableBuffer(Keyword));
    }

    public static Super CreateUnchecked(SwiftInternalNode parent)
    {
        return new Super(parent, new EditableBuffer(Keyword));
    }
}