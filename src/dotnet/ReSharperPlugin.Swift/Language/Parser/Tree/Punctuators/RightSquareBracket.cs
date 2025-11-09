using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

public class RightSquareBracket : SwiftLeafNode, ISwiftPunctuator
{
    public const string Value = "]";
    
    internal RightSquareBracket(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.RightSquareBracket)
    { }

    internal RightSquareBracket(ISwiftNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, NodeTypes.NodeTypes.RightSquareBracket)
    { }


    public string AsString => Value;

    public static RightSquareBracket Create()
    {
        return new RightSquareBracket(new EditableBuffer(Value));
    }

    public static RightSquareBracket Create(ISwiftNode parent)
    {
        return new RightSquareBracket(new EditableBuffer(Value));
    }
}