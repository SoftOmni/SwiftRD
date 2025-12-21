using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Variables.GetterSetterBlocks;

public class Get : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "get";
    
    internal Get(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Get)
    { }

    internal Get(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, NodeTypes.NodeTypes.Get)
    { }


    public string KeywordValue => Keyword;

    public static Get Create()
    {
        return new Get(new EditableBuffer(Keyword));
    }

    public static Get Create(SwiftInternalNode parent)
    {
        return new Get(new EditableBuffer(Keyword));
    }
}