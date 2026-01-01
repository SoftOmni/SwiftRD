using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Variables.WillSetDidSetBlocks;

public class WillSet : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "willSet";
    
    public WillSetClause? WillSetClause { get; private set; }
    
    internal WillSet(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.WillSet)
    { }

    internal WillSet(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.WillSet)
    {
        if (parent is WillSetClause willSetClause)
        {
            WillSetClause = willSetClause;
        }
    }

    internal WillSet(WillSetClause willSetClause, IEditableBuffer buffer)
        : base(willSetClause, buffer, NodeTypes.NodeTypes.WillSet)
    {
        WillSetClause = willSetClause;
    }

    public string KeywordValue => Keyword;

    public static WillSet Create()
    {
        return new WillSet(new EditableBuffer(Keyword));
    }

    public static WillSet Create(WillSetClause willSetClause)
    {
        return new WillSet(willSetClause, new EditableBuffer(Keyword));
    }

    public static WillSet CreateUnchecked(SwiftInternalNode parent)
    {
        return new WillSet(parent, new EditableBuffer(Keyword));
    }
}