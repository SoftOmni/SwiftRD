using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.WillSetDidSetBlocks;

public class DidSet : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "didSet";
    
    public DidSetClause? DidSetClause { get; private set; }
    
    internal DidSet(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.DidSet)
    { }

    internal DidSet(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.DidSet)
    {
        if (parent is DidSetClause didSetClause)
        {
            DidSetClause = didSetClause;
        }
    }

    internal DidSet(DidSetClause didSetClause, IEditableBuffer buffer)
        : base(didSetClause, buffer, SwiftNodeTypes.DidSet)
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

    public static DidSet CreateUnchecked(SwiftInternalNode parent)
    {
        return new DidSet(parent, new EditableBuffer(Keyword));
    }
}