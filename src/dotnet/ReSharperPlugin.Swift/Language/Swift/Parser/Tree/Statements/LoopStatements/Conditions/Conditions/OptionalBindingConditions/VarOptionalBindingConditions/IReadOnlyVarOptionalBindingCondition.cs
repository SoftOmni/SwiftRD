using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Constants;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.Conditions.Conditions.
    OptionalBindingConditions.VarOptionalBindingConditions;

public interface IReadOnlyVarOptionalBindingCondition
    : IReadOnlyOptionalBindingCondition
{
    Var Var { get; }
}
