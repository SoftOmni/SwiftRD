using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.CodeBlocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.MutationModifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.GetterSetterBlocks.RegularBlocks.Clauses;

public class GetterClause : SwiftCompositeNode, IGetterClause
{
    public IAttributeGroup? AttributeGroup { get; }

    public IMutationModifier? MutationModifier { get; }
    
    public Get Get { get; }

    public ICodeBlock CodeBlock { get; }

    internal GetterClause(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IAttributeGroup? attributeGroup, Get get, IMutationModifier? mutationModifier, ICodeBlock codeBlock)
        : base(buffer, children)
    {
        AttributeGroup = attributeGroup;
        Get = get;
        MutationModifier = mutationModifier;
        CodeBlock = codeBlock;
    }

    IReadOnlyAttributeGroup? IReadOnlyGetterClause.AttributeGroup => AttributeGroup;

    IReadOnlyMutationModifier? IReadOnlyGetterClause.MutationModifier => MutationModifier;

    IReadOnlyCodeBlock IReadOnlyGetterClause.CodeBlock => CodeBlock;

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

    public void ChangeCodeBlock(ICodeBlock newCodeBlock)
    {
        throw new NotImplementedException();
    }
}
