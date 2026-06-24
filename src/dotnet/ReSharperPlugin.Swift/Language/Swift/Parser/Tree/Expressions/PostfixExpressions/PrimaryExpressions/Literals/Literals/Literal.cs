using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;
using SoftOmni.SwiftRd.Language.Swift.Semantics.PrimitiveLiterals;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals;

public abstract class Literal<TCSharpValueType> : SwiftCompositeNode, ILiteral<TCSharpValueType>
{
    protected Literal(IEditableBuffer underlyingBuffer, TCSharpValueType value)
        : base(underlyingBuffer)
    {
        Value = value;
    }

    protected Literal(SwiftCompositeNode parent, int index, int textIndex, int lengthInParent, TCSharpValueType value,
        IEnumerable<ISwiftNode<SwiftCompositeNode>>? children = null)
        : base(parent, index, textIndex, lengthInParent, children)
    {
        Value = value;
    }

    public TCSharpValueType Value { get; protected set; }

    public int ValueStart { get; protected set; } = 0;

    public abstract IType ReturnType { get; }

    IReadOnlyType IReadOnlyBaseExpression.ReturnType => ReturnType;

    public abstract TCSharpValueType GetValueCopy();

    public IReadOnlyPrimitiveLiteralTypeResolutionContext PrimitiveLiteralTypeResolutionContext =>
        ProvidePrimitiveLiteralTypeResolutionContext();
    
    public abstract void SetValue(TCSharpValueType newValue);

    protected abstract IReadOnlyPrimitiveLiteralTypeResolutionContext ProvidePrimitiveLiteralTypeResolutionContext();

    public void ChangeLiteralContext(IReadOnlyPrimitiveLiteralTypeResolutionContext newContext)
    {
        throw new NotImplementedException();
    }
}
