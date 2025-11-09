using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

public class LeftSquareBracket : SwiftLeafNode, ISwiftPunctuator
{
    public const string Value = "[";
    
    internal LeftSquareBracket(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.LeftSquareBracket)
    { }

    internal LeftSquareBracket(ISwiftNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, NodeTypes.NodeTypes.LeftSquareBracket)
    { }


    public string AsString => Value;

    public static LeftSquareBracket Create()
    {
        return new LeftSquareBracket(new EditableBuffer(Value));
    }

    public static LeftSquareBracket Create(ISwiftNode parent)
    {
        return new LeftSquareBracket(new EditableBuffer(Value));
    }
}