using System.Collections.Generic;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Statements;

public abstract class StatementInternalNode : SwiftInternalNode, IStatement
{
    public Semicolon? Semicolon { get; internal set; }
    
    protected StatementInternalNode(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }
    
    protected StatementInternalNode(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    protected StatementInternalNode(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    protected StatementInternalNode(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public virtual bool CanHaveMultipleOnOneLineSeparatedBySemicolons => true;
}

