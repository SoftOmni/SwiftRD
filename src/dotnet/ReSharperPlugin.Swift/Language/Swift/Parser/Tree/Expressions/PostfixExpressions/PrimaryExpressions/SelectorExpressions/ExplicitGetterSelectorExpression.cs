using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions.Arguments;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.SelectorExpressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Rider.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.SelectorExpressions;

public class ExplicitGetterSelectorExpression : SwiftCompositeNode, IExplicitGetterSelectorExpression
{
    public SelectorKeyword SelectorKeyword { get; }
    
    public LeftParenthesis ArgumentsStart { get; }
    
    public IReadOnlyIdentifier GetterArgumentLabel { get; }

    public Colon GetterArgumentLabelValueSeparator { get; }

    public IExpression GetterArgumentValue { get; }
    
    public RightParenthesis ArgumentsEnd { get; }
    
    public IFunctionCallArgumentList Arguments { get; }

    internal ExplicitGetterSelectorExpression(IEditableBuffer buffer,
        IEnumerable<ISwiftNode<SwiftCompositeNode>> children, SelectorKeyword selectorKeyword,
        LeftParenthesis argumentsStart, IReadOnlyIdentifier getterArgumentLabel,
        Colon getterArgumentLabelValueSeparator, IExpression getterArgumentValue, RightParenthesis argumentsEnd,
        IFunctionCallArgumentList arguments)
        : base(buffer, children)
    {
        SelectorKeyword = selectorKeyword;
        ArgumentsStart = argumentsStart;
        GetterArgumentLabel = getterArgumentLabel;
        GetterArgumentLabelValueSeparator = getterArgumentLabelValueSeparator;
        GetterArgumentValue = getterArgumentValue;
        ArgumentsEnd = argumentsEnd;
        Arguments = arguments;
        
        ReturnType = UnknownType.Instance;
    }

    IReadOnlyExpression IReadOnlyExplicitGetterSelectorExpression.GetterArgumentValue => GetterArgumentValue;

    IReadOnlyFunctionCallArgumentList IReadOnlySelectorExpression.Arguments => Arguments;

    public IType ReturnType { get; }

    IReadOnlyType IReadOnlyBaseExpression.ReturnType => ReturnType;

    public void ChangeGetterArgumentValue(IExpression newValue)
    {
        throw new NotImplementedException();
    }
}
