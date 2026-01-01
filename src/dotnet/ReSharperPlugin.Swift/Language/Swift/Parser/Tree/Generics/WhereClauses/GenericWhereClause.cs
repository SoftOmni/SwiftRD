using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;
using ReSharperPlugin.Swift.Language.Parser.Tree.Generics.GenericWhereClauseClauses;
using ReSharperPlugin.Swift.Rider.Language.Parser.Tree.Generics.WhereClauses;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Generics.WhereClauses;

public class GenericWhereClause : SwiftInternalNode
{
    public Where? Where { get; internal set; }
    
    public RequirementGroup? RequirementGroup { get; internal set; }

    public GenericWhereClause(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public GenericWhereClause(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public GenericWhereClause(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public GenericWhereClause(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}