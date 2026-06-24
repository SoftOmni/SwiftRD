using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions.Arguments;

public interface IReadOnlyFunctionCallArgument : ISwiftInternalNode<SwiftCompositeNode>
{
    IReadOnlyIdentifier? Label { get; }
    
    Colon? Colon { get; }
    
    bool IsLabeled { get; }
}
