using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.IntegerLiterals;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.StringLiterals;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.LineControlStatements;

public interface IReadOnlyLineControlStatementSpecifics : IReadOnlyLineControlStatement
{
    IReadOnlyIdentifier FileArgumentLabel { get; }
    
    Colon FileArgumentLabelValueSeparator { get; }
    
    IReadOnlyStringLiteral FileArgumentValue { get; }
    
    Comma FileLineArgumentsSeparator { get; }
    
    IReadOnlyIdentifier LineArgumentLabel { get; }
    
    Colon LineArgumentLabelValeSeparator { get; }
    
    IReadOnlyIntegerLiteral LineArgumentValue { get; }
}
