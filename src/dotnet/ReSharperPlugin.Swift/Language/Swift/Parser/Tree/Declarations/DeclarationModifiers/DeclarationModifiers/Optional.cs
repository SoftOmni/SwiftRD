using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public class Optional : DeclarationModifierLeaf, ISwiftKeyword
{
    public const string Keyword = "optional";
    
    internal Optional(IEditableBuffer buffer) 
        : base(SwiftNodeTypes.Optional, buffer)
    { }

    internal Optional(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, SwiftNodeTypes.Optional)
    { }


    public string KeywordValue => Keyword;

    public static Optional Create()
    {
        return new Optional(new EditableBuffer(Keyword));
    }

    public static Optional Create(SwiftInternalNode parent)
    {
        return new Optional(new EditableBuffer(Keyword));
    }
}