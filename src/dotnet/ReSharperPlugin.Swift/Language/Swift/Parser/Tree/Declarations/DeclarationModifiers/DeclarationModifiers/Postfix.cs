using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public class Postfix : DeclarationModifierLeaf, ISwiftKeywordNode
{
    public const string Keyword = "postfix";
    
    public PostfixOperatorDeclaration? PostfixOperatorDeclaration { get; internal set; }
    
    internal Postfix(IEditableBuffer buffer) 
        : base(SwiftNodeTypes.Postfix, buffer)
    { }

    internal Postfix(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Postfix)
    {
        if (parent is PostfixOperatorDeclaration postfixOperatorDeclaration)
        {
            PostfixOperatorDeclaration = postfixOperatorDeclaration;
        }
    }

    internal Postfix(PostfixOperatorDeclaration parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Postfix)
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

    public static Postfix CreateUnchecked(SwiftInternalNode parent)
    {
        return new Postfix(parent, new EditableBuffer(Keyword));
    }
}