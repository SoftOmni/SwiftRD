using System;
using System.Collections.Generic;
using JetBrains.Application.UI.Icons.CompiledIcons;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.TopLevel;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ParameterClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;
using SoftOmni.SwiftRd.Resources.Icons.Language;
using Internal = SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers.Leaves.Internal;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.TypeAliases;

public class TypeAlias : Declaration<IType>, ITypeAlias, INamedDeclaration<TypeAlias, IType>
{
    public AttributeGroup? Attributes { get; internal set; }

    public IAccessLevelModifier? AccessLevelModifier { get; internal set; }

    public TypeAliasKeyword Keyword { get; }
    
    public Identifier? Name { get; internal set; }
    
    public GenericParameterClause? GenericParameterClause { get; internal set; }

    public Equal Equal { get; }

    public IType Type { get; }

    internal TypeAlias(IEditableBuffer buffer, List<ISwiftNode<SwiftCompositeNode>> children, AttributeGroup? attributes, IAccessLevelModifier? accessLevelModifier, TypeAliasKeyword keyword,
        Identifier name, Equal equal, IType type)
        : base(buffer, children)
    {
        Attributes = attributes;
        AccessLevelModifier = accessLevelModifier;
        ActiveAccessLevelModifier = accessLevelModifier ?? DefaultAccessLevelModifier();

        ChildNodes.Add(keyword);
        Keyword = keyword;

        Name = name;
        Equal = equal;
        Type = type;
    }

    public bool HasAttributes => Attributes is not null;

    public bool IsAttributeless => Attributes is null;

    public bool AccessLevelModifierSpecified => AccessLevelModifier is not null;

    public bool IsDefaultAccessLevelModifier => AccessLevelModifier is null;

    public IAccessLevelModifier ActiveAccessLevelModifier { get; }

    public IAccessLevelModifier DefaultAccessLevelModifier()
    {
        return Internal.Create();
    }

    public override AnyCompiledIconClass Icon => SwiftIcons.TypeAliasWithAccessModifier(AccessLevelModifier);

    public void Rename(IType usage, string newName)
    {
        throw new NotImplementedException();
    }

    public void RenameAllUsages(string newName)
    {
        foreach (KeyValuePair<IType, TopLevelDeclaration> usagePair in Usages)
        {
            IType usage = usagePair.Key;
            Rename(usage, newName);
        }
    }
}