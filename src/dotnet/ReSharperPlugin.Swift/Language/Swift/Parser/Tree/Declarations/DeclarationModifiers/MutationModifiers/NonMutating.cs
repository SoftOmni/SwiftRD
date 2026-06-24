using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.MutationModifiers;

public class NonMutating : MutationModifier, ISwiftKeywordNode
{
    public const string Keyword = "nonmutating";
    
    internal NonMutating(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.NonMutating)
    { }

    internal NonMutating(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, SwiftNodeTypes.NonMutating)
    { }


    public string KeywordValue => Keyword;

    public static NonMutating Create()
    {
        return new NonMutating(new EditableBuffer(Keyword));
    }

    public static NonMutating Create(SwiftInternalNode parent)
    {
        return new NonMutating(new EditableBuffer(Keyword));
    }
}