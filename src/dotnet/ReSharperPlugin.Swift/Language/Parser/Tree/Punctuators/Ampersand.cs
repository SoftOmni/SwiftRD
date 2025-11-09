using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

public class Ampersand : SwiftLeafNode, ISwiftPunctuator
{
    public const string Value = "&";
    
    internal Ampersand(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Ampersand)
    { }

    internal Ampersand(ISwiftNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, NodeTypes.NodeTypes.Ampersand)
    { }


    public string AsString => Value;

    public static Ampersand Create()
    {
        return new Ampersand(new EditableBuffer(Value));
    }

    public static Ampersand Create(ISwiftNode parent)
    {
        return new Ampersand(new EditableBuffer(Value));
    }
}