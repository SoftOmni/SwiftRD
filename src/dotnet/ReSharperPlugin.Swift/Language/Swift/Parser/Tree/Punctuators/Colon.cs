using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

public class Colon : SwiftLeafNode, ISwiftPunctuator
{
    public const string Value = ":";
    
    internal Colon(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.Colon)
    { }

    internal Colon(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, SwiftNodeTypes.Colon)
    { }


    public string AsString => Value;

    public static Colon Create()
    {
        return new Colon(new EditableBuffer(Value));
    }

    public static Colon Create(SwiftInternalNode parent)
    {
        return new Colon(new EditableBuffer(Value));
    }
}