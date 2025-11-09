using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Variables.WillSetDidSetBlocks;

public class DidSet : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "didSet";
    
    public DidSetClause? DidSetClause { get; private set; }
    
    internal DidSet(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.DidSet)
    { }

    internal DidSet(ISwiftNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.DidSet)
    {
        if (parent is DidSetClause didSetClause)
        {
            DidSetClause = didSetClause;
        }
    }

    internal DidSet(DidSetClause didSetClause, IEditableBuffer buffer)
        : base(didSetClause, buffer, NodeTypes.NodeTypes.DidSet)
    {
        DidSetClause = didSetClause;
    }

    public string KeywordValue => Keyword;

    public static DidSet Create()
    {
        return new DidSet(new EditableBuffer(Keyword));
    }

    public static DidSet Create(DidSetClause didSetClause)
    {
        return new DidSet(didSetClause, new EditableBuffer(Keyword));
    }

    public static DidSet CreateUnchecked(ISwiftNode parent)
    {
        return new DidSet(parent, new EditableBuffer(Keyword));
    }
}