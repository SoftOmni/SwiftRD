using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses.ParameterModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeAnnotations;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.FunctionTypes.Arguments;

public class LabeledFunctionTypeArgument : SwiftCompositeNode, ILabeledFunctionTypeArgument
{
    public IAttributeGroup? AttributeGroup { get; }

    public IParameterModifier? ParameterModifier { get; }

    public IIdentifier Label { get; }

    public ITypeAnnotation TypeAnnotation { get; }

    public LabeledFunctionTypeArgument(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children)
        : base(buffer, children)
    {
        // TODO: Implement me
    }

    IReadOnlyAttributeGroup? IReadOnlyFunctionTypeArgument.AttributeGroup => AttributeGroup;


    IReadOnlyParameterModifier? IReadOnlyFunctionTypeArgument.ParameterModifier => ParameterModifier;


    IReadOnlyIdentifier IReadOnlyLabeledFunctionTypeArgument.Label => Label;

    IReadOnlyTypeAnnotation IReadOnlyLabeledFunctionTypeArgument.TypeAnnotation => TypeAnnotation;

    public void ChangeLabel(IIdentifier identifier)
    {
        throw new System.NotImplementedException();
    }

    public void ChangeTypeAnnotation(ITypeAnnotation typeAnnotation)
    {
        throw new System.NotImplementedException();
    }

    public void SetAttributeGroupTo(IAttributeGroup? attributeGroup)
    {
        throw new System.NotImplementedException();
    }

    public void SetParameterModifierTo(IParameterModifier? parameterModifier)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAttributes()
    {
        throw new System.NotImplementedException();
    }

    public void RemoveParameterModifier()
    {
        throw new System.NotImplementedException();
    }
}
