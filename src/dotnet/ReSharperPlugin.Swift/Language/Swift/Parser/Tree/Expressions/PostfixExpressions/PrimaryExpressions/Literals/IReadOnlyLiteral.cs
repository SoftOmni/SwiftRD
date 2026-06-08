using SoftOmni.SwiftRd.Language.Semantics.Type;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals;

public interface IReadOnlyLiteral<out TSwiftType, TCSharpValueType> : ISwiftNode<SwiftCompositeNode> where TSwiftType : Type
{
    
    public TSwiftType Type { get; }

    public TCSharpValueType Value { get; }

    public TCSharpValueType GetValueCopy();
}
