using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Switches.WhereClauses;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.DoStatements.CatchClauses.CatchPatterns;

public interface IReadOnlyCatchPattern : ISwiftInternalNode<SwiftCompositeNode>
{
    IReadOnlyPattern Pattern { get; }
    
    IReadOnlyWhereClause? WhereClause { get; }
}
