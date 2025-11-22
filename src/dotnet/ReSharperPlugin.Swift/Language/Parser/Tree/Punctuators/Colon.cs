using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

public class Colon : SwiftLeafNode, ISwiftPunctuator
{
    public const string Value = ":";
    
    internal Colon(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Colon)
    { }

    internal Colon(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, NodeTypes.NodeTypes.Colon)
    { }


    public string AsString => Value;

    public static Colon Create()
    {
        return new Colon(new EditableBuffer(Value));
    }

    public static Colon Create(SwiftInternalNode parent)
    {
        return new Colon(new EditableBuffer(Value));
    }
}