using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

public class LeftCurlyBrace : SwiftLeafNode, ISwiftPunctuator
{
    public const string Value = "{";
    
    internal LeftCurlyBrace(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.LeftCurlyBrace)
    { }

    internal LeftCurlyBrace(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, SwiftNodeTypes.LeftCurlyBrace)
    { }


    public string AsString => Value;

    public static LeftCurlyBrace Create()
    {
        return new LeftCurlyBrace(new EditableBuffer(Value));
    }

    public static LeftCurlyBrace Create(SwiftInternalNode parent)
    {
        return new LeftCurlyBrace(new EditableBuffer(Value));
    }
}