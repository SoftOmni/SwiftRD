using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.SelfExpressions;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ISelfExpressions;

public class SelfLowercase : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "self";
    
    public ISelfExpression? ISelfExpression { get; internal set; }

    internal SelfLowercase(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.SelfLowercase)
    { }

    internal SelfLowercase(ISwiftNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.SelfLowercase)
    {
        if (parent is ISelfExpression iSelfExpression)
        {
            ISelfExpression = iSelfExpression;
        }
    }

    internal SelfLowercase(ISelfExpression parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.SelfLowercase)
    {
        ISelfExpression = parent;
    }

    public string KeywordValue => Keyword;

    public static SelfLowercase Create()
    {
        return new SelfLowercase(new EditableBuffer(Keyword));
    }

    public static SelfLowercase Create(ISelfExpression iSelfExpression)
    {
        return new SelfLowercase(iSelfExpression, new EditableBuffer(Keyword));
    }

    public static SelfLowercase CreateUnchecked(ISwiftNode parent)
    {
        return new SelfLowercase(parent, new EditableBuffer(Keyword));
    }
}