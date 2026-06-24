using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.ActorIsolationModifiers;

public class NonIsolated : DeclarationModifierLeaf, ISwiftKeywordNode
{
    public const string Keyword = "nonisolated";
    
    internal NonIsolated(IEditableBuffer buffer) 
        : base(SwiftNodeTypes.NonIsolated, buffer)
    { }

    internal NonIsolated(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, SwiftNodeTypes.NonIsolated)
    { }


    public string KeywordValue => Keyword;

    public static NonIsolated Create()
    {
        return new NonIsolated(new EditableBuffer(Keyword));
    }

    public static NonIsolated Create(SwiftInternalNode parent)
    {
        return new NonIsolated(new EditableBuffer(Keyword));
    }
}