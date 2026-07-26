using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.PrecedenceGroups.Assignment;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class AssignmentKeywordToken : ContextSensitiveKeywordToken<Assignment>
{
    internal AssignmentKeywordToken()
        : base(Assignment.Keyword, SwiftTokens.AssignmentId, SwiftTokens.AssignmentIndex)
    { }
}
