using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.StatementGroups;

public interface IReadOnlyStatementGroup : IReadOnlyStatement, ISwiftInternalNode<SwiftCompositeNode>, 
    IReadOnlyList<IReadOnlyStatement>
{
    new IReadOnlyStatement this[int index] { get; }
    
    IReadOnlyList<IReadOnlyStatement> Statements { get; }
    
    bool IsEmpty { get; }
    
    bool HasStatements { get; }
}
