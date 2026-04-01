using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.MutationModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.GetterSetterBlocks.Blocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.SetterSetterBlocks.Clauses;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.GetterSetterBlocks.Clauses;

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