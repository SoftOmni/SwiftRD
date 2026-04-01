using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

public class Arrow : SwiftLeafNode, ISwiftPunctuator
{
    public const string Value = "->";
    
    internal Arrow(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.Arrow)
    { }

    internal Arrow(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, SwiftNodeTypes.Arrow)
    { }


    public string AsString => Value;

    public static Arrow Create()
    {
        return new Arrow(new EditableBuffer(Value));
    }

    public static Arrow Create(SwiftInternalNode parent)
    {
        return new Arrow(new EditableBuffer(Value));
    }
}