using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public class Lazy : DeclarationModifierLeaf, ISwiftKeywordNode
{
    public const string Keyword = "lazy";
    
    internal Lazy(IEditableBuffer buffer) 
        : base(SwiftNodeTypes.Lazy, buffer)
    { }

    internal Lazy(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, SwiftNodeTypes.Lazy)
    { }


    public string KeywordValue => Keyword;

    public static Lazy Create()
    {
        return new Lazy(new EditableBuffer(Keyword));
    }

    public static Lazy Create(SwiftInternalNode parent)
    {
        return new Lazy(new EditableBuffer(Keyword));
    }
}