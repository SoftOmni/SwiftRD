using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Enumerations.Cases;

public class Case : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "case";

    internal Case(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Case)
    { }

    internal Case(ISwiftNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Case)
    { }

    public string KeywordValue => Keyword;

    public static Case Create()
    {
        return new Case(new EditableBuffer(Keyword));
    }

    public static Case Create(ISwiftNode parent)
    {
        return new Case(parent, new EditableBuffer(Keyword));
    }
}