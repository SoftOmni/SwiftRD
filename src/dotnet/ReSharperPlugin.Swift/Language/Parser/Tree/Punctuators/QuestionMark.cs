using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.KeyPathExpressions;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

public class QuestionMark : SwiftLeafNode, ISwiftPunctuator, IKeyPathPostfix
{
    public const string Value = "?";
    
    internal QuestionMark(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.QuestionMark)
    { }

    internal QuestionMark(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, NodeTypes.NodeTypes.QuestionMark)
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