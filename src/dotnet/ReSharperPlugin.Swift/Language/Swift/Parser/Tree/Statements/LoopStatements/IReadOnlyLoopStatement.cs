using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.CodeBlocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.ControlTransferStatements;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LabeledStatements;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements;

public interface IReadOnlyLoopStatement : IReadOnlyLabelableStatement, ISwiftInternalNode<SwiftCompositeNode>
{
    IReadOnlyCodeBlock CodeBlock { get; }
    
    IReadOnlyList<IReadOnlyControlTransferStatement> LoopControlTransferStatements { get; }
}
