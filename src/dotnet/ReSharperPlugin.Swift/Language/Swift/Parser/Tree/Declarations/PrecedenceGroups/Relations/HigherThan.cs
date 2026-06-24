using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.PrecedenceGroups.Relations;

public class HigherThan : SwiftLeafNode, ISwiftKeywordNode
{
    public const string Keyword = "higherThan";
    
    public PrecedenceGroupRelation? PrecedenceGroupRelation { get; internal set; }

    internal HigherThan(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.HigherThan)
    { }

    internal HigherThan(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.HigherThan)
    {
        if (parent is PrecedenceGroupRelation precedenceGroupRelation)
        {
            PrecedenceGroupRelation = precedenceGroupRelation;
        }
    }

    internal HigherThan(PrecedenceGroupRelation parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.HigherThan)
    {
        PrecedenceGroupRelation = parent;
    }

    public string KeywordValue => Keyword;

    public static HigherThan Create()
    {
        return new HigherThan(new EditableBuffer(Keyword));
    }

    public static HigherThan Create(PrecedenceGroupRelation precedenceGroupRelation)
    {
        return new HigherThan(precedenceGroupRelation, new EditableBuffer(Keyword));
    }

    public static HigherThan CreateUnchecked(SwiftInternalNode parent)
    {
        return new HigherThan(parent, new EditableBuffer(Keyword));
    }
}