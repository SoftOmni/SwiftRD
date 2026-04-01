using System.Collections.Generic;
using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;
using SoftOmni.SwiftRd.Language.Semantics.Type;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.ControlTransferStatements.CompositeStatements.Throws;

public class ThrowStatement : ControlTransferStatementInternalNode
{
    public Function? Function { get; private set; }
    
    public Expression? Expression { get; private set; }

    public ThrowStatement(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    {
    }

    public ThrowStatement(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    {
    }

    public ThrowStatement(IEditableBuffer buffer, SwiftInternalNode parent, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    {
    }

    public ThrowStatement(IEditableBuffer buffer, SwiftInternalNode parent, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    {
    }

    public bool HasFunction => Function is not null;

    public bool HasNoFunctionAttached => Function is null;

    public bool HasExpression => Expression is not null;

    public bool HasNoExpression => Expression is null; // TODO: Add type API
}