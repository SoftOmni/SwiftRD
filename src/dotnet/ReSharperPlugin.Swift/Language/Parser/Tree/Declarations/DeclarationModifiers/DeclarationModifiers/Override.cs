using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public class Override : DeclarationModifierLeaf, ISwiftKeyword
{
    public const string Keyword = "override";
    
    internal Override(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Override)
    { }

    internal Override(ISwiftNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, NodeTypes.NodeTypes.Override)
    { }


    public string KeywordValue => Keyword;

    public static Override Create()
    {
        return new Override(new EditableBuffer(Keyword));
    }

    public static Override Create(ISwiftNode parent)
    {
        return new Override(new EditableBuffer(Keyword));
    }
}