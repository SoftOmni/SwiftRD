using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public class Unowned : DeclarationModifierLeaf, ISwiftKeyword
{
    public const string Keyword = "unowned";
    
    internal Unowned(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Unowned)
    { }

    internal Unowned(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, NodeTypes.NodeTypes.Unowned)
    { }


    public string KeywordValue => Keyword;

    public static Unowned Create()
    {
        return new Unowned(new EditableBuffer(Keyword));
    }

    public static Unowned Create(SwiftInternalNode parent)
    {
        return new Unowned(new EditableBuffer(Keyword));
    }
}