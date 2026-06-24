using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.ComposedLiterals.DictionaryLiterals;

public interface IReadOnlyDictionaryLiteralElement : ISwiftInternalNode<SwiftCompositeNode>
{
    IReadOnlyExpression KeyExpression { get; }
    
    Colon KeyValueSeparator { get; }
    
    IReadOnlyExpression ValueExpression { get; }
}
