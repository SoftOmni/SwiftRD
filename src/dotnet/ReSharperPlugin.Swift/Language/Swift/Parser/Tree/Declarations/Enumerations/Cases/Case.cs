using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Enumerations.Cases;

public class Case : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "case";

    internal Case(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Case)
    { }

    internal Case(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Case)
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