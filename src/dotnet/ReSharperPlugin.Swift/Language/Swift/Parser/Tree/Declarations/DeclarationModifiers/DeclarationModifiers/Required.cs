using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public class Required : DeclarationModifierLeaf, ISwiftKeyword
{
    public const string Keyword = "required";
    
    internal Required(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Required)
    { }

    internal Required(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, NodeTypes.NodeTypes.Required)
    { }


    public string KeywordValue => Keyword;

    public static Required Create()
    {
        return new Required(new EditableBuffer(Keyword));
    }

    public static Required Create(SwiftInternalNode parent)
    {
        return new Required(new EditableBuffer(Keyword));
    }
}