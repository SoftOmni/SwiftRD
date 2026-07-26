using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.CodeBlocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.DoStatements.CatchClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.FunctionTypes.ThrowClauses;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.DoStatements;

public interface IDoStatement : IReadOnlyDoStatement, IStatement, IList<ICatchClause>
{
    new IThrowsClause? ThrowsClause { get; }

    void SetThrowsClauseTo(IThrowsClause? throwsClause);

    void RemoveThrowsClause();
    
    new ICodeBlock CodeBlock { get; }

    void ChangeCodeBlock(ICodeBlock newCodeBlock);

    new ICatchClauseList CatchClauseList { get; }

    void ChangeClauseList(ICatchClauseList newCatchClauseList);
    
    new IReadOnlyList<ICatchClause> CatchClauses { get; }
    
    new int Count { get; }

    new IEnumerator<ICatchClause> GetEnumerator();
    
    new ICatchClause this[int index] { get; set; }
}
