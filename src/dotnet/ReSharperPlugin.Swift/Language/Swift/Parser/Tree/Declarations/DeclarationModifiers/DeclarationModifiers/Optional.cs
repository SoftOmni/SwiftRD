using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public class Optional : DeclarationModifierLeaf, ISwiftKeyword
{
    public const string Keyword = "optional";
    
    internal Optional(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Optional)
    { }

    internal Optional(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, NodeTypes.NodeTypes.Optional)
    { }


    public string KeywordValue => Keyword;

    public static Optional Create()
    {
        return new Optional(new EditableBuffer(Keyword));
    }

    public static Optional Create(SwiftInternalNode parent)
    {
        return new Optional(new EditableBuffer(Keyword));
    }
}