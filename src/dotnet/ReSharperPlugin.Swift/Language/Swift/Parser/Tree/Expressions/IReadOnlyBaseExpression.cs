using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;

public interface IReadOnlyBaseExpression : IReadOnlyStatement
{
    IReadOnlyType ReturnType { get; }
}