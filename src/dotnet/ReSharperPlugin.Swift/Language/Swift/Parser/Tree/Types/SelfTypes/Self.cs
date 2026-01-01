using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Types.SelfTypes;

public class Self : TypeLeafNode, ISwiftKeyword
{
    public const string Keyword = "Self";

    internal Self(IEditableBuffer buffer)
        : base(buffer, NodeTypes.NodeTypes.SelfUppercase)
    { }

    internal Self(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.SelfUppercase)
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