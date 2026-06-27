using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions.ClojureParameterLists;

public interface IReadOnlyClosureParameterClause : ISwiftInternalNode<SwiftCompositeNode>, IReadOnlyList<IReadOnlyClosureParameter>
{
    LeftParenthesis LeftParenthesis { get; }
    
    IReadOnlyList<IReadOnlyClosureParameter> Parameters { get; }
    
    IReadOnlyList<Comma> Commas { get; }
    
    RightParenthesis RightParenthesis { get; }
}
