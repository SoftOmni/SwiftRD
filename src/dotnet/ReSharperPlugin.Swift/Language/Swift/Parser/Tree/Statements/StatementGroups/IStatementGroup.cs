using System.Collections.Generic;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.StatementGroups;

public interface IStatementGroup : IReadOnlyStatementGroup, IStatement, IList<IStatement>
{
    new IStatement this[int index] { get; }
    
    new int Count { get; }

    new IEnumerator<IStatement> GetEnumerator();
}
