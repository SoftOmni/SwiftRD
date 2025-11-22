using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

public class RightAngleBracket : SwiftLeafNode, ISwiftPunctuator
{
    public const string Value = ">";
    
    internal RightAngleBracket(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.RightAngleBracket)
    { }

    internal RightAngleBracket(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, NodeTypes.NodeTypes.RightAngleBracket)
    { }


    public string AsString => Value;

    public static RightAngleBracket Create()
    {
        return new RightAngleBracket(new EditableBuffer(Value));
    }

    public static RightAngleBracket Create(SwiftInternalNode parent)
    {
        return new RightAngleBracket(new EditableBuffer(Value));
    }
}