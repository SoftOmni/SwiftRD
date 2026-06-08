using System;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Semantics.Type.BuiltinTypes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals;

public abstract class BooleanLiteral : Literal<Bool, Boolean>, IBooleanLiteral
{
    protected BooleanLiteral(IEditableBuffer buffer, bool value)
        : base(buffer, Bool.Instance, value)
    { }

    protected BooleanLiteral(IEditableBuffer underlyingBuffer, SwiftCompositeNode parentNode, int parentIndex, int parentTextIndex, bool value)
        : base(underlyingBuffer, parentNode, parentIndex, parentTextIndex, Bool.Instance, value)
    { }

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
}