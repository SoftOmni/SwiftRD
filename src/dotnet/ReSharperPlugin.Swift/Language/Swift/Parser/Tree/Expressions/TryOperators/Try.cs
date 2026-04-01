using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.TryOperators;

public class Try : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "try";
    
    public TryOperator? TryOperator { get; internal set; }

    internal Try(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.Try)
    { }

    internal Try(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Try)
    {
        if (parent is TryOperator tryOperator)
        {
            TryOperator = tryOperator;
        }
    }

    internal Try(TryOperator parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Try)
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