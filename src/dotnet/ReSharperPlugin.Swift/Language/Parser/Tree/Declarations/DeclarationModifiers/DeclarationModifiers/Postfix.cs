using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Operators;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public class Postfix : DeclarationModifierLeaf, ISwiftKeyword
{
    public const string Keyword = "postfix";
    
    public PostfixOperatorDeclaration? PostfixOperatorDeclaration { get; internal set; }
    
    internal Postfix(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Postfix)
    { }

    internal Postfix(ISwiftNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Postfix)
    {
        if (parent is PostfixOperatorDeclaration postfixOperatorDeclaration)
        {
            PostfixOperatorDeclaration = postfixOperatorDeclaration;
        }
    }

    internal Postfix(PostfixOperatorDeclaration parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Postfix)
    {
        PostfixOperatorDeclaration = parent;
    }


    public string KeywordValue => Keyword;

    public static Postfix Create()
    {
        return new Postfix(new EditableBuffer(Keyword));
    }

    public static Postfix Create(PostfixOperatorDeclaration parent)
    {
        return new Postfix(parent, new EditableBuffer(Keyword));
    }

    public static Postfix CreateUnchecked(ISwiftNode parent)
    {
        return new Postfix(parent, new EditableBuffer(Keyword));
    }
}