using System.Numerics;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.IntegerLiterals.Formatting;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;
using SoftOmni.SwiftRd.Language.Swift.Semantics.PrimitiveLiterals;
using SoftOmni.SwiftRd.Technology;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.IntegerLiterals;

public class SignedIntegerLiteral : SwiftCompositeNode, ISignedIntegerLiteral
{
    public IOperator? Operator { get; private set; }

    public IReadOnlySignedIntegerLiteral.Sign CurrentSign { get; private set; } =
        IReadOnlySignedIntegerLiteral.Sign.Positive;

    public IIntegerLiteral IntegerLiteral { get; }
    
    internal SignedIntegerLiteral(IEditableBuffer buffer, IIntegerLiteral integerLiteral)
        : base(buffer, children: [integerLiteral])
    {
        IntegerLiteral = integerLiteral;
    }
    
    internal SignedIntegerLiteral(IEditableBuffer buffer, IOperator @operator, IIntegerLiteral integerLiteral)
        : base(buffer, children: [@operator, integerLiteral])
    {
        if (@operator.Buffer.Length == 0 && @operator.Buffer[0] == '-')
        {
            CurrentSign = IReadOnlySignedIntegerLiteral.Sign.Negative;
        }
        
        Operator = @operator;
        IntegerLiteral = integerLiteral;
    }

    public BigInteger Value => IntegerLiteral.Value;

    public IReadOnlyIntegerLiteral.Base CurrentBase => IntegerLiteral.CurrentBase;

    public IIntegerLiteralFormatting CurrentFormatting => IntegerLiteral.CurrentFormatting;

    public IIntegerLiteralFormatting.HexadecimalMode? CurrentHexadecimalMode => IntegerLiteral.CurrentHexadecimalMode;

    IReadOnlyOperator? IReadOnlySignedIntegerLiteral.Operator => Operator;

    public IReadOnlyPrimitiveLiteralTypeResolutionContext PrimitiveLiteralTypeResolutionContext =>
        IntegerLiteral.PrimitiveLiteralTypeResolutionContext;

    public IType ReturnType => IntegerLiteral.ReturnType;

    IReadOnlyType IReadOnlyBaseExpression.ReturnType => ReturnType;

    public BigInteger GetValueCopy()
    {
        return IntegerLiteral.GetValueCopy();
    }

    public void SetValue(BigInteger newValue)
    {
        IntegerLiteral.SetValue(newValue);
    }

    public void MakeBinary(IIntegerLiteralFormatting formatting)
    {
        IntegerLiteral.MakeBinary(formatting);
    }

    public void MakeOctal(IIntegerLiteralFormatting formatting)
    {
        IntegerLiteral.MakeOctal(formatting);
    }

    public void MakeDecimal(IIntegerLiteralFormatting formatting)
    {
        IntegerLiteral.MakeDecimal(formatting);
    }

    public void MakeHexadecimal(IIntegerLiteralFormatting formatting)
    {
        IntegerLiteral.MakeHexadecimal(formatting);
    }

    public void ChangeFormatting(IIntegerLiteralFormatting formatting)
    {
        IntegerLiteral.ChangeFormatting(formatting);
    }

    public void MakeUppercaseIfInHex()
    {
        IntegerLiteral.MakeUppercaseIfInHex();
    }

    public void MakeLowercaseIfInHex()
    {
        IntegerLiteral.MakeLowercaseIfInHex();
    }

    public void MakePositive()
    {
        Operator?.DetachFromParent();

        Operator = null;
        CurrentSign = IReadOnlySignedIntegerLiteral.Sign.Positive;
    }

    public void MakeNegative()
    {
        if (CurrentSign is IReadOnlySignedIntegerLiteral.Sign.Negative)
        {
            return;
        }
        
        UnderlyingBuffer.Insert(0, "-");
        SubEditableBuffer subEditableBuffer = new(UnderlyingBuffer, 0, 1);

        Operator = new Operator(subEditableBuffer);
        CurrentSign = IReadOnlySignedIntegerLiteral.Sign.Negative;
    }

    public void ChangeLiteralContext(IReadOnlyPrimitiveLiteralTypeResolutionContext newContext)
    {
        throw new System.NotImplementedException();
    }
}
