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
using SoftOmni.SwiftRd.Resources.Icons.Language;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.Variables;

public class PatternVariable : SwiftCompositeNode, IPatternVariable
{
    public IAttributeGroup? Attributes { get; }

    public IDeclarationModifierGroup? DeclarationModifiers { get; }

    public Var Keyword { get; }

    public IPatternInitializerList PatternInitializerList { get; }

    internal PatternVariable(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IAttributeGroup? attributes, IDeclarationModifierGroup? declarationModifiers, Var keyword,
        IPatternInitializerList patternInitializerList)
        : base(buffer, children)
    {
        Attributes = attributes;
        DeclarationModifiers = declarationModifiers;
        Keyword = keyword;
        PatternInitializerList = patternInitializerList;
    }

    public AnyCompiledIconClass Icon => SwiftIcons.VariableIcon;

    IReadOnlyAttributeGroup? IReadOnlyVariable.Attributes => Attributes;

    IReadOnlyDeclarationModifierGroup? IReadOnlyVariable.DeclarationModifiers => DeclarationModifiers;

    IReadOnlyPatternInitializerList IReadOnlyPatternVariable.PatternInitializerList => PatternInitializerList;

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

    public void ChangePatternInitializerList(IPatternInitializerList newPatternInitializerList)
    {
        throw new NotImplementedException();
    }
}
