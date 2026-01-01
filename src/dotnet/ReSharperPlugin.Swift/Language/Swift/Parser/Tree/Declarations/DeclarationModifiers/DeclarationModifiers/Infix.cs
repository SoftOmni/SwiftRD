using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;
using ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Operators;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public class Infix : DeclarationModifierLeaf, ISwiftKeyword
{
    public const string Keyword = "infix";
    
    public InfixOperatorDeclaration? InfixOperatorDeclaration { get; internal set; }
    
    internal Infix(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Infix)
    { }

    internal Infix(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Infix)
    {
        if (parent is InfixOperatorDeclaration infixOperatorDeclaration)
        {
            InfixOperatorDeclaration = infixOperatorDeclaration;
        }
    }

    internal Infix(InfixOperatorDeclaration parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Infix)
    {
        InfixOperatorDeclaration = parent;
    }


    public string KeywordValue => Keyword;

    public static Infix Create()
    {
        return new Infix(new EditableBuffer(Keyword));
    }

    public static Infix Create(InfixOperatorDeclaration parent)
    {
        return new Infix(parent, new EditableBuffer(Keyword));
    }
    
    public static Infix CreateUnchecked(SwiftInternalNode parent)
    {
        return new Infix(parent, new EditableBuffer(Keyword));
    }
}