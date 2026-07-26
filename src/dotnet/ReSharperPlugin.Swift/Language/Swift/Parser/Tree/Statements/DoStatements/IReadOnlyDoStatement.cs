using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.CodeBlocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.DoStatements.CatchClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.FunctionTypes.ThrowClauses;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.DoStatements;

public interface IReadOnlyDoStatement : IReadOnlyStatement, IReadOnlyList<ICatchClause>
{
    Do Do { get; }
    
    IReadOnlyThrowsClause? ThrowsClause { get; }
    
    IReadOnlyCodeBlock CodeBlock { get; }
    
    IReadOnlyCatchClauseList CatchClauseList { get; }
    
    IReadOnlyList<ICatchClause> CatchClauses { get; }
}