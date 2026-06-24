using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ArgumentClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.ExplicitMemberExpressions;

public interface IExplicitMemberExpressionStandardMemberAccess
    : IReadOnlyExplicitMemberExpressionStandardMemberAccess, IExplicitMemberExpression
{
    new IIdentifier MemberName { get; }
    
    new IGenericArgumentClause GenericArgumentClause { get; }

    void ChangeMember(IIdentifier newMemberToReference);
    
    void ChangeGenericArgumentClause(IGenericArgumentClause newGenericArgumentClause);
}
