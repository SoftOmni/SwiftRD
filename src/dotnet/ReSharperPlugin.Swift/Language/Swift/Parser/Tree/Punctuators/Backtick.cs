using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

public class Backtick : SwiftLeafNode, ISwiftPunctuator
{
    public const string Value = "->";
    
    internal Backtick(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.Backtick)
    { }

    internal Backtick(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, SwiftNodeTypes.Backtick)
    { }


    public string AsString => Value;

    public static Backtick Create()
    {
        return new Backtick(new EditableBuffer(Value));
    }

    public static Backtick Create(SwiftInternalNode parent)
    {
        return new Backtick(new EditableBuffer(Value));
    }
}