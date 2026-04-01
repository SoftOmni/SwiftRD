using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeInitializers;

public class DeInit : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "deinit";
    
    public DeInitializer? DeInitializer { get; internal set; }

    internal DeInit(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.Deinit)
    { }

    internal DeInit(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Deinit)
    {
        if (parent is DeInitializer deInitializer)
        {
            DeInitializer = deInitializer;
        }
    }

    internal DeInit(DeInitializer parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Deinit)
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

    public static DeInit CreateUnchecked(SwiftInternalNode parent)
    {
        return new DeInit(parent, new EditableBuffer(Keyword));
    }
}