using System;
using System.Collections.Generic;
using JetBrains.Application.UI.Icons.CompiledIcons;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers;
using SoftOmni.SwiftRd.Resources.Icons.Language;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Constants;

public class ConstantDeclaration : SwiftCompositeNode, IConstantDeclaration
{
    public IAttributeGroup? AttributeGroup { get; }

    public Let Keyword { get; }

    public IDeclarationModifierGroup? DeclarationModifierGroup { get; }

    public IPatternInitializerList PatternInitializerList { get; }

    internal ConstantDeclaration(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IAttributeGroup? attributeGroup, Let keyword, 
        IDeclarationModifierGroup? declarationModifierGroup,
        IPatternInitializerList patternInitializerList)
        : base(buffer, children)
    {
        AttributeGroup = attributeGroup;
        Keyword = keyword;
        DeclarationModifierGroup = declarationModifierGroup;
        PatternInitializerList = patternInitializerList;
    }

    public AnyCompiledIconClass Icon => SwiftIcons.ConstantIcon; // TODO: reconsider this API

    IReadOnlyAttributeGroup? IReadOnlyConstantDeclaration.AttributeGroup => AttributeGroup;

    IReadOnlyDeclarationModifierGroup? IReadOnlyConstantDeclaration.DeclarationModifierGroup => DeclarationModifierGroup;

    IReadOnlyPatternInitializerList IReadOnlyConstantDeclaration.PatternInitializerList => PatternInitializerList;

    public void ChangeAccessLevelModifier(IAccessLevelModifier accessLevelModifier)
    {
        throw new NotImplementedException();
    }

    public void SetAttributeGroupTo(IAttributeGroup? attributeGroup)
    {
        throw new NotImplementedException();
    }

    public void RemoveAttributeGroup()
    {
        throw new NotImplementedException();
    }

    public void SetDeclarationModifier(IDeclarationModifierGroup? declarationModifier)
    {
        throw new NotImplementedException();
    }

    public void RemoveDeclarationModifier()
    {
        throw new NotImplementedException();
    }

    public void ChangePatternInitializerList(IPatternInitializerList newPatternInitializerList)
    {
        throw new NotImplementedException();
    }
}
