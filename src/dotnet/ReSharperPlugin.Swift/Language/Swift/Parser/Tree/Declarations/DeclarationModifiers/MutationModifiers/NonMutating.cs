using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.DeclarationModifiers.MutationModifiers;

public class NonMutating : MutationModifier, ISwiftKeyword
{
    public const string Keyword = "nonmutating";
    
    internal NonMutating(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.NonMutating)
    { }

    internal NonMutating(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, NodeTypes.NodeTypes.NonMutating)
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