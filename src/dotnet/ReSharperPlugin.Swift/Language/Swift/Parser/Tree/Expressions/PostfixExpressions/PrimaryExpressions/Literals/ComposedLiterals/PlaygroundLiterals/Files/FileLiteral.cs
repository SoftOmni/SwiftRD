using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;
using SoftOmni.SwiftRd.Language.Swift.Semantics.PrimitiveLiterals;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.ComposedLiterals.PlaygroundLiterals.Files;

public class FileLiteral : SwiftCompositeNode, IFileLiteral
{
    public ReservedFileLiteralKeyword FileLiteralKeyword { get; }
    
    public LeftParenthesis LeftArgumentParenthesis { get; }
    
    public IReadOnlyIdentifier RessourceNameArgumentLabel { get; }
    
    public Colon RessourceNameArgumentLabelValueSeparator { get; }
    
    public IExpression RessourceNameArgumentValue { get; }
    
    public RightParenthesis RightArgumentParenthesis { get; }

    private readonly IPrimitiveLiteralTypeResolutionContext _primitiveLiteralTypeResolutionContext;

    internal FileLiteral(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        ReservedFileLiteralKeyword fileLiteralKeyword,
        LeftParenthesis leftArgumentParenthesis,
        IReadOnlyIdentifier ressourceNameArgumentLabel, Colon ressourceNameArgumentLabelValueSeparator,
        IExpression ressourceNameArgumentValue,
        RightParenthesis rightArgumentParenthesis,
        IPrimitiveLiteralTypeResolutionContext primitiveLiteralTypeResolutionContext)
        : base(buffer, children)
    {
        FileLiteralKeyword = fileLiteralKeyword;
        LeftArgumentParenthesis = leftArgumentParenthesis;

        RessourceNameArgumentLabel = ressourceNameArgumentLabel;
        RessourceNameArgumentLabelValueSeparator = ressourceNameArgumentLabelValueSeparator;
        RessourceNameArgumentValue = ressourceNameArgumentValue;

        RightArgumentParenthesis = rightArgumentParenthesis;
        _primitiveLiteralTypeResolutionContext = primitiveLiteralTypeResolutionContext;
        
        ReturnType = UnknownType.Instance;
    }

    IReadOnlyExpression IReadOnlyFileLiteral.RessourceNameArgumentValue => RessourceNameArgumentValue;

    public IReadOnlyPrimitiveLiteralTypeResolutionContext PrimitiveLiteralTypeResolutionContext
        => _primitiveLiteralTypeResolutionContext;

    public IExpression Value => RessourceNameArgumentValue;

    IReadOnlyExpression IReadOnlyLiteral<IReadOnlyExpression>.Value => Value;

    public IType ReturnType { get; }

    IReadOnlyType IReadOnlyBaseExpression.ReturnType => ReturnType;

    public IExpression GetValueCopy()
    {
        throw new NotImplementedException();
    }

    IReadOnlyExpression IReadOnlyLiteral<IReadOnlyExpression>.GetValueCopy()
    {
        return GetValueCopy();
    }

    public void SetValue(IExpression newValue)
    {
        throw new NotImplementedException();
    }

    public void ChangeRessourceNameArgumentValue(IExpression newExpression)
    {
        throw new NotImplementedException();
    }

    public void ChangeLiteralContext(IReadOnlyPrimitiveLiteralTypeResolutionContext newContext)
    {
        throw new NotImplementedException();
    }
}
