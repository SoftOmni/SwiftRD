using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Variables.GetterSetterBlocks.Clauses;
using ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Variables.SetterSetterBlocks.Clauses;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Variables.GetterSetterBlocks.Blocks;

public abstract class GetterSetterBlock<TGetterClause, TSetterClause> : SwiftInternalNode
    where TGetterClause : GetterClause where TSetterClause : SetterClause
{
    public Variable? Variable { get; private set; }

    public TGetterClause? GetterClause { private set; get; }

    public TSetterClause? SetterClause { get; private set; }

    public GetterSetterBlock(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public GetterSetterBlock(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public GetterSetterBlock(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public GetterSetterBlock(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}