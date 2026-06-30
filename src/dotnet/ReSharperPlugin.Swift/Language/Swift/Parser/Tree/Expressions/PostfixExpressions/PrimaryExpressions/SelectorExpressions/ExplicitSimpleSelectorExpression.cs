using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions.Arguments;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.SelectorExpressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Rider.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.SelectorExpressions;

public class SimpleSelectorExpression : SwiftCompositeNode, ISimpleSelectorExpression
{
    public SelectorKeyword SelectorKeyword { get; }
    
    public LeftParenthesis ArgumentsStart { get; }

    public IExpression MainExpressionArgumentValue { get; }

    public RightParenthesis ArgumentsEnd { get; }
    
    public IFunctionCallArgumentList Arguments { get; }

    internal SimpleSelectorExpression(IEditableBuffer buffer,
        IEnumerable<ISwiftNode<SwiftCompositeNode>> children, SelectorKeyword selectorKeyword,
        LeftParenthesis argumentsStart,
        IExpression mainExpressionArgumentValue, RightParenthesis argumentsEnd,
        IFunctionCallArgumentList arguments)
        : base(buffer, children)
    {
        SelectorKeyword = selectorKeyword;
        ArgumentsStart = argumentsStart;
        MainExpressionArgumentValue = mainExpressionArgumentValue;
        ArgumentsEnd = argumentsEnd;
        Arguments = arguments;
        
        ReturnType = UnknownType.Instance;
    }
    
    IReadOnlyFunctionCallArgumentList IReadOnlySelectorExpression.Arguments => Arguments;

    IReadOnlyExpression IReadOnlySimpleSelectorExpression.MainExpressionArgumentValue => MainExpressionArgumentValue;

    public IType ReturnType { get; }

    IReadOnlyType IReadOnlyBaseExpression.ReturnType => ReturnType;

    public void ChangeMainExpressionArgumentValue()
    {
        throw new NotImplementedException();
    }
}