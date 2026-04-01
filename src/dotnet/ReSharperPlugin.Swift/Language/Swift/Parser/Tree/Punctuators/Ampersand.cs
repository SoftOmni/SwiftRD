using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

public class Ampersand : SwiftLeafNode, ISwiftPunctuator
{
    public const string Value = "&";
    
    internal Ampersand(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.Ampersand)
    { }

    internal Ampersand(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, SwiftNodeTypes.Ampersand)
    { }


    public string AsString => Value;

    public static Ampersand Create()
    {
        return new Ampersand(new EditableBuffer(Value));
    }

    public static Ampersand Create(SwiftInternalNode parent)
    {
        return new Ampersand(new EditableBuffer(Value));
    }
}