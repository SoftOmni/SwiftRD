using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.KeyPathExpressions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

public class QuestionMark : SwiftLeafNode, ISwiftPunctuator, IKeyPathPostfix
{
    public const string Value = "?";
    
    internal QuestionMark(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.QuestionMark)
    { }

    internal QuestionMark(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, SwiftNodeTypes.QuestionMark)
    { }


    public string AsString => Value;

    public static QuestionMark Create()
    {
        return new QuestionMark(new EditableBuffer(Value));
    }

    public static QuestionMark Create(SwiftInternalNode parent)
    {
        return new QuestionMark(new EditableBuffer(Value));
    }
}