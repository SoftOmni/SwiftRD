using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.CodeBlocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.ControlTransferStatements;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements;

public interface IReadOnlyLoop : IReadOnlyStatement, ISwiftInternalNode<SwiftCompositeNode>
{
    IReadOnlyCodeBlock CodeBlock { get; }
    
    IReadOnlyList<IReadOnlyLoopControlTransferStatements> LoopControlTransferStatements { get; }
}
