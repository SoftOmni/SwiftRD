using System.Collections.Generic;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements;

public abstract class CompilerControlStatement : StatementInternalNode
{
    protected CompilerControlStatement(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    protected CompilerControlStatement(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    protected CompilerControlStatement(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    protected CompilerControlStatement(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public override bool CanHaveMultipleOnOneLineSeparatedBySemicolons => false;
}