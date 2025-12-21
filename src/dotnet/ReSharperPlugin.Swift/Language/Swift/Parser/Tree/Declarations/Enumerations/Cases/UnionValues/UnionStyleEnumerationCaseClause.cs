using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Identifiers;
using ReSharperPlugin.Swift.Language.Parser.Tree.Types.TupleTypes;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Enumerations.Cases.UnionValues;

public class UnionStyleEnumerationCaseClause : SwiftInternalNode
{
    public Identifier? Identifier { get; internal set; }
    
    public TupleType? TupleType { get; internal set; }

    public UnionStyleEnumerationCaseClause(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public UnionStyleEnumerationCaseClause(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public UnionStyleEnumerationCaseClause(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public UnionStyleEnumerationCaseClause(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}