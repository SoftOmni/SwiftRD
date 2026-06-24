using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ArgumentClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.ExplicitMemberExpressions;

public interface IReadOnlyExplicitMemberExpressionStandardMemberAccess : IReadOnlyExplicitMemberExpression
{
    Period Period { get; }
    
    IReadOnlyIdentifier MemberName { get; }
    
    IReadOnlyGenericArgumentClause GenericArgumentClause { get; }
}
