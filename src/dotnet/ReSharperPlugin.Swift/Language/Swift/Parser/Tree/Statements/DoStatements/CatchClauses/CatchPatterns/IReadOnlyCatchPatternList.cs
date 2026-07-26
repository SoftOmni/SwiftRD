using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.DoStatements.CatchClauses.CatchPatterns;

public interface IReadOnlyCatchPatternList : ISwiftInternalNode<SwiftCompositeNode>,
    IReadOnlyList<IReadOnlyCatchPattern>
{
    IReadOnlyList<IReadOnlyCatchPattern> CatchPatterns { get; }
    
    IReadOnlyList<Comma> Commas { get; }
    
    new IReadOnlyCatchPattern this[int index] { get; }
}
