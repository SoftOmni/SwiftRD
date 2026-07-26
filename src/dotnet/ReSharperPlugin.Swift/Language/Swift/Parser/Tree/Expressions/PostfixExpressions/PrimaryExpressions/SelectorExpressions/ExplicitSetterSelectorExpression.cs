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

public class ExplicitSetterSelectorExpression : SwiftCompositeNode, IExplicitSetterSelectorExpression
{
    public SelectorKeyword SelectorKeyword { get; }
    
    public LeftParenthesis ArgumentsStart { get; }
    
    public IReadOnlyIdentifier SetterArgumentLabel { get; }

    public Colon SetterArgumentLabelValueSeparator { get; }

    public IExpression SetterArgumentValue { get; }
    
    public RightParenthesis ArgumentsEnd { get; }
    
    public IFunctionCallArgumentList Arguments { get; }

    internal ExplicitSetterSelectorExpression(IEditableBuffer buffer,
        IEnumerable<ISwiftNode<SwiftCompositeNode>> children, SelectorKeyword selectorKeyword,
        LeftParenthesis argumentsStart, IReadOnlyIdentifier setterArgumentLabel,
        Colon setterArgumentLabelValueSeparator, IExpression setterArgumentValue, RightParenthesis argumentsEnd,
        IFunctionCallArgumentList arguments)
        : base(buffer, children)
    {
        SelectorKeyword = selectorKeyword;
        ArgumentsStart = argumentsStart;
        SetterArgumentLabel = setterArgumentLabel;
        SetterArgumentLabelValueSeparator = setterArgumentLabelValueSeparator;
        SetterArgumentValue = setterArgumentValue;
        ArgumentsEnd = argumentsEnd;
        Arguments = arguments;
        
        ReturnType = UnknownType.Instance;
    }

    IReadOnlyExpression IReadOnlyExplicitSetterSelectorExpression.SetterArgumentValue => SetterArgumentValue;

    IReadOnlyFunctionCallArgumentList IReadOnlySelectorExpression.Arguments => Arguments;

    public IType ReturnType { get; }

    IReadOnlyType IReadOnlyBaseExpression.ReturnType => ReturnType;

    public void ChangeSetterArgumentValue(IExpression newValue)
    {
        throw new NotImplementedException();
    }
}
