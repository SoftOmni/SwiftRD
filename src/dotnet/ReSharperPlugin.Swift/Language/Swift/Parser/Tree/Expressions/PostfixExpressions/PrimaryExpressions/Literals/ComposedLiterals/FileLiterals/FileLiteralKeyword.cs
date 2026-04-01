using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.ComposedLiterals.FileLiterals;

public class FileLiteralKeyword : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "#fileLiteral";
    
    public FileLiteral? FileLiteral { get; internal set; }

    internal FileLiteralKeyword(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.ReservedFileLiteral)
    { }

    internal FileLiteralKeyword(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.ReservedFileLiteral)
    {
        if (parent is FileLiteral fileLiteral)
        {
            FileLiteral = fileLiteral;
        }
    }

    internal FileLiteralKeyword(FileLiteral parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.ReservedFileLiteral)
    {
        FileLiteral = parent;
    }

    public string KeywordValue => Keyword;

    public static FileLiteralKeyword Create()
    {
        return new FileLiteralKeyword(new EditableBuffer(Keyword));
    }

    public static FileLiteralKeyword Create(FileLiteral fileLiteral)
    {
        return new FileLiteralKeyword(fileLiteral, new EditableBuffer(Keyword));
    }

    public static FileLiteralKeyword CreateUnchecked(SwiftInternalNode parent)
    {
        return new FileLiteralKeyword(parent, new EditableBuffer(Keyword));
    }
}