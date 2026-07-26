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
using SoftOmni.SwiftRd.Resources.Icons.Language;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.Variables;

public class UnannotatedWillSetDidSetVariable : SwiftCompositeNode, IUnannotatedWillSetDidSetVariable
{
    public IAttributeGroup? Attributes { get; }

    public IDeclarationModifierGroup? DeclarationModifiers { get; }

    public Var Keyword { get; }

    public IIdentifier Name { get; }

    public IInitializer Initializer { get; }

    public IWillSetDidSetBlock WillSetDidSetBlock { get; }

    internal UnannotatedWillSetDidSetVariable(IEditableBuffer buffer,
        IEnumerable<ISwiftNode<SwiftCompositeNode>> children, IAttributeGroup? attributes,
        IDeclarationModifierGroup? declarationModifiers, Var keyword, IIdentifier name, IInitializer initializer,
        IWillSetDidSetBlock willSetDidSetBlock)
        : base(buffer, children)
    {
        Attributes = attributes;
        DeclarationModifiers = declarationModifiers;
        Keyword = keyword;
        Name = name;
        Initializer = initializer;
        WillSetDidSetBlock = willSetDidSetBlock;
    }

    public AnyCompiledIconClass Icon => SwiftIcons.VariableIcon;

    IReadOnlyAttributeGroup? IReadOnlyVariable.Attributes => Attributes;

    IReadOnlyDeclarationModifierGroup? IReadOnlyVariable.DeclarationModifiers => DeclarationModifiers;

    IReadOnlyIdentifier IReadOnlyUnannotatedWillSetVariable.Name => Name;

    IReadOnlyInitializer IReadOnlyUnannotatedWillSetVariable.Initializer => Initializer;

    IReadOnlyWillSetDidSetBlock IReadOnlyUnannotatedWillSetVariable.WillSetDidSetBlock => WillSetDidSetBlock;

    IReadOnlyDeclarationModifierGroup IReadOnlyDeclaration.DefaultAccessLevelModifier()
    {
        throw new System.NotImplementedException();
    }

    IAccessLevelModifier IDeclaration.DefaultAccessLevelModifier()
    {
        throw new System.NotImplementedException();
    }

    public void ChangeAccessLevelModifier(IAccessLevelModifier accessLevelModifier)
    {
        throw new System.NotImplementedException();
    }

    public void SetAttributesTo(IAttributeGroup? attributes)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAttributes()
    {
        throw new System.NotImplementedException();
    }

    public void SetDeclarationModifiers()
    {
        throw new System.NotImplementedException();
    }

    public void RemoveDeclarationModifiers()
    {
        throw new System.NotImplementedException();
    }

    public void ChangeName(IIdentifier newName)
    {
        throw new System.NotImplementedException();
    }

    public void ChangeInitializer(IInitializer newInitializer)
    {
        throw new System.NotImplementedException();
    }

    public void ChangeWillSetDidSetBlock(IWillSetDidSetBlock newWillSetDidSetBlock)
    {
        throw new System.NotImplementedException();
    }
}
