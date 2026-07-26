using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.MutationModifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.GetterSetterBlocks.KeywordBlocks.Clauses;

public class SetterKeywordClause : SwiftCompositeNode, ISetterKeywordClause
{
    public IAttributeGroup? AttributeGroup { get; }

    public IMutationModifier? MutationModifier { get; }
    
    public Set Set { get; }

    internal SetterKeywordClause(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IAttributeGroup? attributeGroup, Set set, IMutationModifier? mutationModifier)
        : base(buffer, children)
    {
        AttributeGroup = attributeGroup;
        Set = set;
        MutationModifier = mutationModifier;
    }

    IReadOnlyAttributeGroup? IReadOnlySetterKeywordClause.AttributeGroup => AttributeGroup;

    IReadOnlyMutationModifier? IReadOnlySetterKeywordClause.MutationModifier => MutationModifier;

    public void SetAttributeGroupTo(IAttributeGroup? attributeGroup)
    {
        throw new NotImplementedException();
    }

    public void RemoveAttributeGroup()
    {
        throw new NotImplementedException();
    }

    public void SetMutationModifierTo(IMutationModifier? mutationModifier)
    {
        throw new NotImplementedException();
    }

    public void RemoveMutationModifier()
    {
        throw new NotImplementedException();
    }
}
