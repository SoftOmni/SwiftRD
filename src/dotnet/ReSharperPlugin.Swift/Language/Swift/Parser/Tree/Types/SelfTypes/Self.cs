using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.SelfTypes;

public class Self : TypeLeafNode, ISwiftKeyword
{
    public const string Keyword = "Self";

    internal Self(IEditableBuffer buffer)
        : base(buffer, SwiftNodeTypes.SelfUppercase)
    { }

    internal Self(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.SelfUppercase)
    { }

    public string KeywordValue => Keyword;

    public static Self Create()
    {
        return new Self(new EditableBuffer(Keyword));
    }

    public static Self Create(SwiftInternalNode parent)
    {
        return new Self(parent, new EditableBuffer(Keyword));
    }
}