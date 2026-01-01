using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Attributes;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;
using ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.DeclarationModifiers.MutationModifiers;
using ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Variables.GetterSetterBlocks.Blocks;
using ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Variables.SetterSetterBlocks.Clauses;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Variables.GetterSetterBlocks.Clauses;

public abstract class GetterClause : SwiftInternalNode
{
    public GetterSetterBlock<GetterClause, SetterClause>? GetterSetterBlock { get; protected set; }

    public List<Attribute> Attributes { get; internal set; } = [];
    
    public Get? Get { get; internal set; }

    public MutationModifier? MutationModifier { get; internal set; }

    protected GetterClause(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    protected GetterClause(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    protected GetterClause(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    protected GetterClause(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}