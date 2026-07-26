using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses;

public interface IReadOnlySingleParameter : IReadOnlyParameter
{
    Equal? DefaultClausePresenter { get; }
    
    IReadOnlyExpression? DefaultExpression { get; }
}
