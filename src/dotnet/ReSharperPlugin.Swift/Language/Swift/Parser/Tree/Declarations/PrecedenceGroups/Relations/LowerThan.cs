using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.PrecedenceGroups.Relations;

public class LowerThan : SwiftLeafNode, ISwiftKeyword
{
    public const string Keyword = "lowerThan";
    
    public PrecedenceGroupRelation? PrecedenceGroupRelation { get; internal set; }

    internal LowerThan(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.LowerThan)
    { }

    internal LowerThan(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.LowerThan)
    {
        if (parent is PrecedenceGroupRelation precedenceGroupRelation)
        {
            PrecedenceGroupRelation = precedenceGroupRelation;
        }
    }

    internal LowerThan(PrecedenceGroupRelation parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.LowerThan)
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