using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

public class RightParenthesis : SwiftLeafNode, ISwiftPunctuator
{
    public const string Value = ")";
    
    internal RightParenthesis(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.RightParenthesis)
    { }

    internal RightParenthesis(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, NodeTypes.NodeTypes.RightParenthesis)
    { }


    public string AsString => Value;

    public static RightParenthesis Create()
    {
        return new RightParenthesis(new EditableBuffer(Value));
    }

    public static RightParenthesis Create(SwiftInternalNode parent)
    {
        return new RightParenthesis(new EditableBuffer(Value));
    }
}