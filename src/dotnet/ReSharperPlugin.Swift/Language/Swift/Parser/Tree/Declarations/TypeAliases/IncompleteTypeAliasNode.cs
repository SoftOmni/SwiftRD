using System;
using System.Collections.Generic;
using JetBrains.Application.UI.Icons.CompiledIcons;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.ErrorNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers.Leaves;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.TopLevel;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.TypeAliases;

public class IncompleteTypeAliasNode : SwiftErrorCompositeNode, ITypeAlias
{
    public AttributeGroup? Attributes { get; internal set; }

    public IAccessLevelModifier? AccessLevelModifier { get; internal set; }

    public TypeAliasKeyword? Keyword { get; internal set; }

    public Identifier? Name { get; internal set; }

    public Equal? Equal { get; internal set; }

    public IType? Type { get; internal set; }

    private readonly Dictionary<IType, TopLevelDeclaration> _usages = [];

    internal IncompleteTypeAliasNode(IEditableBuffer buffer, List<ISwiftNode<SwiftCompositeNode>> children, AttributeGroup? attributes, IAccessLevelModifier? accessLevelModifier, TypeAliasKeyword keyword,
        Identifier? name, Equal? equal, IType? type)
        : base(buffer, children, TODO)
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

    public AnyCompiledIconClass Icon { get; }

    public bool HasAttributes => Attributes is not null;

    public bool IsAttributeless => Attributes is null;

    public bool AccessLevelModifierSpecified => AccessLevelModifier is not null;

    public bool IsDefaultAccessLevelModifier => AccessLevelModifier is null;

    public IReadOnlyDictionary<IType, TopLevelDeclaration> Usages => _usages;

    public IAccessLevelModifier ActiveAccessLevelModifier { get; }

    public bool CanBeConvertedIntoCorrectTypeAlias => Keyword is not null && Name is not null && Equal is not null && Type is not null;

    public IAccessLevelModifier DefaultAccessLevelModifier()
    {
        return Internal.Create();
    }

    public void Rename(IType usage, string newName)
    {
        throw new NotImplementedException();
    }

    public void RenameAllUsages(string newName)
    {
        throw new NotImplementedException();
    }

    public bool ConvertIntoTypeAlias()
    {
        throw new NotImplementedException();
    }
}