using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.PrecedenceGroups;

public class PrecedenceGroupKeyword : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "precedencegroup";
    
    public PrecedenceGroup? PrecedenceGroup { get; internal set; }

    internal PrecedenceGroupKeyword(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.PrecedenceGroup)
    { }

    internal PrecedenceGroupKeyword(ISwiftNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.PrecedenceGroup)
    {
        if (parent is PrecedenceGroup precedenceGroup)
        {
            PrecedenceGroup = precedenceGroup;
        }
    }

    internal PrecedenceGroupKeyword(PrecedenceGroup parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.PrecedenceGroup)
    {
        PrecedenceGroup = parent;
    }

    public string KeywordValue => Keyword;

    public static PrecedenceGroupKeyword Create()
    {
        return new PrecedenceGroupKeyword(new EditableBuffer(Keyword));
    }

    public static PrecedenceGroupKeyword Create(PrecedenceGroup precedenceGroup)
    {
        return new PrecedenceGroupKeyword(precedenceGroup, new EditableBuffer(Keyword));
    }

    public static PrecedenceGroupKeyword CreateUnchecked(ISwiftNode parent)
    {
        return new PrecedenceGroupKeyword(parent, new EditableBuffer(Keyword));
    }
}