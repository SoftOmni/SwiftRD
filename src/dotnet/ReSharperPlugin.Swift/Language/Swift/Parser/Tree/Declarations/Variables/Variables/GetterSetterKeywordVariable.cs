using System;
using System.Collections.Generic;
using JetBrains.Application.UI.Icons.CompiledIcons;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.GetterSetterBlocks.RegularBlocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeAnnotations;
using SoftOmni.SwiftRd.Resources.Icons.Language;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.Variables;

public class GetterSetterKeywordVariable : SwiftCompositeNode, IGetterSetterKeywordVariable
{
    public IAttributeGroup? Attributes { get; }

    public IDeclarationModifierGroup? DeclarationModifiers { get; }

    public Var Keyword { get; }

    public IIdentifier Name { get; }

    public ITypeAnnotation TypeAnnotation { get; }

    public IGetterSetterKeywordBlock GetterSetterBlock { get; }

    internal GetterSetterKeywordVariable(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IAttributeGroup? attributes, IDeclarationModifierGroup? declarationModifiers, Var keyword, IIdentifier name,
        ITypeAnnotation typeAnnotation, IGetterSetterKeywordBlock getterSetterBlock)
        : base(buffer, children)
    {
        Attributes = attributes;
        DeclarationModifiers = declarationModifiers;
        Keyword = keyword;
        Name = name;
        TypeAnnotation = typeAnnotation;
        GetterSetterBlock = getterSetterBlock;
    }

    internal GetterSetterKeywordVariable(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IAttributeGroup? attributes, Var keyword, IIdentifier name, ITypeAnnotation typeAnnotation, 
        IGetterSetterKeywordBlock getterSetterBlock)
        : base(buffer, children)
    {
        Attributes = attributes;
        Keyword = keyword;
        Name = name;
        TypeAnnotation = typeAnnotation;
        GetterSetterBlock = getterSetterBlock;
    }

    internal GetterSetterKeywordVariable(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IDeclarationModifierGroup? declarationModifiers, Var keyword, IIdentifier name,
        ITypeAnnotation typeAnnotation, IGetterSetterKeywordBlock getterSetterBlock)
        : base(buffer, children)
    {
        DeclarationModifiers = declarationModifiers;
        Keyword = keyword;
        Name = name;
        TypeAnnotation = typeAnnotation;
        GetterSetterBlock = getterSetterBlock;
    }

    internal GetterSetterKeywordVariable(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        Var keyword, IIdentifier name, ITypeAnnotation typeAnnotation, 
        IGetterSetterKeywordBlock getterSetterBlock)
        : base(buffer, children)
    {
        Keyword = keyword;
        Name = name;
        TypeAnnotation = typeAnnotation;
        GetterSetterBlock = getterSetterBlock;
    }

    public AnyCompiledIconClass Icon => SwiftIcons.VariableIcon;

    IReadOnlyAttributeGroup? IReadOnlyVariable.Attributes => Attributes;

    IReadOnlyDeclarationModifierGroup? IReadOnlyVariable.DeclarationModifiers => DeclarationModifiers;

    IReadOnlyIdentifier IReadOnlyGetterSetterKeywordVariable.Name => Name;

    IReadOnlyTypeAnnotation IReadOnlyGetterSetterKeywordVariable.TypeAnnotation => TypeAnnotation;

    IReadOnlyGetterSetterKeywordBlock IReadOnlyGetterSetterKeywordVariable.GetterSetterBlock => GetterSetterBlock;

    public void ChangeAccessLevelModifier(IAccessLevelModifier accessLevelModifier)
    {
        throw new NotImplementedException();
    }

    public void SetAttributesTo(IAttributeGroup? attributes)
    {
        throw new NotImplementedException();
    }

    public void RemoveAttributes()
    {
        throw new NotImplementedException();
    }

    public void SetDeclarationModifiers()
    {
        throw new NotImplementedException();
    }

    public void RemoveDeclarationModifiers()
    {
        throw new NotImplementedException();
    }

    public void ChangeName(IIdentifier newName)
    {
        throw new NotImplementedException();
    }

    public void ChangeTypeAnnotation(ITypeAnnotation newTypeAnnotation)
    {
        throw new NotImplementedException();
    }

    public void ChangeGetterSetterBlock(IGetterSetterKeywordBlock newGetterSetterBlock)
    {
        throw new NotImplementedException();
    }
}
