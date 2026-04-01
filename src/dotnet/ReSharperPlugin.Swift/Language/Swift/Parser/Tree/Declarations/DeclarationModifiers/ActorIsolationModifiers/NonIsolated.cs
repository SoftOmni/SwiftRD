using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.ActorIsolationModifiers;

public class NonIsolated : DeclarationModifierLeaf, ISwiftKeyword
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