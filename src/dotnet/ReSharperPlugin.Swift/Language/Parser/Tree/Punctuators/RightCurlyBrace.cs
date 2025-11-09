using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

public class RightCurlyBrace : SwiftLeafNode, ISwiftPunctuator
{
    public const string Value = "}";
    
    internal RightCurlyBrace(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.RightCurlyBrace)
    { }

    internal RightCurlyBrace(ISwiftNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, NodeTypes.NodeTypes.RightCurlyBrace)
    { }


    public string AsString => Value;

    public static RightCurlyBrace Create()
    {
        return new RightCurlyBrace(new EditableBuffer(Value));
    }

    public static RightCurlyBrace Create(ISwiftNode parent)
    {
        return new RightCurlyBrace(new EditableBuffer(Value));
    }
}