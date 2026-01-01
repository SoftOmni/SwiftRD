using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

public class Ampersand : SwiftLeafNode, ISwiftPunctuator
{
    public const string Value = "&";
    
    internal Ampersand(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Ampersand)
    { }

    internal Ampersand(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, NodeTypes.NodeTypes.Ampersand)
    { }


    public string AsString => Value;

    public static Ampersand Create()
    {
        return new Ampersand(new EditableBuffer(Value));
    }

    public static Ampersand Create(SwiftInternalNode parent)
    {
        return new Ampersand(new EditableBuffer(Value));
    }
}