using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

public class RightParenthesis : SwiftLeafNode, ISwiftPunctuator
{
    public const string Value = ")";
    
    internal RightParenthesis(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.RightParenthesis)
    { }

    internal RightParenthesis(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, SwiftNodeTypes.RightParenthesis)
    { }


    public string AsString => Value;

    public static RightParenthesis Create()
    {
        return new RightParenthesis(new EditableBuffer(Value));
    }

    public static RightParenthesis Create(SwiftInternalNode parent)
    {
        return new RightParenthesis(new EditableBuffer(Value));
    }
}