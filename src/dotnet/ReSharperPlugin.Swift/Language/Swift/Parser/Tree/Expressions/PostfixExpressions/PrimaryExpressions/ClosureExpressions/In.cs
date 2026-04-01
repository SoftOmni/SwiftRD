using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions;

public class In : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "in";

    internal In(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.In)
    { }

    internal In(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.In)
    { }

    public string KeywordValue => Keyword;

    public static In Create()
    {
        return new In(new EditableBuffer(Keyword));
    }

    public static In Create(SwiftInternalNode parent)
    {
        return new In(parent, new EditableBuffer(Keyword));
    }
}