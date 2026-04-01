using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Enumerations.Cases;

public class Case : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "case";

    internal Case(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.Case)
    { }

    internal Case(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Case)
    { }

    public string KeywordValue => Keyword;

    public static Case Create()
    {
        return new Case(new EditableBuffer(Keyword));
    }

    public static Case Create(SwiftInternalNode parent)
    {
        return new Case(parent, new EditableBuffer(Keyword));
    }
}