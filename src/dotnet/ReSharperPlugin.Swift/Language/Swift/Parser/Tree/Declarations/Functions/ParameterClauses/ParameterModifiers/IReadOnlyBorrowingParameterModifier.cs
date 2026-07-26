namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses.ParameterModifiers;

public interface IReadOnlyBorrowingParameterModifier : IReadOnlyParameterModifier
{
    Borrowing Keyword { get; }
}