using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.BoxedProtocolTypes;

public class LowercaseAny : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "any";
    
    public BoxedProtocolType? BoxedProtocolType { get; internal set; }

    internal LowercaseAny(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.AnyLowercase)
    { }

    internal LowercaseAny(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.AnyLowercase)
    {
        if (parent is BoxedProtocolType boxedProtocolType)
        {
            BoxedProtocolType = boxedProtocolType;
        }
    }

    internal LowercaseAny(BoxedProtocolType parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.AnyLowercase)
    {
        BoxedProtocolType = parent;
    }

    public string KeywordValue => Keyword;

    public static LowercaseAny Create()
    {
        return new LowercaseAny(new EditableBuffer(Keyword));
    }

    public static LowercaseAny Create(BoxedProtocolType boxedProtocolType)
    {
        return new LowercaseAny(boxedProtocolType, new EditableBuffer(Keyword));
    }

    public static LowercaseAny CreateUnchecked(SwiftInternalNode parent)
    {
        return new LowercaseAny(parent, new EditableBuffer(Keyword));
    }
}