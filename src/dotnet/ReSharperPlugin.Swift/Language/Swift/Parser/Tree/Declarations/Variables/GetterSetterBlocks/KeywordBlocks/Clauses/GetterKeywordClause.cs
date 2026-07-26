using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.MutationModifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.GetterSetterBlocks.KeywordBlocks.Clauses;

public class GetterKeywordClause : SwiftCompositeNode, IGetterKeywordClause
{
    public IAttributeGroup? AttributeGroup { get; }

    public IMutationModifier? MutationModifier { get; }
    
    public Get Get { get; }

    internal GetterKeywordClause(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IAttributeGroup? attributeGroup, Get get, IMutationModifier? mutationModifier)
        : base(buffer, children)
    {
        AttributeGroup = attributeGroup;
        Get = get;
        MutationModifier = mutationModifier;
    }

    IReadOnlyAttributeGroup? IReadOnlyGetterKeywordClause.AttributeGroup => AttributeGroup;

    IReadOnlyMutationModifier? IReadOnlyGetterKeywordClause.MutationModifier => MutationModifier;

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
