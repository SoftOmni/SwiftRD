using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Imports;

public class Import : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "import";
    
    public ImportDeclaration? ImportDeclaration { get; internal set; }
    
    internal Import(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.Import)
    { }

    internal Import(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Import)
    {
        if (parent is ImportDeclaration importDeclaration)
        {
            ImportDeclaration = importDeclaration;
        }
    }

    internal Import(ImportDeclaration importDeclaration, IEditableBuffer buffer)
        : base(importDeclaration, buffer, SwiftNodeTypes.Import)
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
    
    public static Import CreateUnchecked(SwiftInternalNode parent)
    {
        return new Import(parent, new EditableBuffer(Keyword));
    }
}