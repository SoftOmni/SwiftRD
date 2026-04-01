using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.PrecedenceGroups;

public class PrecedenceGroupKeyword : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "precedencegroup";
    
    public PrecedenceGroup? PrecedenceGroup { get; internal set; }

    internal PrecedenceGroupKeyword(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.PrecedenceGroup)
    { }

    internal PrecedenceGroupKeyword(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.PrecedenceGroup)
    {
        if (parent is PrecedenceGroup precedenceGroup)
        {
            PrecedenceGroup = precedenceGroup;
        }
    }

    internal PrecedenceGroupKeyword(PrecedenceGroup parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.PrecedenceGroup)
    {
        PrecedenceGroup = parent;
    }

    public string KeywordValue => Keyword;

    public static PrecedenceGroupKeyword Create()
    {
        return new PrecedenceGroupKeyword(new EditableBuffer(Keyword));
    }

    public static PrecedenceGroupKeyword Create(PrecedenceGroup precedenceGroup)
    {
        return new PrecedenceGroupKeyword(precedenceGroup, new EditableBuffer(Keyword));
    }

    public static PrecedenceGroupKeyword CreateUnchecked(SwiftInternalNode parent)
    {
        return new PrecedenceGroupKeyword(parent, new EditableBuffer(Keyword));
    }
}