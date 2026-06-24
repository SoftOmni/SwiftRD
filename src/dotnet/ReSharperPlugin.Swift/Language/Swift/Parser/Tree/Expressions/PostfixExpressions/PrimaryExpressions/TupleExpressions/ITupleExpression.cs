using System.Collections.Generic;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.TupleExpressions;

public interface ITupleExpression : IReadOnlyTupleExpression, IPrimaryExpression, IList<ITupleExpressionElement>;
