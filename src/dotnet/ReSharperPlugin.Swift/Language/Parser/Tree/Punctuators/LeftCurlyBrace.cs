using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

public class LeftCurlyBrace : SwiftLeafNode, ISwiftPunctuator
{
    public const string Value = "{";
    
    internal LeftCurlyBrace(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.LeftCurlyBrace)
    { }

    internal LeftCurlyBrace(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, NodeTypes.NodeTypes.LeftCurlyBrace)
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