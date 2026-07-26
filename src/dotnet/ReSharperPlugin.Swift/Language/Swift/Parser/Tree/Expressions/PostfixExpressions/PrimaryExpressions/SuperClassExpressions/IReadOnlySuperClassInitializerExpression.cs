using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Initializers.Inits;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.SuperClassExpressions;

public interface IReadOnlySuperClassInitializerExpression : IReadOnlySuperClassExpression
{
    Period Period { get; }
    
    Init Init { get; }
}
