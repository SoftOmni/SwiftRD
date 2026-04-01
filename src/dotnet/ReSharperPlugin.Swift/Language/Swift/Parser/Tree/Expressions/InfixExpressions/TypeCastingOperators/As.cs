using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.InfixExpressions.TypeCastingOperators;

public class As : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "as";
    
    public AsTypeCastingOperator? AsTypeCastingOperator { get; internal set; }

    internal As(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.As)
    { }

    internal As(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.As)
    {
        if (parent is AsTypeCastingOperator asTypeCastingOperator)
        {
            AsTypeCastingOperator = asTypeCastingOperator;
        }
    }

    internal As(AsTypeCastingOperator parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.As)
    {
        AsTypeCastingOperator = parent;
    }

    public string KeywordValue => Keyword;

    public static As Create()
    {
        return new As(new EditableBuffer(Keyword));
    }

    public static As Create(AsTypeCastingOperator asTypeCastingOperator)
    {
        return new As(asTypeCastingOperator, new EditableBuffer(Keyword));
    }

    public static As CreateUnchecked(SwiftInternalNode parent)
    {
        return new As(parent, new EditableBuffer(Keyword));
    }
}