using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Attributes;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;
using ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.DeclarationModifiers.MutationModifiers;
using ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Variables.GetterSetterBlocks;
using ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Variables.GetterSetterBlocks.Blocks;
using ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Variables.GetterSetterBlocks.Clauses;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Variables.SetterSetterBlocks.Clauses;

public abstract class SetterClause : SwiftInternalNode
{
    public GetterSetterBlock<GetterClause, SetterClause>? SetterSetterBlock { get; private set; }

    public List<Attribute> Attributes { get; internal set; } = [];
    
    public Set? Set { get; internal set; }

    public MutationModifier? MutationModifier { get; internal set; }
    
    public SetterName? SetterName { get; internal set; }

    protected SetterClause(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    protected SetterClause(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    protected SetterClause(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    protected SetterClause(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}