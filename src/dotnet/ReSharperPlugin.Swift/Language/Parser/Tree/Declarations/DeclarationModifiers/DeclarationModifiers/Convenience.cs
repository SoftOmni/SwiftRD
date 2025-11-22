using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public class Convenience : DeclarationModifierLeaf, ISwiftKeyword
{
    public const string Keyword = "convenience";
    
    internal Convenience(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Convenience)
    { }

    internal Convenience(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, NodeTypes.NodeTypes.Convenience)
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