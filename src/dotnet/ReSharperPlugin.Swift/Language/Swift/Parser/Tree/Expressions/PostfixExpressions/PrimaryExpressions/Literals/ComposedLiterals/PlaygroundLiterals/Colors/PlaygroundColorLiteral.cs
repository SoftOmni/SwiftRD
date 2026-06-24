using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;
using SoftOmni.SwiftRd.Language.Swift.Semantics.PrimitiveLiterals;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.
    ComposedLiterals.PlaygroundLiterals.Colors;

public class PlaygroundColorLiteral : SwiftCompositeNode, IPlaygroundColorLiteral
{
    public ReservedColorLiteralKeyword ColorLiteralKeyword { get; }

    public IReadOnlyFunctionCallExpression CallExpression { get; }

    public LeftParenthesis LeftArgumentsParenthesis { get; }

    public IReadOnlyIdentifier RedArgumentLabel { get; }

    public Colon RedArgumentLabelValueSeparator { get; }

    public IExpression RedValue { get; }

    public Comma RedGreenArgumentSeparator { get; }

    public IReadOnlyIdentifier GreenArgumentLabel { get; }

    public Colon GreenArgumentLabelValueSeparator { get; }

    public IExpression GreenValue { get; }

    public Comma GreenBlueArgumentSeparator { get; }

    public IReadOnlyIdentifier BlueArgumentLabel { get; }

    public Colon BlueArgumentLabelValueSeparator { get; }

    public IExpression BlueValue { get; }

    public Comma BlueAlphaArgumentSeparator { get; }

    public IReadOnlyIdentifier AlphaArgumentLabel { get; }

    public Colon AlphaArgumentLabelValueSeparator { get; }

    public RightParenthesis RightArgumentsParenthesis { get; }

    public IExpression AlphaValue { get; }

    internal PlaygroundColorLiteral(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        ReservedColorLiteralKeyword reservedColorLiteralKeyword, IReadOnlyFunctionCallExpression callExpression,
        LeftParenthesis leftArgumentsParenthesis,
        IReadOnlyIdentifier redArgumentLabel, Colon redArgumentLabelValueSeparator, IExpression redValue,
        Comma redGreenArgumentSeparator,
        IReadOnlyIdentifier greenArgumentLabel, Colon greenArgumentLabelValueSeparator, IExpression greenValue,
        Comma greenBlueArgumentSeparator,
        IReadOnlyIdentifier blueArgumentLabel, Colon blueArgumentLabelValueSeparator, IExpression blueValue,
        Comma blueAlphaArgumentSeparator,
        IReadOnlyIdentifier alphaArgumentLabel, Colon alphaArgumentLabelValueSeparator, IExpression alphaValue,
        RightParenthesis rightArgumentsParenthesis,
        IPrimitiveLiteralTypeResolutionContext primitiveLiteralTypeResolutionContext
    )
        : base(buffer, children)
    {
        ColorLiteralKeyword = reservedColorLiteralKeyword;
        CallExpression = callExpression;

        LeftArgumentsParenthesis = leftArgumentsParenthesis;
        RightArgumentsParenthesis = rightArgumentsParenthesis;
        
        RedArgumentLabel = redArgumentLabel;
        RedArgumentLabelValueSeparator = redArgumentLabelValueSeparator;
        RedValue = redValue;
        RedGreenArgumentSeparator = redGreenArgumentSeparator;
        
        GreenArgumentLabel = greenArgumentLabel;
        GreenArgumentLabelValueSeparator = greenArgumentLabelValueSeparator;
        GreenValue = greenValue;
        GreenBlueArgumentSeparator = greenBlueArgumentSeparator;

        BlueArgumentLabel = blueArgumentLabel;
        BlueArgumentLabelValueSeparator = blueArgumentLabelValueSeparator;
        BlueValue = blueValue;
        BlueAlphaArgumentSeparator = blueAlphaArgumentSeparator;

        AlphaArgumentLabel = alphaArgumentLabel;
        AlphaArgumentLabelValueSeparator = alphaArgumentLabelValueSeparator;
        AlphaValue = alphaValue;

        PrimitiveLiteralTypeResolutionContext = primitiveLiteralTypeResolutionContext;
        ReturnType = UnknownType.Instance;
    }

    IReadOnlyExpression IReadOnlyPlaygroundColorLiteral.RedValue => RedValue;

    IReadOnlyExpression IReadOnlyPlaygroundColorLiteral.GreenValue => GreenValue;

    IReadOnlyExpression IReadOnlyPlaygroundColorLiteral.BlueValue => BlueValue;

    IReadOnlyExpression IReadOnlyPlaygroundColorLiteral.AlphaValue => AlphaValue;

    public (IExpression red, IExpression green, IExpression blue, IExpression alpha) Value => (RedValue, GreenValue, BlueValue, AlphaValue);

    (IReadOnlyExpression red, IReadOnlyExpression green, IReadOnlyExpression blue, IReadOnlyExpression alpha)
        IReadOnlyLiteral<(IReadOnlyExpression red, IReadOnlyExpression green, IReadOnlyExpression blue, IReadOnlyExpression alpha)>.Value => Value;

    public IReadOnlyPrimitiveLiteralTypeResolutionContext PrimitiveLiteralTypeResolutionContext { get; }

    public IType ReturnType { get; }

    IReadOnlyType IReadOnlyBaseExpression.ReturnType => ReturnType;

    (IReadOnlyExpression red, IReadOnlyExpression green, IReadOnlyExpression blue, IReadOnlyExpression alpha) 
        IReadOnlyLiteral<(IReadOnlyExpression red, IReadOnlyExpression green, IReadOnlyExpression blue, IReadOnlyExpression alpha)>
        .GetValueCopy()
    {
        throw new System.NotImplementedException();
    }

    (IExpression red, IExpression green, IExpression blue, IExpression alpha)
        IReadOnlyLiteral<(IExpression red, IExpression green, IExpression blue, IExpression alpha)>.GetValueCopy()
    {
        throw new System.NotImplementedException();
    }

    (IExpression red, IExpression green, IExpression blue, IExpression alpha) IPlaygroundColorLiteral.GetValueCopy()
    {
        throw new System.NotImplementedException();
    }

    void ILiteral<(IExpression red, IExpression green, IExpression blue, IExpression alpha)>.SetValue(
        (IExpression red, IExpression green, IExpression blue, IExpression alpha) newValue)
    {
        throw new System.NotImplementedException();
    }

    void IPlaygroundColorLiteral.SetValue((IExpression red, IExpression green, IExpression blue, IExpression alpha) newValue)
    {
        throw new System.NotImplementedException();
    }

    public IExpression ChangeRedExpression()
    {
        throw new System.NotImplementedException();
    }

    public IExpression ChangeGreenExpression()
    {
        throw new System.NotImplementedException();
    }

    public IExpression ChangeBlueExpression()
    {
        throw new System.NotImplementedException();
    }

    public IExpression ChangeAlphaExpression()
    {
        throw new System.NotImplementedException();
    }

    public void ChangeLiteralContext(IReadOnlyPrimitiveLiteralTypeResolutionContext newContext)
    {
        throw new System.NotImplementedException();
    }
}