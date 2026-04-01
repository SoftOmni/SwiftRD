using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.GetterSetterBlocks;

public class Set : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "set";
    
    internal Set(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.Set)
    { }

    internal Set(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, SwiftNodeTypes.Set)
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