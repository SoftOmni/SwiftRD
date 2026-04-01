using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.PrecedenceGroups.Relations;

public class LowerThan : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "lowerThan";
    
    public PrecedenceGroupRelation? PrecedenceGroupRelation { get; internal set; }

    internal LowerThan(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.LowerThan)
    { }

    internal LowerThan(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.LowerThan)
    {
        if (parent is PrecedenceGroupRelation precedenceGroupRelation)
        {
            PrecedenceGroupRelation = precedenceGroupRelation;
        }
    }

    internal LowerThan(PrecedenceGroupRelation parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.LowerThan)
    {
        PrecedenceGroupRelation = parent;
    }

    public string KeywordValue => Keyword;

    public static LowerThan Create()
    {
        return new LowerThan(new EditableBuffer(Keyword));
    }

    public static LowerThan Create(PrecedenceGroupRelation precedenceGroupRelation)
    {
        return new LowerThan(precedenceGroupRelation, new EditableBuffer(Keyword));
    }

    public static LowerThan CreateUnchecked(SwiftInternalNode parent)
    {
        return new LowerThan(parent, new EditableBuffer(Keyword));
    }
}