using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public class Unowned : DeclarationModifierLeaf, ISwiftKeyword
{
    public const string Keyword = "unowned";
    
    internal Unowned(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Unowned)
    { }

    internal Unowned(ISwiftNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, NodeTypes.NodeTypes.Unowned)
    { }


    public string KeywordValue => Keyword;

    public static Unowned Create()
    {
        return new Unowned(new EditableBuffer(Keyword));
    }

    public static Unowned Create(ISwiftNode parent)
    {
        return new Unowned(new EditableBuffer(Keyword));
    }
}