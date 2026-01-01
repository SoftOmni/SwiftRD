using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

public class Comma : SwiftLeafNode, ISwiftPunctuator
{
    public const string Value = "(";
    
    internal Comma(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Comma)
    { }

    internal Comma(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, NodeTypes.NodeTypes.Comma)
    { }


    public string AsString => Value;

    public static Comma Create()
    {
        return new Comma(new EditableBuffer(Value));
    }

    public static Comma Create(SwiftInternalNode parent)
    {
        return new Comma(new EditableBuffer(Value));
    }
}