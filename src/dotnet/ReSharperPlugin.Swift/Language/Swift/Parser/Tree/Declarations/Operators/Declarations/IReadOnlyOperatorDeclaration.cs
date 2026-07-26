namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators.Declarations;

public interface IReadOnlyOperatorDeclaration : IReadOnlyDeclaration
{
    OperatorKeyword OperatorKeyword { get; }
}
