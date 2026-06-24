using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions;

public class FunctionResult : SwiftCompositeNode, IFunctionResult
{
    public IAttributeGroup? AttributeGroup { get; }

    public IType Type { get; }

    internal FunctionResult(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children, 
        IAttributeGroup attributeGroup, IType type)
        : base(buffer, children)
    {
        AttributeGroup = attributeGroup;
        Type = type;
    }

    internal FunctionResult(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children, 
        IType type)
        : base(buffer, children)
    {
        Type = type;
    }

    IReadOnlyAttributeGroup? IReadOnlyFunctionResult.AttributeGroup => AttributeGroup;

    IReadOnlyType IReadOnlyFunctionResult.Type => Type;

    public void SetAttributesGroupTo(IAttributeGroup? attributeGroup)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAttributesGroup()
    {
        throw new System.NotImplementedException();
    }

    public void ChangeType(IType type)
    {
        throw new System.NotImplementedException();
    }
}
