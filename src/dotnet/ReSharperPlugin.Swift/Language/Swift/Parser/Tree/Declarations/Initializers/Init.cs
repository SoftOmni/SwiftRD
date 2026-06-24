using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Initializers;

public class Init : SwiftLeafNode, ISwiftKeywordNode
{
    public const string Keyword = "init";
    
    public Initializer? Initializer { get; internal set; }

    internal Init(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.Init)
    { }

    internal Init(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Init)
    {
        if (parent is Initializer initializer)
        {
            Initializer = initializer;
        }
    }

    internal Init(Initializer parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.Init)
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