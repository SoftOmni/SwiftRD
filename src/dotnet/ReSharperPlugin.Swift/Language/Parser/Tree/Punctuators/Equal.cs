using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

public class Equal : SwiftLeafNode, ISwiftPunctuator
{
    public const string Value = "=";
    
    internal Equal(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Equal)
    { }

    internal Equal(ISwiftNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, NodeTypes.NodeTypes.Equal)
    { }


    public string AsString => Value;

    public static Equal Create()
    {
        return new Equal(new EditableBuffer(Value));
    }

    public static Equal Create(ISwiftNode parent)
    {
        return new Equal(new EditableBuffer(Value));
    }
}