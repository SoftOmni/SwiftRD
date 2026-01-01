using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Statements.DoStatements;

public class Do : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "do";
    
    public DoStatement? DoStatement { get; internal set; }

    internal Do(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Do)
    { }

    internal Do(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Do)
    {
        if (parent is DoStatement doStatement)
        {
            DoStatement = doStatement;
        }
    }

    internal Do(DoStatement parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Do)
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