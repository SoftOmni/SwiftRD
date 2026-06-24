using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public class Convenience : DeclarationModifierLeaf, ISwiftKeywordNode
{
    public const string Keyword = "convenience";
    
    internal Convenience(IEditableBuffer buffer) 
        : base(SwiftNodeTypes.Convenience, buffer)
    { }

    internal Convenience(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, SwiftNodeTypes.Convenience)
    { }


    public string KeywordValue => Keyword;

    public static Convenience Create()
    {
        return new Convenience(new EditableBuffer(Keyword));
    }

    public static Convenience Create(SwiftInternalNode parent)
    {
        return new Convenience(new EditableBuffer(Keyword));
    }
}