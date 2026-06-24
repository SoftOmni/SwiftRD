using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.TupleExpressions;

public interface IReadOnlyTupleExpressionElement : ISwiftInternalNode<SwiftCompositeNode>
{
    IReadOnlyIdentifier Identifier { get; }
    
    Colon Colon { get; }
    
    IReadOnlyExpression Expression { get; }
}
