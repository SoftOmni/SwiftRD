using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

public class Period : SwiftLeafNode, ISwiftPunctuator
{
    public const string Value = "(";
    
    internal Period(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Period)
    { }

    internal Period(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, NodeTypes.NodeTypes.Period)
    { }


    public string AsString => Value;

    public static Period Create()
    {
        return new Period(new EditableBuffer(Value));
    }

    public static Period Create(SwiftInternalNode parent)
    {
        return new Period(new EditableBuffer(Value));
    }
}