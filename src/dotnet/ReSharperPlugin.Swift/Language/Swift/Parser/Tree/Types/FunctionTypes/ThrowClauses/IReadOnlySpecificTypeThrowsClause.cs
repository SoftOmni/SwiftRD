using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.FunctionTypes.ThrowClauses;

public interface IReadOnlySpecificTypeThrowsClause : IReadOnlyThrowsClause
{
    LeftParenthesis LeftParenthesis { get; }
    
    IReadOnlyType ErrorType { get; }
    
    RightParenthesis RightParenthesis { get; }
}
