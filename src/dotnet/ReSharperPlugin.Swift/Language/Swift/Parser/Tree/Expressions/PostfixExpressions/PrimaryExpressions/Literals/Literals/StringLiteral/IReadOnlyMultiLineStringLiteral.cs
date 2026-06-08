using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Whitespace;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.
    Literals.StringLiterals;

public interface IReadOnlyMultiLineStringLiteral : IReadOnlyStringLiteral
{
    int NumberOfLines { get; }

    WhitespaceSequence LeadingWhitespaceSequence { get; }
}