using System;
using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;
using SoftOmni.SwiftRd.Language.Swift.Semantics.PrimitiveLiterals;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.NilLiterals;

public class NilLiteral : Literal<object?>, INilLiteral
{
    public const string Keyword = "nil";
    
    private readonly IPrimitiveLiteralTypeResolutionContext _primitiveLiteralTypeResolutionContext;

    public NilLiteral(IPrimitiveLiteralTypeResolutionContext primitiveLiteralTypeResolutionContext1, IPrimitiveLiteralTypeResolutionContext? primitiveLiteralTypeResolutionContext = null)
        : this(new EditableBuffer("nil"), primitiveLiteralTypeResolutionContext1)
    {
        _primitiveLiteralTypeResolutionContext =
            primitiveLiteralTypeResolutionContext ?? new PrimitiveLiteralTypeResolutionContext();
    }

    public NilLiteral(IEditableBuffer underlyingBuffer, IPrimitiveLiteralTypeResolutionContext? primitiveLiteralTypeResolutionContext = null)
        : base(underlyingBuffer, null)
    {
        _primitiveLiteralTypeResolutionContext = primitiveLiteralTypeResolutionContext ?? new PrimitiveLiteralTypeResolutionContext();
    }

    public override NodeType NodeType => SwiftNodeTypes.Nil;

    public override IType ReturnType => _primitiveLiteralTypeResolutionContext.DefaultNilLiteralType.Type;

    public override object? GetValueCopy()
    {
        return null;
    }

    public override void SetValue(object? newValue)
    {
        if (newValue is not null)
        {
            throw new NotNullValueException(newValue);
        }
    }

    public class NotNullValueException : ArgumentException
    {
        internal NotNullValueException(object? newValue)
            : base(GenerateMessage(newValue))
        { }

        private static string GenerateMessage(object? newValue)
        {
            return $"The C# value of a nil literal must be null but the newValue was not null ({newValue}).";
        }
    }

    protected override IReadOnlyPrimitiveLiteralTypeResolutionContext ProvidePrimitiveLiteralTypeResolutionContext()
    {
        return PrimitiveLiteralTypeResolutionContext;
    }
}