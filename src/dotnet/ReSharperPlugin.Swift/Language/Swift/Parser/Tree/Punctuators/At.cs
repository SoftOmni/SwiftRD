using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

public class At : SwiftLeafNode, ISwiftPunctuator
{
    public const string Value = "@";
    
    internal At(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.At)
    { }

    internal At(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, SwiftNodeTypes.At)
    { }


    public string AsString => Value;

    public static At Create()
    {
        return new At(new EditableBuffer(Value));
    }

    public static At Create(SwiftInternalNode parent)
    {
        return new At(new EditableBuffer(Value));
    }
}