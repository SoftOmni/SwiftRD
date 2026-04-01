using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions.CaptureLists;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions.ClojureParameterLists;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.FunctionTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions;

public class ClosureSignature : SwiftInternalNode
{
    public CaptureList? CaptureList { get; internal set; }
    
    public ClosureParameterClause? ClosureParameterClause { get; internal set; }
    
    public Async? Async { get; internal set; }
    
    public ThrowsClause? ThrowsClause { get; internal set; }
    
    public FunctionResult? FunctionResult { get; internal set; }
    
    public In? In { get; internal set; }

    public ClosureSignature(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public ClosureSignature(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public ClosureSignature(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public ClosureSignature(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}