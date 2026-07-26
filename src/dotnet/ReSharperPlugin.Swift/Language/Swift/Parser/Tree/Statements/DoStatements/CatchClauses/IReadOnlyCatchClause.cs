using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.CodeBlocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.DoStatements.CatchClauses.CatchPatterns;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.DoStatements.CatchClauses;

public interface IReadOnlyCatchClause : IReadOnlyList<IReadOnlyCatchPattern>
{
    Catch Catch { get; }
    
    IReadOnlyCatchPatternList CatchPatternList { get; }
    
    IReadOnlyList<IReadOnlyCatchPattern> CatchPatterns { get; }
    
    IReadOnlyCodeBlock CodeBlock { get; }
}
