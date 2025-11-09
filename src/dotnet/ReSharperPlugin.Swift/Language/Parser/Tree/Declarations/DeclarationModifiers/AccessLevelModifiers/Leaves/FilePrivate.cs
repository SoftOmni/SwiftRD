using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers.Leaves;

public class FilePrivate : LeafAccessLevelModifier, ISwiftKeyword
{
    public const string Keyword = "filePrivate";
    
    internal FilePrivate(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.FilePrivate)
    { }

    internal FilePrivate(ISwiftNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, NodeTypes.NodeTypes.FilePrivate)
    { }


    public string KeywordValue => Keyword;

    public static FilePrivate Create()
    {
        return new FilePrivate(new EditableBuffer(Keyword));
    }

    public static FilePrivate Create(ISwiftNode parent)
    {
        return new FilePrivate(new EditableBuffer(Keyword));
    }
}