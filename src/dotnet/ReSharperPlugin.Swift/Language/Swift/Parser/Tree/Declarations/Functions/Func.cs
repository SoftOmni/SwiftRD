using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions;

public class Func : SwiftLeafNode, ISwiftKeywordNode
{
    public const string Keyword = "function";

    public Function? FunctionClause { get; private set; }

    internal Func(IEditableBuffer buffer)
        : base(buffer, SwiftNodeTypes.Func)
    { }

    internal Func(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Func)
    {
        if (parent is Function functionClause)
        {
            FunctionClause = functionClause;
        }
    }

    internal Func(Function functionClause, IEditableBuffer buffer)
        : base(functionClause, buffer, SwiftNodeTypes.Func)
    {
        FunctionClause = functionClause;
    }

    public string KeywordValue => Keyword;

    public static Func Create()
    {
        return new Func(new EditableBuffer(Keyword));
    }

    public static Func Create(Function functionClause)
    {
        return new Func(functionClause, new EditableBuffer(Keyword));
    }

    public static Func CreateUnchecked(SwiftInternalNode parent)
    {
        return new Func(parent, new EditableBuffer(Keyword));
    }
}