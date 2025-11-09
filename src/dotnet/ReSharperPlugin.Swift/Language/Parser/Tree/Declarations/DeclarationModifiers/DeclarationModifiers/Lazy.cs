using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public class Lazy : DeclarationModifierLeaf, ISwiftKeyword
{
    public const string Keyword = "lazy";
    
    internal Lazy(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Lazy)
    { }

    internal Lazy(ISwiftNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, NodeTypes.NodeTypes.Lazy)
    { }


    public string KeywordValue => Keyword;

    public static Lazy Create()
    {
        return new Lazy(new EditableBuffer(Keyword));
    }

    public static Lazy Create(ISwiftNode parent)
    {
        return new Lazy(new EditableBuffer(Keyword));
    }
}