using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Statements.BranchStatements.Guard;

public class Guard : StatementLeafNode, ISwiftKeyword
{
    public const string Keyword = "guard";
    
    public GuardStatement? GuardStatement { get; private set; }
    
    internal Guard(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Guard)
    { }

    internal Guard(ISwiftNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Guard)
    {
        if (parent is GuardStatement guardStatement)
        {
            GuardStatement = guardStatement;
        }
    }

    internal Guard(GuardStatement guardStatement, IEditableBuffer buffer)
        : base(guardStatement, buffer, NodeTypes.NodeTypes.Guard)
    {
        GuardStatement = guardStatement;
    }

    public string KeywordValue => Keyword;

    public static Guard Create()
    {
        return new Guard(new EditableBuffer(Keyword));
    }

    public static Guard Create(GuardStatement guardStatement)
    {
        return new Guard(guardStatement, new EditableBuffer(Keyword));
    }

    public static Guard CreateUnchecked(ISwiftNode parent)
    {
        return new Guard(parent, new EditableBuffer(Keyword));
    }
}