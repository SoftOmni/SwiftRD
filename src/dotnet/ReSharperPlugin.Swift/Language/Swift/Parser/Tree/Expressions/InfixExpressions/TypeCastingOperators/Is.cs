using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.InfixExpressions.TypeCastingOperators;

public class Is : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "is";
    
    public IsTypeCastingOperator? IsTypeCastingOperator { get; internal set; }

    internal Is(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.Is)
    { }

    internal Is(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Is)
    {
        if (parent is IsTypeCastingOperator isTypeCastingOperator)
        {
            IsTypeCastingOperator = isTypeCastingOperator;
        }
    }

    internal Is(IsTypeCastingOperator parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Is)
    {
        IsTypeCastingOperator = parent;
    }

    public string KeywordValue => Keyword;

    public static Is Create()
    {
        return new Is(new EditableBuffer(Keyword));
    }

    public static Is Create(IsTypeCastingOperator isTypeCastingOperator)
    {
        return new Is(isTypeCastingOperator, new EditableBuffer(Keyword));
    }

    public static Is CreateUnchecked(SwiftInternalNode parent)
    {
        return new Is(parent, new EditableBuffer(Keyword));
    }
}