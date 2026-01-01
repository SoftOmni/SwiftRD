using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.InfixExpressions.TypeCastingOperators;

public class As : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "as";
    
    public AsTypeCastingOperator? AsTypeCastingOperator { get; internal set; }

    internal As(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.As)
    { }

    internal As(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.As)
    {
        if (parent is AsTypeCastingOperator asTypeCastingOperator)
        {
            AsTypeCastingOperator = asTypeCastingOperator;
        }
    }

    internal As(AsTypeCastingOperator parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.As)
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