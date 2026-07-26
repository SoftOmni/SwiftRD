using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.ComposedLiterals.DictionaryLiterals;

public class DictionaryLiteralElement : SwiftCompositeNode, IDictionaryLiteralElement
{
    public IExpression KeyExpression { get; }

    public Colon KeyValueSeparator { get; }

    public IExpression ValueExpression { get; }

    internal DictionaryLiteralElement(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children, 
        IExpression keyExpression, Colon keyValueSeparator, IExpression valueExpression)
        : base(buffer, children)
    {
        KeyExpression = keyExpression;
        KeyValueSeparator = keyValueSeparator;
        ValueExpression = valueExpression;
    }

    IReadOnlyExpression IReadOnlyDictionaryLiteralElement.KeyExpression => KeyExpression;

    IReadOnlyExpression IReadOnlyDictionaryLiteralElement.ValueExpression => ValueExpression;

    public void ChangeKeyExpression(IExpression newKeyExpression)
    {
        throw new NotImplementedException();
    }

    public void ChangeValueExpression(IExpression newValueExpression)
    {
        throw new NotImplementedException();
    }
}
