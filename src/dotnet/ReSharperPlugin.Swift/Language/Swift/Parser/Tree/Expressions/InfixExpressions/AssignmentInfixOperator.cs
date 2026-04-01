using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PrefixExpressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.TryOperators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.InfixExpressions;

public class AssignmentInfixOperator : InfixExpression
{
    public Equal? AssignmentOperator { get; internal set; }
    
    public TryOperator? TryOperator { get; internal set; }
    
    public Await? Await { get; internal set; }
    
    public PrefixExpression? PrefixExpression { get; internal set; }
    
    public AssignmentInfixOperator(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public AssignmentInfixOperator(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public AssignmentInfixOperator(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public AssignmentInfixOperator(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}