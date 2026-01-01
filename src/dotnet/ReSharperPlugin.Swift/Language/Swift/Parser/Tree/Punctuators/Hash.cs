using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

public class Hash : SwiftLeafNode, ISwiftPunctuator
{
    public const string Value = "#";
    
    internal Hash(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Hash)
    { }

    internal Hash(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, NodeTypes.NodeTypes.Hash)
    { }


    public string AsString => Value;

    public static Hash Create()
    {
        return new Hash(new EditableBuffer(Value));
    }

    public static Hash Create(SwiftInternalNode parent)
    {
        return new Hash(new EditableBuffer(Value));
    }
}