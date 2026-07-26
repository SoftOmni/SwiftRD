using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.CodeBlocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.DoStatements.CatchClauses.CatchPatterns;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.DoStatements.CatchClauses;

public interface ICatchClause : IReadOnlyCatchClause, IList<ICatchPattern>
{
    new ICatchPatternList CatchPatternList { get; }
    
    new IReadOnlyList<ICatchPattern> CatchPatterns { get; }

    void ChangeCatchPatternList(ICatchPatternList newCatchPatternList);
    
    new int Count { get; }

    new IEnumerator<ICatchPattern> GetEnumerator();
    
    new ICatchPattern this[int index] { get; }
    
    new ICodeBlock CodeBlock { get; }

    void ChangeCodeBlock(ICodeBlock newCodeBlock);
}
