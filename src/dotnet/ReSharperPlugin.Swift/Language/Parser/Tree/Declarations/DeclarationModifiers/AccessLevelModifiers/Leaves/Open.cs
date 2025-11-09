using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers.Leaves;

public class Open : LeafAccessLevelModifier, ISwiftKeyword
{
    public const string Keyword = "open";
    
    internal Open(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Open)
    { }

    internal Open(ISwiftNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, NodeTypes.NodeTypes.Open)
    { }


    public string KeywordValue => Keyword;

    public static Open Create()
    {
        return new Open(new EditableBuffer(Keyword));
    }

    public static Open Create(ISwiftNode parent)
    {
        return new Open(new EditableBuffer(Keyword));
    }
}