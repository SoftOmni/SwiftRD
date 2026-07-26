using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses.ParameterModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses;

public class VariadicParameter : SwiftCompositeNode, IVariadicParameter
{
    public IIdentifier? ExternalParameterName { get; }

    public IIdentifier LocalParameterName { get; }

    public Colon TypePresenter { get; }

    public IAttributeGroup? Attributes { get; }

    public IParameterModifier? ParameterModifier { get; }

    public IType Type { get; }

    public Ellipsis Ellipsis { get; }

    internal VariadicParameter(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IIdentifier? externalParameterName, IIdentifier localParameterName, Colon typePresenter,
        IAttributeGroup? attributes, IParameterModifier? parameterModifier, IType type, Ellipsis ellipsis)
        : base(buffer, children)
    {
        ExternalParameterName = externalParameterName;
        LocalParameterName = localParameterName;
        TypePresenter = typePresenter;
        Attributes = attributes;
        ParameterModifier = parameterModifier;
        Type = type;
        Ellipsis = ellipsis;
    }

    IReadOnlyIdentifier? IReadOnlyParameter.ExternalParameterName => ExternalParameterName;

    IReadOnlyIdentifier IReadOnlyParameter.LocalParameterName => LocalParameterName;

    IReadOnlyAttributeGroup? IReadOnlyParameter.Attributes => Attributes;

    IReadOnlyParameterModifier? IReadOnlyParameter.ParameterModifier => ParameterModifier;

    IReadOnlyType IReadOnlyParameter.Type => Type;

    public void SetExternalParameterNameTo(IIdentifier? newExternalParameterName)
    {
        throw new NotImplementedException();
    }

    public void RemoveExternalParameterName()
    {
        throw new NotImplementedException();
    }

    public void ChangeLocalParameterName()
    {
        throw new NotImplementedException();
    }

    public void SetAttributesTo(IAttributeGroup? newAttributes)
    {
        throw new NotImplementedException();
    }

    public void RemoveAttributes()
    {
        throw new NotImplementedException();
    }

    public void SetParameterModifier(IParameterModifier? newParameterModifier)
    {
        throw new NotImplementedException();
    }

    public void RemoveParameterModifier()
    {
        throw new NotImplementedException();
    }

    public void ChangeType(IType newType)
    {
        throw new NotImplementedException();
    }
}
