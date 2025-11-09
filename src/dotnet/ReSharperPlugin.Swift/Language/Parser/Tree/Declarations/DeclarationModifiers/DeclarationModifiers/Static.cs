using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public class Static : DeclarationModifierLeaf, ISwiftKeyword
{
    public const string Keyword = "static";
    
    internal Static(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Static)
    { }

    internal Static(ISwiftNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, NodeTypes.NodeTypes.Static)
    { }


    public string KeywordValue => Keyword;

    public static Static Create()
    {
        return new Static(new EditableBuffer(Keyword));
    }

    public static Static Create(ISwiftNode parent)
    {
        return new Static(new EditableBuffer(Keyword));
    }
}