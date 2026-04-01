using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.KeyPathExpressions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

public class ExclamationMark : SwiftLeafNode, ISwiftPunctuator, IKeyPathPostfix
{
    public const string Value = "!";
    
    internal ExclamationMark(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.ExclamationMark)
    { }

    internal ExclamationMark(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, SwiftNodeTypes.ExclamationMark)
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