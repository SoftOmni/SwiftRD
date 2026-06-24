using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;

public interface IReadOnlyAwaitExpression : ISwiftNode<SwiftCompositeNode>
{
    Await AwaitKeyword { get; }
}
