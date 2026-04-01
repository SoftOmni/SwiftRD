using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

public class Period : SwiftLeafNode, ISwiftPunctuator
{
    public const string Value = "(";
    
    internal Period(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.Period)
    { }

    internal Period(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, SwiftNodeTypes.Period)
    { }


    public string AsString => Value;

    public static Period Create()
    {
        return new Period(new EditableBuffer(Value));
    }

    public static Period Create(SwiftInternalNode parent)
    {
        return new Period(new EditableBuffer(Value));
    }
}