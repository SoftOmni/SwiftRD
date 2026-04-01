using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.GetterSetterBlocks;

public class Get : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "get";
    
    internal Get(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.Get)
    { }

    internal Get(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, SwiftNodeTypes.Get)
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