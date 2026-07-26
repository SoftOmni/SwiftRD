using System.Collections.Generic;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.StatementGroups;

public interface IStatementGroup : IReadOnlyStatementGroup, IStatement, IList<IStatement>
{
    new IReadOnlyList<IStatement> Statements { get; }
    
    new IStatement this[int index] { get; set; }
    
    new int Count { get; }

    new IEnumerator<IStatement> GetEnumerator();
}
