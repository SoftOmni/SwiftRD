using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Enumerations;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.OpaqueTypes;

public class Some : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "some";
    
    public OpaqueType? OpaqueType { get; internal set; }

    internal Some(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.Some)
    { }

    internal Some(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Some)
    {
        if (parent is OpaqueType opaqueType)
        {
            OpaqueType = opaqueType;
        }
    }

    internal Some(OpaqueType parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Some)
    {
        OpaqueType = parent;
    }

    public string KeywordValue => Keyword;

    public static Some Create()
    {
        return new Some(new EditableBuffer(Keyword));
    }

    public static Some Create(OpaqueType opaqueType)
    {
        return new Some(opaqueType, new EditableBuffer(Keyword));
    }

    public static Some CreateUnchecked(SwiftInternalNode parent)
    {
        return new Some(parent, new EditableBuffer(Keyword));
    }
}