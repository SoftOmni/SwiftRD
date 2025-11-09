using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

public class Arrow : SwiftLeafNode, ISwiftPunctuator
{
    public const string Value = "->";
    
    internal Arrow(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Arrow)
    { }

    internal Arrow(ISwiftNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, NodeTypes.NodeTypes.Arrow)
    { }


    public string AsString => Value;

    public static Arrow Create()
    {
        return new Arrow(new EditableBuffer(Value));
    }

    public static Arrow Create(ISwiftNode parent)
    {
        return new Arrow(new EditableBuffer(Value));
    }
}