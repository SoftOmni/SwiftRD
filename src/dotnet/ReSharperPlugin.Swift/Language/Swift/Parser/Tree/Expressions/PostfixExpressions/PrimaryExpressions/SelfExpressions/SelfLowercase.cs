using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.SelfExpressions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ISelfExpressions;

public class SelfLowercase : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "self";
    
    public ISelfExpression? ISelfExpression { get; internal set; }

    internal SelfLowercase(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.SelfLowercase)
    { }

    internal SelfLowercase(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.SelfLowercase)
    {
        if (parent is ISelfExpression iSelfExpression)
        {
            ISelfExpression = iSelfExpression;
        }
    }

    internal SelfLowercase(ISelfExpression parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.SelfLowercase)
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

    public static SelfLowercase CreateUnchecked(SwiftInternalNode parent)
    {
        return new SelfLowercase(parent, new EditableBuffer(Keyword));
    }
}