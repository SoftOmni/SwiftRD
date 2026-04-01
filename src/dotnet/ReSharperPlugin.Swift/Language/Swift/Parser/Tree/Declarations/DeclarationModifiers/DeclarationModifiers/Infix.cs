using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public class Infix : DeclarationModifierLeaf, ISwiftKeyword
{
    public const string Keyword = "infix";

    internal Infix(IEditableBuffer buffer)
        : base(buffer)
    { }

    internal Infix(IEditableBuffer buffer, SwiftCompositeNode parent, int parentIndex, int parentTextIndex)
        : base(buffer, parent, parentIndex, parentTextIndex)
    {
        if (parent is InfixOperatorDeclaration infixOperatorDeclaration)
        {
            InfixOperatorDeclaration = infixOperatorDeclaration;
        }
    }

    internal Infix(IEditableBuffer buffer, InfixOperatorDeclaration parent, int parentIndex, int parentTextIndex)
        : base(buffer, parent, parentIndex, parentTextIndex)
    {
        InfixOperatorDeclaration = parent;
    }

    public InfixOperatorDeclaration? InfixOperatorDeclaration { get; internal set; }

    public string KeywordValue => Keyword;

    public static Infix Create()
    {
        return new Infix(new EditableBuffer(Keyword));
    }

    public static Infix Create(InfixOperatorDeclaration parent)
    {
        return new Infix(parent, new EditableBuffer(Keyword));
    }
    
    public static Infix CreateUnchecked(SwiftInternalNode<> parent)
    {
        return new Infix(parent, new EditableBuffer(Keyword));
    }
}