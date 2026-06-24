using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public class Prefix : DeclarationModifierLeaf, ISwiftKeywordNode
{
    public const string Keyword = "prefix";
    
    public PrefixOperatorDeclaration? PrefixOperatorDeclaration { get; internal set; }
    
    internal Prefix(IEditableBuffer buffer) 
        : base(SwiftNodeTypes.Prefix, buffer)
    { }

    internal Prefix(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Prefix)
    {
        if (parent is PrefixOperatorDeclaration prefixOperatorDeclaration)
        {
            PrefixOperatorDeclaration = prefixOperatorDeclaration;
        }
    }

    internal Prefix(PrefixOperatorDeclaration parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Prefix)
    {
        PrefixOperatorDeclaration = parent;
    }


    public string KeywordValue => Keyword;

    public static Prefix Create()
    {
        return new Prefix(new EditableBuffer(Keyword));
    }

    public static Prefix Create(PrefixOperatorDeclaration parent)
    {
        return new Prefix(parent, new EditableBuffer(Keyword));
    }
    
    public static Prefix CreateUnchecked(SwiftInternalNode parent)
    {
        return new Prefix(parent, new EditableBuffer(Keyword));
    }
}