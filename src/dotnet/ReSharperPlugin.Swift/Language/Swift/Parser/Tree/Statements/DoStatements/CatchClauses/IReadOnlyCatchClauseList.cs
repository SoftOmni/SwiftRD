using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.DoStatements.CatchClauses;

public interface IReadOnlyCatchClauseList : ISwiftInternalNode<SwiftCompositeNode>, 
    IReadOnlyList<IReadOnlyCatchClause>
{
    IReadOnlyList<IReadOnlyCatchClause> CatchClauses { get; }
    
    new IReadOnlyCatchClause this[int index] { get; }
}
