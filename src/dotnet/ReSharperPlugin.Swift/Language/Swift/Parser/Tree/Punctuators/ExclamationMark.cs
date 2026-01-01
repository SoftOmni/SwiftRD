using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;
using ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.KeyPathExpressions;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

public class ExclamationMark : SwiftLeafNode, ISwiftPunctuator, IKeyPathPostfix
{
    public const string Value = "!";
    
    internal ExclamationMark(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.ExclamationMark)
    { }

    internal ExclamationMark(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, NodeTypes.NodeTypes.ExclamationMark)
    { }


    public string AsString => Value;

    public static ExclamationMark Create()
    {
        return new ExclamationMark(new EditableBuffer(Value));
    }

    public static ExclamationMark Create(SwiftInternalNode parent)
    {
        return new ExclamationMark(new EditableBuffer(Value));
    }
}