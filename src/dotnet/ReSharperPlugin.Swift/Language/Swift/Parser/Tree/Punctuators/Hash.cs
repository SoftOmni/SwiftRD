using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

public class Hash : SwiftLeafNode, ISwiftPunctuator
{
    public const string Value = "#";
    
    internal Hash(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.Hash)
    { }

    internal Hash(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, SwiftNodeTypes.Hash)
    { }


    public string AsString => Value;

    public static Hash Create()
    {
        return new Hash(new EditableBuffer(Value));
    }

    public static Hash Create(SwiftInternalNode parent)
    {
        return new Hash(new EditableBuffer(Value));
    }
}