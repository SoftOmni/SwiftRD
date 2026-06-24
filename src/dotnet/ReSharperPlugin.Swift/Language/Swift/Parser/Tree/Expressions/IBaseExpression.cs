using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;

public interface IBaseExpression : IReadOnlyBaseExpression, IStatement
{
    new IType ReturnType { get; }
}
