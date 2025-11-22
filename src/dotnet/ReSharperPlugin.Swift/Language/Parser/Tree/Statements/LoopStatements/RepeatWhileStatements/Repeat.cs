using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Statements.LoopStatements.RepeatWhileStatements;

public class Repeat : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "repeat";
    
    public RepeatWhileStatement? RepeatWhileStatement { get; internal set; }

    internal Repeat(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Repeat)
    { }

    internal Repeat(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Repeat)
    {
        if (parent is RepeatWhileStatement repeatWhileStatement)
        {
            RepeatWhileStatement = repeatWhileStatement;
        }
    }

    internal Repeat(RepeatWhileStatement parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Repeat)
    {
        RepeatWhileStatement = parent;
    }

    public string KeywordValue => Keyword;

    public static Repeat Create()
    {
        return new Repeat(new EditableBuffer(Keyword));
    }

    public static Repeat Create(RepeatWhileStatement repeatWhileStatement)
    {
        return new Repeat(repeatWhileStatement, new EditableBuffer(Keyword));
    }

    public static Repeat CreateUnchecked(SwiftInternalNode parent)
    {
        return new Repeat(parent, new EditableBuffer(Keyword));
    }
}