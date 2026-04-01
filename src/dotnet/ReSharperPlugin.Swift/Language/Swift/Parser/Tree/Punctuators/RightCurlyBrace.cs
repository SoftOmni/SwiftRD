using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

public class RightCurlyBrace : SwiftLeafNode, ISwiftPunctuator
{
    public const string Value = "}";
    
    internal RightCurlyBrace(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.RightCurlyBrace)
    { }

    internal RightCurlyBrace(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, SwiftNodeTypes.RightCurlyBrace)
    { }


    public string AsString => Value;

    public static RightCurlyBrace Create()
    {
        return new RightCurlyBrace(new EditableBuffer(Value));
    }

    public static RightCurlyBrace Create(SwiftInternalNode parent)
    {
        return new RightCurlyBrace(new EditableBuffer(Value));
    }
}