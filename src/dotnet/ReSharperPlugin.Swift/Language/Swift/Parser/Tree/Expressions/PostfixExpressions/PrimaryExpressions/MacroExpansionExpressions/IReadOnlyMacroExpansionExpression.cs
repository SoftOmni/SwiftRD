using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions.Arguments;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions.Closures;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ArgumentClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.MacroExpansionExpressions;

public interface IReadOnlyMacroExpansionExpression : IReadOnlyPrimaryExpression
{
    Hash Hash { get; }
    
    IReadOnlyIdentifier Name { get; }
    
    IReadOnlyGenericArgumentClause? GenericArgumentClause { get; }
    
    IReadOnlyFunctionCallArgumentList? ParametersClause { get; }
    
    IReadOnlyTrailingClosuresGroup? TrailingClosureParameters { get; }
}
