using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Imports;

public class Import : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "import";
    
    public ImportDeclaration? ImportDeclaration { get; internal set; }
    
    internal Import(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Import)
    { }

    internal Import(ISwiftNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Import)
    {
        if (parent is ImportDeclaration importDeclaration)
        {
            ImportDeclaration = importDeclaration;
        }
    }

    internal Import(ImportDeclaration importDeclaration, IEditableBuffer buffer)
        : base(importDeclaration, buffer, NodeTypes.NodeTypes.Import)
    {
        ImportDeclaration = importDeclaration;
    }

    public string KeywordValue => Keyword;

    public static Import Create()
    {
        return new Import(new EditableBuffer(Keyword));
    }
    
    public static Import Create(ImportDeclaration importDeclaration)
    {
        return new Import(importDeclaration, new EditableBuffer(Keyword));
    }
    
    public static Import CreateUnchecked(ISwiftNode parent)
    {
        return new Import(parent, new EditableBuffer(Keyword));
    }
}