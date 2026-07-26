using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.Signatures;

public interface IReadOnlyFunctionSignature : ISwiftInternalNode<SwiftCompositeNode>
{
    IReadOnlyParameterClause ParameterClause { get; }
    
    Async? AsynchronousKeyword { get; }
    
    IReadOnlyFunctionResult? FunctionResult { get; }
}
