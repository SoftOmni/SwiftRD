using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.TryOperators;

public class Try : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "try";
    
    public TryOperator? TryOperator { get; internal set; }

    internal Try(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Try)
    { }

    internal Try(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Try)
    {
        if (parent is TryOperator tryOperator)
        {
            TryOperator = tryOperator;
        }
    }

    internal Try(TryOperator parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Try)
    {
        TryOperator = parent;
    }

    public string KeywordValue => Keyword;

    public static Try Create()
    {
        return new Try(new EditableBuffer(Keyword));
    }

    public static Try Create(TryOperator tryOperator)
    {
        return new Try(tryOperator, new EditableBuffer(Keyword));
    }

    public static Try CreateUnchecked(SwiftInternalNode parent)
    {
        return new Try(parent, new EditableBuffer(Keyword));
    }
}