using System;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Semantics.PrimitiveLiterals;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.
    Literals;

public abstract class BooleanLiteral : Literal<Boolean>, IBooleanLiteral
{
    protected new IPrimitiveLiteralTypeResolutionContext PrimitiveLiteralTypeResolutionContext { get; }

    protected BooleanLiteral(IEditableBuffer buffer, bool value,
        IPrimitiveLiteralTypeResolutionContext primitiveLiteralTypeResolutionContext)
        : base(buffer, value)
    {
        PrimitiveLiteralTypeResolutionContext = primitiveLiteralTypeResolutionContext;
    }

    public override bool GetValueCopy()
    {
        return Value;
    }

    public override void SetValue(bool newValue)
    {
        bool succeeded = newValue switch
        {
            true => TryToMakeTrue(),
            false => TryToMakeFalse()
        };

        if (succeeded)
        {
            return;
        }

        // TODO: Log
    }

    public abstract bool IsTrue();

    public abstract bool IsFalse();

    public bool TryToMakeTrue()
    {
        if (IsTrue())
        {
            return true;
        }

        if (!HasParent())
        {
            return false;
        }

        FalseBooleanLiteral replacementNode = new();
        replacementNode.AttachToParent(GetParent()!, ParentIndex + 1);

        DetachFromParent();
        return true;
    }

    public bool TryToMakeFalse()
    {
        if (IsFalse())
        {
            return true;
        }

        if (!HasParent())
        {
            return false;
        }

        TrueBooleanLiteral replacementNode = new();
        replacementNode.AttachToParent(GetParent()!, ParentIndex + 1);

        DetachFromParent();
        return true;
    }

    public static explicit operator bool(BooleanLiteral booleanLiteral)
    {
        return booleanLiteral.Value;
    }

    protected override IReadOnlyPrimitiveLiteralTypeResolutionContext ProvidePrimitiveLiteralTypeResolutionContext()
    {
        return PrimitiveLiteralTypeResolutionContext;
    }
}
