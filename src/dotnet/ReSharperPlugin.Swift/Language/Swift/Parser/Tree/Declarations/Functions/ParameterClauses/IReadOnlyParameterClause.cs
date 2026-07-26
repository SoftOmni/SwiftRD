using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses;

public interface IReadOnlyParameterClause : ISwiftInternalNode<SwiftCompositeNode>,
    IReadOnlyList<IReadOnlyParameter>
{
    LeftParenthesis ParametersStart { get; }
    
    IReadOnlyList<IReadOnlyParameter> Parameters { get; }
    
    IReadOnlyParameterList ParameterList { get; }
    
    RightParenthesis ParametersEnd { get; }
    
    new IReadOnlyParameter this[int index] { get; }
}
