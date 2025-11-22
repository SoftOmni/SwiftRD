using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Types.AnyTypes;

public class Any : TypeLeafNode, ISwiftKeyword
{
    public const string Keyword = "Any";
    
    internal Any(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.AnyUppercase)
    { }

    internal Any(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, NodeTypes.NodeTypes.AnyUppercase)
    { }

    public string KeywordValue => Keyword;

    public static Any Create()
    {
        return new Any(new EditableBuffer(Keyword));
    }
    
    public static Any Create(SwiftInternalNode parent)
    {
        return new Any(parent, new EditableBuffer(Keyword));
    }
}