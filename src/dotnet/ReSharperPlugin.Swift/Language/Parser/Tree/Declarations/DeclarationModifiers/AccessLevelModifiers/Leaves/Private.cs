using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers.Leaves;

public class Private : LeafAccessLevelModifier, ISwiftKeyword
{
    public const string Keyword = "private";
    
    internal Private(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Private)
    { }

    internal Private(ISwiftNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, NodeTypes.NodeTypes.Private)
    { }


    public string KeywordValue => Keyword;

    public static Private Create()
    {
        return new Private(new EditableBuffer(Keyword));
    }

    public static Private Create(ISwiftNode parent)
    {
        return new Private(new EditableBuffer(Keyword));
    }
}