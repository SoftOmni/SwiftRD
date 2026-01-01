using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

public class LeftParenthesis : SwiftLeafNode, ISwiftPunctuator
{
    public const string Value = "(";
    
    internal LeftParenthesis(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.LeftParenthesis)
    { }

    internal LeftParenthesis(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, NodeTypes.NodeTypes.LeftParenthesis)
    { }


    public string AsString => Value;

    public static LeftParenthesis Create()
    {
        return new LeftParenthesis(new EditableBuffer(Value));
    }

    public static LeftParenthesis Create(SwiftInternalNode parent)
    {
        return new LeftParenthesis(new EditableBuffer(Value));
    }
}