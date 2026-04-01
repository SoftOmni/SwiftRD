using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements;

public abstract class StatementLeafNode : SwiftLeafNode, IStatement
{
    public Semicolon? Semicolon { get; internal set; }
    
    protected StatementLeafNode(IEditableBuffer buffer, NodeType nodeType) 
        : base(buffer, nodeType)
    { }

    protected StatementLeafNode(SwiftInternalNode parent, IEditableBuffer buffer, NodeType nodeType) 
        : base(parent, buffer, nodeType)
    { }

    public virtual bool CanHaveMultipleOnOneLineSeparatedBySemicolons { get; } = true;
}