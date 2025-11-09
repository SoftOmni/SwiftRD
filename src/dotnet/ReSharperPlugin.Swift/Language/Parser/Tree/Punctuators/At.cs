using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

public class At : SwiftLeafNode, ISwiftPunctuator
{
    public const string Value = "@";
    
    internal At(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.At)
    { }

    internal At(ISwiftNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, NodeTypes.NodeTypes.At)
    { }


    public string AsString => Value;

    public static At Create()
    {
        return new At(new EditableBuffer(Value));
    }

    public static At Create(ISwiftNode parent)
    {
        return new At(new EditableBuffer(Value));
    }
}