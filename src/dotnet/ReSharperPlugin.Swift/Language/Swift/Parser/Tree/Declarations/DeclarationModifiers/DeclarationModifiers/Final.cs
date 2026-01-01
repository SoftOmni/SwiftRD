using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public class Final : DeclarationModifierLeaf, ISwiftKeyword
{
    public const string Keyword = "final";
    
    internal Final(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Final)
    { }

    internal Final(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, NodeTypes.NodeTypes.Final)
    { }


    public string KeywordValue => Keyword;

    public static Final Create()
    {
        return new Final(new EditableBuffer(Keyword));
    }

    public static Final Create(SwiftInternalNode parent)
    {
        return new Final(new EditableBuffer(Keyword));
    }
}