using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

public class Comma : SwiftLeafNode, ISwiftPunctuator
{
    public const string Value = "(";
    
    internal Comma(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Comma)
    { }

    internal Comma(ISwiftNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, NodeTypes.NodeTypes.Comma)
    { }


    public string AsString => Value;

    public static Comma Create()
    {
        return new Comma(new EditableBuffer(Value));
    }

    public static Comma Create(ISwiftNode parent)
    {
        return new Comma(new EditableBuffer(Value));
    }
}