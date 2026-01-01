using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public class Dynamic : DeclarationModifierLeaf, ISwiftKeyword
{
    public const string Keyword = "dynamic";
    
    internal Dynamic(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Dynamic)
    { }

    internal Dynamic(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, NodeTypes.NodeTypes.Dynamic)
    { }


    public string KeywordValue => Keyword;

    public static Dynamic Create()
    {
        return new Dynamic(new EditableBuffer(Keyword));
    }

    public static Dynamic Create(SwiftInternalNode parent)
    {
        return new Dynamic(new EditableBuffer(Keyword));
    }
}