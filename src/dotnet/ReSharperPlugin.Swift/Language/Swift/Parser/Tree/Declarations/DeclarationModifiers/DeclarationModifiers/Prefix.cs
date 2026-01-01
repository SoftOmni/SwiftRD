using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;
using ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Operators;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public class Prefix : DeclarationModifierLeaf, ISwiftKeyword
{
    public const string Keyword = "prefix";
    
    public PrefixOperatorDeclaration? PrefixOperatorDeclaration { get; internal set; }
    
    internal Prefix(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Prefix)
    { }

    internal Prefix(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Prefix)
    {
        if (parent is PrefixOperatorDeclaration prefixOperatorDeclaration)
        {
            PrefixOperatorDeclaration = prefixOperatorDeclaration;
        }
    }

    internal Prefix(PrefixOperatorDeclaration parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Prefix)
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