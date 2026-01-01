using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

public class LeftAngleBracket : SwiftLeafNode, ISwiftPunctuator
{
    public const string Value = "<";
    
    internal LeftAngleBracket(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.LeftAngleBracket)
    { }

    internal LeftAngleBracket(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, NodeTypes.NodeTypes.LeftAngleBracket)
    { }


    public string AsString => Value;

    public static LeftAngleBracket Create()
    {
        return new LeftAngleBracket(new EditableBuffer(Value));
    }

    public static LeftAngleBracket Create(SwiftInternalNode parent)
    {
        return new LeftAngleBracket(new EditableBuffer(Value));
    }
}