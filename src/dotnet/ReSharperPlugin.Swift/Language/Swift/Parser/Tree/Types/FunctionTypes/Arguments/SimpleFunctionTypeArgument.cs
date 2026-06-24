using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses.ParameterModifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.FunctionTypes.Arguments;

public class SimpleFunctionTypeArgument : SwiftCompositeNode, ISimpleFunctionTypeArgument
{
    public IAttributeGroup? AttributeGroup { get; }

    public IParameterModifier? ParameterModifier { get; }

    public IType Type { get; }

    internal SimpleFunctionTypeArgument(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IAttributeGroup? attributeGroup, IParameterModifier? parameterModifier, IType type)
        : base(buffer, children)
    {
        AttributeGroup = attributeGroup;
        ParameterModifier = parameterModifier;
        Type = type;
    }

    IReadOnlyAttributeGroup? IReadOnlyFunctionTypeArgument.AttributeGroup => AttributeGroup;

    IReadOnlyParameterModifier? IReadOnlyFunctionTypeArgument.ParameterModifier => ParameterModifier;

    IReadOnlyType IReadOnlySimpleFunctionTypeArgument.Type => Type;
    
    public void ChangeType(IType newType)
    {
        int oldTypeIndex = Type.ParentIndex;
        Type.DetachFromParent();

        AttachChildForcibly(oldTypeIndex, newType);
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
