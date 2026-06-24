using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.InfixExpressions.TypeCastingOperators;

public interface IReadOnlyTypeCastingOperator : ISwiftNode<SwiftCompositeNode>
{
    enum Kind
    {
        Is,
        As,
        AsOptional,
        AsForceful
    }
    
    Kind CurrentKind { get; }
}