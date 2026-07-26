using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;
using SoftOmni.SwiftRd.Rider.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.KeyPathExpressions.Components;
using IReadOnlyOperator = SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators.Usages.IReadOnlyOperator;

namespace SoftOmni.SwiftRd.Rider.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.
    KeyPathExpressions;

public interface IReadOnlyKeyPathExpression : IReadOnlyPrimaryExpression, IReadOnlyList<IReadOnlyKeyPathComponent>
{
    IReadOnlyOperator Operator { get; }

    IReadOnlyType? Type { get; }

    Period TypeSeparator { get; }

    IReadOnlyList<IReadOnlyKeyPathComponent> KeyPathComponents { get; }

    IReadOnlyList<Period> KeyPathComponentsSeparators { get; }
}