using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.Signatures;

public class FunctionResult : SwiftCompositeNode, IFunctionResult
{
    public Arrow ResultPresenter { get; }

    public IAttributeGroup? Attributes { get; }

    public IType Type { get; }

    internal FunctionResult(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        Arrow resultPresenter, IType type)
        : base(buffer, children)
    {
        ResultPresenter = resultPresenter;
        Type = type;
    }

    internal FunctionResult(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        Arrow resultPresenter, IAttributeGroup? attributes, IType type)
        : base(buffer, children)
    {
        ResultPresenter = resultPresenter;
        Attributes = attributes;
        Type = type;
    }

    IReadOnlyAttributeGroup? IReadOnlyFunctionResult.Attributes => Attributes;

    IReadOnlyType IReadOnlyFunctionResult.Type => Type;

    public void SetAttributesGroupTo(IAttributeGroup? attributeGroup)
    {
        throw new NotImplementedException();
    }

    public void RemoveAttributesGroup()
    {
        throw new NotImplementedException();
    }

    public void ChangeType(IType type)
    {
        throw new NotImplementedException();
    }
}
