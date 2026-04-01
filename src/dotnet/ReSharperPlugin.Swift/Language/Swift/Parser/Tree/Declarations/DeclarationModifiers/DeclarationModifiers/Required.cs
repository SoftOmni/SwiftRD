using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public class Required : DeclarationModifierLeaf, ISwiftKeyword
{
    public const string Keyword = "required";
    
    internal Required(IEditableBuffer buffer) 
        : base(SwiftNodeTypes.Required, buffer)
    { }

    internal Required(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, SwiftNodeTypes.Required)
    { }


    public string KeywordValue => Keyword;

    public static Required Create()
    {
        return new Required(new EditableBuffer(Keyword));
    }

    public static Required Create(SwiftInternalNode parent)
    {
        return new Required(new EditableBuffer(Keyword));
    }
}