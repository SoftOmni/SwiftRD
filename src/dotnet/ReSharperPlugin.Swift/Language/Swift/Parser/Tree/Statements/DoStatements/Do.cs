using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.DoStatements;

public class Do : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "do";
    
    public DoStatement? DoStatement { get; internal set; }

    internal Do(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.Do)
    { }

    internal Do(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Do)
    {
        if (parent is DoStatement doStatement)
        {
            DoStatement = doStatement;
        }
    }

    internal Do(DoStatement parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Do)
    {
        DoStatement = parent;
    }

    public string KeywordValue => Keyword;

    public static Do Create()
    {
        return new Do(new EditableBuffer(Keyword));
    }

    public static Do Create(DoStatement doStatement)
    {
        return new Do(doStatement, new EditableBuffer(Keyword));
    }

    public static Do CreateUnchecked(SwiftInternalNode parent)
    {
        return new Do(parent, new EditableBuffer(Keyword));
    }
}