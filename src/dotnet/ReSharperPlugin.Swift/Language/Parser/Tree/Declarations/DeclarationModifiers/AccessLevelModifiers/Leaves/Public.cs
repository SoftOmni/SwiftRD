using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers.Leaves;

public class Public : LeafAccessLevelModifier, ISwiftKeyword
{
    public const string Keyword = "public";
    
    internal Public(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Public)
    { }

    internal Public(ISwiftNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, NodeTypes.NodeTypes.Public)
    { }


    public string KeywordValue => Keyword;

    public static Public Create()
    {
        return new Public(new EditableBuffer(Keyword));
    }

    public static Public Create(ISwiftNode parent)
    {
        return new Public(new EditableBuffer(Keyword));
    }
}