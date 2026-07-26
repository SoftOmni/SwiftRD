using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.CodeBlocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.MutationModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.GetterSetterBlocks.RegularBlocks.Clauses;

public class SetterClause : SwiftCompositeNode, ISetterClause
{
    public IAttributeGroup? AttributeGroup { get; }

    public IMutationModifier? MutationModifier { get; }
    
    public Set Set { get; }

    public LeftParenthesis? SetterNameStart { get; }
    
    public IIdentifier? SetterName { get; }
    
    public RightParenthesis? SetterNameEnd { get; }

    public ICodeBlock CodeBlock { get; }

    internal SetterClause(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IAttributeGroup? attributeGroup, Set set, IMutationModifier? mutationModifier, 
        LeftParenthesis? setterNameStart, IIdentifier? setterName, 
        RightParenthesis? setterNameEnd, ICodeBlock codeBlock)
        : base(buffer, children)
    {
        AttributeGroup = attributeGroup;
        Set = set;
        MutationModifier = mutationModifier;
        CodeBlock = codeBlock;
        SetterNameStart = setterNameStart;
        SetterName = setterName;
        SetterNameEnd = setterNameEnd;
    }

    IReadOnlyAttributeGroup? IReadOnlySetterClause.AttributeGroup => AttributeGroup;

    IReadOnlyMutationModifier? IReadOnlySetterClause.MutationModifier => MutationModifier;

    IReadOnlyCodeBlock IReadOnlySetterClause.CodeBlock => CodeBlock;

    IReadOnlyIdentifier? IReadOnlySetterClause.SetterName => SetterName;

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

    public void SetSetterNameTo(IIdentifier? setterName)
    {
        throw new NotImplementedException();
    }

    public void RemoveSetterName()
    {
        throw new NotImplementedException();
    }

    public void ChangeCodeBlock(ICodeBlock newCodeBlock)
    {
        throw new NotImplementedException();
    }
}
