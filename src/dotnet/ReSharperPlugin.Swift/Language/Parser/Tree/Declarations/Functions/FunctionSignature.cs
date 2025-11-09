using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Functions.ParameterClauses;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Functions;

public class FunctionSignature : SwiftInternalNode
{
    public Function? Function { get; private set; }

    public ParameterClause? ParameterClause { get; private set; }

    public Async? Async { get; private set; }

    public Rethrows? Rethrows { get; private set; }

    public FunctionResult? FunctionResult { get; private set; }

    public FunctionSignature(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public FunctionSignature(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public FunctionSignature(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public FunctionSignature(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}