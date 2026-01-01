using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public class Weak : DeclarationModifierLeaf, ISwiftKeyword
{
    public const string Keyword = "weak";
    
    internal Weak(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Weak)
    { }

    internal Weak(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, NodeTypes.NodeTypes.Weak)
    { }


    public string KeywordValue => Keyword;

    public static Weak Create()
    {
        return new Weak(new EditableBuffer(Keyword));
    }

    public static Weak Create(SwiftInternalNode parent)
    {
        return new Weak(new EditableBuffer(Keyword));
    }
}