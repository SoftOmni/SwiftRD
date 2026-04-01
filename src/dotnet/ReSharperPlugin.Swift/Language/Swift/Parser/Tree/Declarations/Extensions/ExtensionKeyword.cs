using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Extensions;

public class ExtensionKeyword : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "extension";
    
    public Extension? Extension { get; internal set; }

    internal ExtensionKeyword(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.Extension)
    { }

    internal ExtensionKeyword(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Extension)
    {
        if (parent is Extension extension)
        {
            Extension = extension;
        }
    }

    internal ExtensionKeyword(Extension parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Extension)
    {
        Extension = parent;
    }

    public string KeywordValue => Keyword;

    public static ExtensionKeyword Create()
    {
        return new ExtensionKeyword(new EditableBuffer(Keyword));
    }

    public static ExtensionKeyword Create(Extension extension)
    {
        return new ExtensionKeyword(extension, new EditableBuffer(Keyword));
    }

    public static ExtensionKeyword CreateUnchecked(SwiftInternalNode parent)
    {
        return new ExtensionKeyword(parent, new EditableBuffer(Keyword));
    }
}