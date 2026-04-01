using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Wildcards;

public class Wildcard : PrimaryExpressionLeafNode, ISwiftKeyword
{
    public const string Keyword = "_";

    internal Wildcard(IEditableBuffer buffer)
        : base(buffer, SwiftNodeTypes.Underscore)
    { }

    internal Wildcard(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Underscore)
    { }


    public string KeywordValue => Keyword;

    public static Wildcard Create()
    {
        return new Wildcard(new EditableBuffer(Keyword));
    }

    public static Wildcard Create(SwiftInternalNode parent)
    {
        return new Wildcard(parent, new EditableBuffer(Keyword));
    }
}