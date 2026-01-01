using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

public class Backtick : SwiftLeafNode, ISwiftPunctuator
{
    public const string Value = "->";
    
    internal Backtick(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Backtick)
    { }

    internal Backtick(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, NodeTypes.NodeTypes.Backtick)
    { }


    public string AsString => Value;

    public static Backtick Create()
    {
        return new Backtick(new EditableBuffer(Value));
    }

    public static Backtick Create(SwiftInternalNode parent)
    {
        return new Backtick(new EditableBuffer(Value));
    }
}