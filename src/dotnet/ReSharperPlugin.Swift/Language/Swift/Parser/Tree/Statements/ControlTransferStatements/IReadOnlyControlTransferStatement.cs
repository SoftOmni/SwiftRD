using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.ControlTransferStatements;

public interface IReadOnlyControlTransferStatement : ISwiftInternalNode<SwiftCompositeNode>,
    IReadOnlyStatement;
