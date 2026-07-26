using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Constants;

public interface IReadOnlyInitializer : ISwiftInternalNode<SwiftCompositeNode>
{
    Equal AssignmentOperator { get; }
    
    IReadOnlyExpression Expression { get; }
}
