using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.PrecedenceGroups.Assignment;

public class Assignment : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "assignment";
    
    public PrecedenceGroupAssignment? PrecedenceGroupAssignment { get; internal set; }

    internal Assignment(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Assignment)
    { }

    internal Assignment(ISwiftNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Assignment)
    {
        if (parent is PrecedenceGroupAssignment precedenceGroupAssignment)
        {
            PrecedenceGroupAssignment = precedenceGroupAssignment;
        }
    }

    internal Assignment(PrecedenceGroupAssignment parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Assignment)
    {
        PrecedenceGroupAssignment = parent;
    }

    public string KeywordValue => Keyword;

    public static Assignment Create()
    {
        return new Assignment(new EditableBuffer(Keyword));
    }

    public static Assignment Create(PrecedenceGroupAssignment precedenceGroupAssignment)
    {
        return new Assignment(precedenceGroupAssignment, new EditableBuffer(Keyword));
    }

    public static Assignment CreateUnchecked(ISwiftNode parent)
    {
        return new Assignment(parent, new EditableBuffer(Keyword));
    }
}