using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.IntegerLiterals;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.StringLiterals;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.LineControlStatements;

public interface ILineControlStatementWithSpecifics : IReadOnlyLineControlStatementWithSpecifics,
    ILineControlStatement
{
    new IStringLiteral FileArgumentValue { get; }

    void ChangeFileArgumentValue(IStringLiteral stringLiteral);
    
    new IIntegerLiteral LineArgumentValue { get; }

    void ChangeLineArgumentValue(IIntegerLiteral integerLiteral);
}
