using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

public class Comma : SwiftLeafNode, ISwiftPunctuator
{
    public const string Value = "(";
    
    internal Comma(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.Comma)
    { }

    internal Comma(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, SwiftNodeTypes.Comma)
    { }


    public string AsString => Value;

    public static Comma Create()
    {
        return new Comma(new EditableBuffer(Value));
    }

    public static Comma Create(SwiftInternalNode parent)
    {
        return new Comma(new EditableBuffer(Value));
    }
}