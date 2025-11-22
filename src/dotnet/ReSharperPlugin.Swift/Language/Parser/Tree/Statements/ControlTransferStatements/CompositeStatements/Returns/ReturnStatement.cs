using System.Collections.Generic;
using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Expressions;
using ReSharperPlugin.Swift.Language.Semantics.Type;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Statements.ControlTransferStatements.CompositeStatements.Returns;

public class ReturnStatement : ControlTransferStatementInternalNode
{
    public Return? Return { get; private set; }
    
    public Expression? Expression { get; private set; }

    public ReturnStatement(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public ReturnStatement(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public ReturnStatement(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public ReturnStatement(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public bool IsSimpleReturn => Expression is null;

    public bool ContainsReturnValue => Expression is not null;
}