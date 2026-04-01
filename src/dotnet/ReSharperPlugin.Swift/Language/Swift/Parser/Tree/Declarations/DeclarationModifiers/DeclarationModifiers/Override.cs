using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public class Override : DeclarationModifierLeaf, ISwiftKeyword
{
    public const string Keyword = "override";
    
    internal Override(IEditableBuffer buffer) 
        : base(SwiftNodeTypes.Override, buffer)
    { }

    internal Override(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, SwiftNodeTypes.Override)
    { }


    public string KeywordValue => Keyword;

    public static Override Create()
    {
        return new Override(new EditableBuffer(Keyword));
    }

    public static Override Create(SwiftInternalNode parent)
    {
        return new Override(new EditableBuffer(Keyword));
    }
}