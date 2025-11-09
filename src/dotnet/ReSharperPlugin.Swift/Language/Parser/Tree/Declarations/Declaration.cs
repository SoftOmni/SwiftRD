using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Statements;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations;

public abstract class Declaration : StatementInternalNode
{
    protected Declaration(IEditableBuffer buffer, List<ISwiftNode> children) : base(buffer, children)
    { }

    protected Declaration(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) : base(buffer, children)
    { }

    protected Declaration(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) : base(parent, buffer, nodes)
    { }

    protected Declaration(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) : base(parent, buffer, nodes)
    { }
}