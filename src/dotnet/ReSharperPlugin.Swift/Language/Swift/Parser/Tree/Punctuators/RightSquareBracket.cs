using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

public class RightSquareBracket : SwiftLeafNode, ISwiftPunctuator
{
    public const string Value = "]";
    
    internal RightSquareBracket(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.RightSquareBracket)
    { }

    internal RightSquareBracket(SwiftInternalNode parent, int parentIndex, int parentTextIndex, IEditableBuffer buffer) 
        : base(parent, parentIndex, parentTextIndex, buffer, NodeTypes.NodeTypes.RightSquareBracket)
    { }


    public string AsString => Value;

    public static RightSquareBracket Create()
    {
        return new RightSquareBracket(new EditableBuffer(Value));
    }

    public static RightSquareBracket Create(SwiftInternalNode parent, int parentIndex)
    {
        RightSquareBracket rightSquareBracket = new(new EditableBuffer(Value));
        rightSquareBracket.AttachToParent(parent, parentIndex);

        return rightSquareBracket;
    }

    protected override ISwiftNode Clone()
    {
        return Create();
    }
}