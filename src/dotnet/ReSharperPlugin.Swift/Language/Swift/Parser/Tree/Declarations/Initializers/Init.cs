using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Initializers;

public class Init : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "init";
    
    public Initializer? Initializer { get; internal set; }

    internal Init(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Init)
    { }

    internal Init(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Init)
    {
        if (parent is Initializer initializer)
        {
            Initializer = initializer;
        }
    }

    internal Init(Initializer parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Init)
    {
        Initializer = parent;
    }

    public string KeywordValue => Keyword;

    public static Init Create()
    {
        return new Init(new EditableBuffer(Keyword));
    }

    public static Init Create(Initializer initializer)
    {
        return new Init(initializer, new EditableBuffer(Keyword));
    }

    public static Init CreateUnchecked(SwiftInternalNode parent)
    {
        return new Init(parent, new EditableBuffer(Keyword));
    }
}