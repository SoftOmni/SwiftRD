using System;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PrefixExpressions.PrefixOperators;

public interface IPrefixOperator : IReadOnlyPrefixOperator
{
    void ChangeValue(string value);

    void ChangeValue(IBuffer value);
    
    void ChangeValue(ReadOnlySpan<char> value);
}
