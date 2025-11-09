using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public class Dynamic : DeclarationModifierLeaf, ISwiftKeyword
{
    public const string Keyword = "dynamic";
    
    internal Dynamic(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Dynamic)
    { }

    internal Dynamic(ISwiftNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, NodeTypes.NodeTypes.Dynamic)
    { }


    public string KeywordValue => Keyword;

    public static Dynamic Create()
    {
        return new Dynamic(new EditableBuffer(Keyword));
    }

    public static Dynamic Create(ISwiftNode parent)
    {
        return new Dynamic(new EditableBuffer(Keyword));
    }
}