using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.PrecedenceGroups.Assignment;

public class PrecedenceGroupAssignment : PrecedenceGroupAttribute
{
    public Assignment? Assignment { get; internal set; }
    
    public BooleanLiteral? BooleanLiteral { get; internal set; }
    
    public PrecedenceGroupAssignment(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public PrecedenceGroupAssignment(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public PrecedenceGroupAssignment(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public PrecedenceGroupAssignment(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}