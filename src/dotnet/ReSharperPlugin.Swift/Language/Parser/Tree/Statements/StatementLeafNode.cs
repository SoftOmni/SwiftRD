using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Statements;

public abstract class StatementLeafNode : SwiftLeafNode, IStatement
{
    public Semicolon? Semicolon { get; internal set; }
    
    protected StatementLeafNode(IEditableBuffer buffer, NodeType nodeType) 
        : base(buffer, nodeType)
    { }

    protected StatementLeafNode(ISwiftNode parent, IEditableBuffer buffer, NodeType nodeType) 
        : base(parent, buffer, nodeType)
    { }

    public virtual bool CanHaveMultipleOnOneLineSeparatedBySemicolons { get; } = true;
}