using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;

public class Await : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "await";
    
    public Expression? Expression { get; internal set; }

    internal Await(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.Await)
    { }

    internal Await(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Await)
    {
        if (parent is Expression expression)
        {
            Expression = expression;
        }
    }

    internal Await(Expression parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Await)
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