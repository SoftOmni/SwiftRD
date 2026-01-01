using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers.Leaves;

public class Private : LeafAccessLevelModifier, ISwiftKeyword
{
    public const string Keyword = "private";
    
    internal Private(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Private)
    { }

    internal Private(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, NodeTypes.NodeTypes.Private)
    { }


    public string KeywordValue => Keyword;

    public static Private Create()
    {
        return new Private(new EditableBuffer(Keyword));
    }

    public static Private Create(SwiftInternalNode parent)
    {
        return new Private(new EditableBuffer(Keyword));
    }
}