using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

public class LeftSquareBracket : SwiftLeafNode, ISwiftPunctuator
{
    public const string Value = "[";
    
    internal LeftSquareBracket(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.LeftSquareBracket)
    { }

    internal LeftSquareBracket(SwiftInternalNode parent, int parentIndex, int parentTextIndex, IEditableBuffer buffer) 
        : base(parent, parentIndex, parentTextIndex, buffer, NodeTypes.NodeTypes.LeftSquareBracket)
    { }


    public string AsString => Value;

    public static LeftSquareBracket Create()
    {
        return new LeftSquareBracket(new EditableBuffer(Value));
    }

    public static LeftSquareBracket Create(SwiftInternalNode parent, int parentIndex)
    {
        // TODO: Develop core SwiftInternalNode and SwiftLeafNode classes to avoid some of this extra work
        LeftSquareBracket leftSquareBracket = new(new EditableBuffer(Value));
        leftSquareBracket.AttachToParent(parent, parentIndex);

        return leftSquareBracket;
    }

    protected override ISwiftNode Clone()
    {
        return Create();
    }
}