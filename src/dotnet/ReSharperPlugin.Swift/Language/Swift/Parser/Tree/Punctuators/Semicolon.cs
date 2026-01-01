using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

public class Semicolon : SwiftLeafNode, ISwiftPunctuator
{
    public const string Value = ";";
    
    internal Semicolon(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Semicolon)
    { }

    internal Semicolon(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, NodeTypes.NodeTypes.Semicolon)
    { }


    public string AsString => Value;

    public static Semicolon Create()
    {
        return new Semicolon(new EditableBuffer(Value));
    }

    public static Semicolon Create(SwiftInternalNode parent)
    {
        return new Semicolon(new EditableBuffer(Value));
    }
}