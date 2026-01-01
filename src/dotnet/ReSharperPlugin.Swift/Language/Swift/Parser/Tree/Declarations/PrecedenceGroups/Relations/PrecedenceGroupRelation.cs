using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.PrecedenceGroups.Relations;

public class PrecedenceGroupRelation : PrecedenceGroupAttribute
{
    public HigherThan? HigherThan { get; internal set; }
    
    public LowerThan? LowerThan { get; internal set; }

    public PrecedenceGroupNameGroup? PrecedenceGroupNameGroup { get; internal set; }
    
    public PrecedenceGroupRelation(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public PrecedenceGroupRelation(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public PrecedenceGroupRelation(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public PrecedenceGroupRelation(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}