using System;
using System.Collections.Generic;
using JetBrains.Application.UI.Icons.CompiledIcons;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Constants;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.WillSetDidSetBlocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeAnnotations;
using SoftOmni.SwiftRd.Resources.Icons.Language;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.Variables;

public class AnnotatedWillSetDidSetVariable : SwiftCompositeNode, IAnnotatedWillSetDidSetVariable
{
    public IAttributeGroup? Attributes { get; }

    public IDeclarationModifierGroup? DeclarationModifiers { get; }

    public Var Keyword { get; }

    public IIdentifier Name { get; }

    public ITypeAnnotation TypeAnnotation { get; }

    public IInitializer? Initializer { get; }

    public IWillSetDidSetBlock WillSetDidSetBlock { get; }

    internal AnnotatedWillSetDidSetVariable(IEditableBuffer buffer,
        IEnumerable<ISwiftNode<SwiftCompositeNode>> children, IAttributeGroup? attributes,
        IDeclarationModifierGroup? declarationModifiers, Var keyword, IIdentifier name, 
        ITypeAnnotation typeAnnotation, IInitializer initializer, IWillSetDidSetBlock willSetDidSetBlock)
        : base(buffer, children)
    {
        Attributes = attributes;
        DeclarationModifiers = declarationModifiers;
        Keyword = keyword;
        Name = name;
        TypeAnnotation = typeAnnotation;
        Initializer = initializer;
        WillSetDidSetBlock = willSetDidSetBlock;
    }

    internal AnnotatedWillSetDidSetVariable(IEditableBuffer buffer,
        IEnumerable<ISwiftNode<SwiftCompositeNode>> children, IAttributeGroup? attributes,
        IDeclarationModifierGroup? declarationModifiers, Var keyword, IIdentifier name, 
        ITypeAnnotation typeAnnotation, IWillSetDidSetBlock willSetDidSetBlock)
        : base(buffer, children)
    {
        Attributes = attributes;
        DeclarationModifiers = declarationModifiers;
        Keyword = keyword;
        Name = name;
        TypeAnnotation = typeAnnotation;
        WillSetDidSetBlock = willSetDidSetBlock;
    }

    public AnyCompiledIconClass Icon => SwiftIcons.VariableIcon;

    IReadOnlyAttributeGroup? IReadOnlyVariable.Attributes => Attributes;

    IReadOnlyDeclarationModifierGroup? IReadOnlyVariable.DeclarationModifiers => DeclarationModifiers;

    IReadOnlyIdentifier IReadOnlyAnnotatedWillSetVariable.Name => Name;

    IReadOnlyTypeAnnotation IReadOnlyAnnotatedWillSetVariable.TypeAnnotation => TypeAnnotation;

    IReadOnlyInitializer? IReadOnlyAnnotatedWillSetVariable.Initializer => Initializer;

    IReadOnlyWillSetDidSetBlock IReadOnlyAnnotatedWillSetVariable.WillSetDidSetBlock => WillSetDidSetBlock;

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

    public void SetInitializerTo(IInitializer newInitializer)
    {
        throw new NotImplementedException();
    }

    public void RemoveInitializer()
    {
        throw new NotImplementedException();
    }

    public void ChangeWillSetDidSetBlock(IWillSetDidSetBlock newWillSetDidSetBlock)
    {
        throw new NotImplementedException();
    }
}
