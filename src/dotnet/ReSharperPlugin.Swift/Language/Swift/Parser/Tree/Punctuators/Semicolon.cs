using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

public class Semicolon : SwiftLeafNode, ISwiftPunctuator
{
    public const string Value = ";";
    
    internal Semicolon(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.Semicolon)
    { }

    internal Semicolon(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, SwiftNodeTypes.Semicolon)
    { }


    public string AsString => Value;

    public static Semicolon Create()
    {
        return new Semicolon(new EditableBuffer(Value));
    }

    public static Semicolon Create(SwiftInternalNode parent)
    {
        return new Semicolon(new EditableBuffer(Value));
    }
}