using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.LineControlStatements;

public interface IReadOnlyLineControlStatement : IReadOnlyCompilerControlStatement
{
    ReservedSourceLocationKeyword SourceLocationKeyword { get; }
    
    LeftParenthesis ArgumentsStart { get; }
    
    RightParenthesis ArgumentsEnd { get; }
}
