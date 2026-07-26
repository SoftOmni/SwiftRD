using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Constants;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.Conditions.Conditions.
    OptionalBindingConditions.LetOptionalBindingConditions;

public interface IReadOnlyLetOptionalBindingCondition
    : IReadOnlyOptionalBindingCondition
{
    Let Let { get; }
}
