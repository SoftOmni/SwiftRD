using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

public class RightAngleBracket : SwiftLeafNode, ISwiftPunctuator
{
    public const string Value = ">";
    
    internal RightAngleBracket(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.RightAngleBracket)
    { }

    internal RightAngleBracket(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, SwiftNodeTypes.RightAngleBracket)
    { }


    public string AsString => Value;

    public static RightAngleBracket Create()
    {
        return new RightAngleBracket(new EditableBuffer(Value));
    }

    public static RightAngleBracket Create(SwiftInternalNode parent)
    {
        return new RightAngleBracket(new EditableBuffer(Value));
    }
}