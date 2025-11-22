using System.Collections.Generic;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Statements;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations;

public abstract class Declaration : StatementInternalNode
{
    protected Declaration(IEditableBuffer buffer, List<ISwiftNode> children) : base(buffer, children)
    { }

    protected Declaration(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) : base(buffer, children)
    { }

    protected Declaration(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) : base(parent, buffer, nodes)
    { }

    protected Declaration(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) : base(parent, buffer, nodes)
    { }
}