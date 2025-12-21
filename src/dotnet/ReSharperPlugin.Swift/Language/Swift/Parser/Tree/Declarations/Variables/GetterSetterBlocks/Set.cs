using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Variables.GetterSetterBlocks;

public class Set : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "set";
    
    internal Set(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Set)
    { }

    internal Set(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, NodeTypes.NodeTypes.Set)
    { }


    public string KeywordValue => Keyword;

    public static Set Create()
    {
        return new Set(new EditableBuffer(Keyword));
    }

    public static Set Create(SwiftInternalNode parent)
    {
        return new Set(new EditableBuffer(Keyword));
    }
}