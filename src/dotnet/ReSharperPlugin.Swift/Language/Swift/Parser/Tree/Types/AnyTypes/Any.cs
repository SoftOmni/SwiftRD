using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.AnyTypes;

public class Any : TypeLeafNode, ISwiftKeyword
{
    public const string Keyword = "Any";
    
    internal Any(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.AnyUppercase)
    { }

    internal Any(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, SwiftNodeTypes.AnyUppercase)
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