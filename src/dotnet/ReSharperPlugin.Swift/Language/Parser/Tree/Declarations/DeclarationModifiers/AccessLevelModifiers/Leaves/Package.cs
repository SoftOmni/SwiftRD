using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers.Leaves;

public class Package : LeafAccessLevelModifier, ISwiftKeyword
{
    public const string Keyword = "package";
    
    internal Package(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Package)
    { }

    internal Package(ISwiftNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, NodeTypes.NodeTypes.Package)
    { }


    public string KeywordValue => Keyword;

    public static Package Create()
    {
        return new Package(new EditableBuffer(Keyword));
    }

    public static Package Create(ISwiftNode parent)
    {
        return new Package(new EditableBuffer(Keyword));
    }
}