using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

public class LeftAngleBracket : SwiftLeafNode, ISwiftPunctuator
{
    public const string Value = "<";
    
    internal LeftAngleBracket(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.LeftAngleBracket)
    { }

    internal LeftAngleBracket(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, SwiftNodeTypes.LeftAngleBracket)
    { }


    public string AsString => Value;

    public static LeftAngleBracket Create()
    {
        return new LeftAngleBracket(new EditableBuffer(Value));
    }

    public static LeftAngleBracket Create(SwiftInternalNode parent)
    {
        return new LeftAngleBracket(new EditableBuffer(Value));
    }
}