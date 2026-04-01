using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

public class LeftParenthesis : SwiftLeafNode, ISwiftPunctuator
{
    public const string Value = "(";
    
    internal LeftParenthesis(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.LeftParenthesis)
    { }

    internal LeftParenthesis(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, SwiftNodeTypes.LeftParenthesis)
    { }


    public string AsString => Value;

    public static LeftParenthesis Create()
    {
        return new LeftParenthesis(new EditableBuffer(Value));
    }

    public static LeftParenthesis Create(SwiftInternalNode parent)
    {
        return new LeftParenthesis(new EditableBuffer(Value));
    }
}