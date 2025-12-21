using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.DeclarationModifiers.ActorIsolationModifiers;

public class NonIsolated : DeclarationModifierLeaf, ISwiftKeyword
{
    public const string Keyword = "nonisolated";
    
    internal NonIsolated(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.NonIsolated)
    { }

    internal NonIsolated(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, NodeTypes.NodeTypes.NonIsolated)
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