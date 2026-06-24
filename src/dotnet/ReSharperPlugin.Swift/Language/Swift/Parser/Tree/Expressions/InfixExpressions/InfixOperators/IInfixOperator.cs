using System;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.InfixExpressions.InfixOperators;

public interface IInfixOperator : IReadOnlyInfixOperator
{
    void ChangeValue(string value);

    void ChangeValue(IBuffer value);
    
    void ChangeValue(ReadOnlySpan<char> value);
}
