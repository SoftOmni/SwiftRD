using System;
using System.Text.RegularExpressions;
using SoftOmni.SwiftRd.Rider.Language.RegularExpressionHarness.Parser.Tree.Base.Implementations.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InterconnectNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;
using SoftOmni.SwiftRd.Language.Swift.Semantics.PrimitiveLiterals;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals;

public class RegularExpressionLiteral : SwiftRegularExpressionInterconnectNode, ILiteral<Regex>
{
    private readonly IPrimitiveLiteralTypeResolutionContext _primitiveLiteralTypeResolutionContext;

    internal RegularExpressionLiteral(RegularExpressionCompositeNode equivalentNode,
        IPrimitiveLiteralTypeResolutionContext primitiveLiteralTypeResolutionContext)
        : base(equivalentNode)
    {
        _primitiveLiteralTypeResolutionContext = primitiveLiteralTypeResolutionContext;
        Value = CalculateCSharpValue();
    }

    internal RegularExpressionLiteral(RegularExpressionCompositeNode equivalentNode, SwiftCompositeNode parent,
        int index, IPrimitiveLiteralTypeResolutionContext primitiveLiteralTypeResolutionContext)
        : base(equivalentNode, parent, index)
    {
        _primitiveLiteralTypeResolutionContext = primitiveLiteralTypeResolutionContext;
        Value = CalculateCSharpValue();
    }

    internal RegularExpressionLiteral(RegularExpressionCompositeNode equivalentNode, SwiftCompositeNode parent,
        int index, int textIndex, int lengthInParent,
        IPrimitiveLiteralTypeResolutionContext primitiveLiteralTypeResolutionContext)
        : base(equivalentNode, parent, index, textIndex, lengthInParent)
    {
        _primitiveLiteralTypeResolutionContext = primitiveLiteralTypeResolutionContext;
        Value = CalculateCSharpValue();
    }

    public IReadOnlyPrimitiveLiteralTypeResolutionContext PrimitiveLiteralTypeResolutionContext
        => _primitiveLiteralTypeResolutionContext;
    
    public Regex Value { get; private set; }

    public IType ReturnType => _primitiveLiteralTypeResolutionContext.DefaultRegularExpressionLiteralType.Type;

    IReadOnlyType IReadOnlyBaseExpression.ReturnType => ReturnType;

    public Regex GetValueCopy()
    {
        throw new NotImplementedException();
    }

    public void SetValue(Regex newValue)
    {
        throw new NotImplementedException();
    }

    public void ChangeLiteralContext(IReadOnlyPrimitiveLiteralTypeResolutionContext newContext)
    {
        throw new NotImplementedException();
    }

    private Regex CalculateCSharpValue()
    {
        throw new NotImplementedException();
    }
}
