using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

public class LeftParenthesis : SwiftLeafNode, ISwiftPunctuator
{
    public const string Value = "(";
    
    internal LeftParenthesis(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.LeftParenthesis)
    { }

    internal LeftParenthesis(ISwiftNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, NodeTypes.NodeTypes.LeftParenthesis)
    { }


    public string AsString => Value;

    public static LeftParenthesis Create()
    {
        return new LeftParenthesis(new EditableBuffer(Value));
    }

    public static LeftParenthesis Create(ISwiftNode parent)
    {
        return new LeftParenthesis(new EditableBuffer(Value));
    }
}