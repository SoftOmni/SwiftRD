using System.Collections.Generic;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.DoStatements.CatchClauses;

public interface ICatchPatternList : IReadOnlyCatchPatternList,
    IList<ICatchPattern>
{
    new IReadOnlyList<ICatchPattern> CatchPatterns { get; }
    
    new int Count { get; }

    new IEnumerator<ICatchPattern> GetEnumerator();
    
    new ICatchPattern this[int index] { get; }
}
