using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.DeInitializers;

public class DeInit : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "deinit";
    
    public DeInitializer? DeInitializer { get; internal set; }

    internal DeInit(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Deinit)
    { }

    internal DeInit(ISwiftNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Deinit)
    {
        if (parent is DeInitializer deInitializer)
        {
            DeInitializer = deInitializer;
        }
    }

    internal DeInit(DeInitializer parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Deinit)
    {
        DeInitializer = parent;
    }

    public string KeywordValue => Keyword;

    public static DeInit Create()
    {
        return new DeInit(new EditableBuffer(Keyword));
    }

    public static DeInit Create(DeInitializer deInitializer)
    {
        return new DeInit(deInitializer, new EditableBuffer(Keyword));
    }

    public static DeInit CreateUnchecked(ISwiftNode parent)
    {
        return new DeInit(parent, new EditableBuffer(Keyword));
    }
}