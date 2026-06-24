using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public class Weak : DeclarationModifierLeaf, ISwiftKeywordNode
{
    public const string Keyword = "weak";
    
    internal Weak(IEditableBuffer buffer) 
        : base(SwiftNodeTypes.Weak, buffer)
    { }

    internal Weak(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, SwiftNodeTypes.Weak)
    { }


    public string KeywordValue => Keyword;

    public static Weak Create()
    {
        return new Weak(new EditableBuffer(Keyword));
    }

    public static Weak Create(SwiftInternalNode parent)
    {
        return new Weak(new EditableBuffer(Keyword));
    }
}