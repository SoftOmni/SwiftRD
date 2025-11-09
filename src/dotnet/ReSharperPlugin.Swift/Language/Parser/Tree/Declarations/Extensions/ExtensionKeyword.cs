using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Extensions;

public class ExtensionKeyword : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "extension";
    
    public Extension? Extension { get; internal set; }

    internal ExtensionKeyword(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Extension)
    { }

    internal ExtensionKeyword(ISwiftNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Extension)
    {
        if (parent is Extension extension)
        {
            Extension = extension;
        }
    }

    internal ExtensionKeyword(Extension parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Extension)
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

    public static ExtensionKeyword CreateUnchecked(ISwiftNode parent)
    {
        return new ExtensionKeyword(parent, new EditableBuffer(Keyword));
    }
}