using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;

public interface IReadOnlyAttribute : ISwiftInternalNode<SwiftCompositeNode>,
    IReadOnlyList<IReadOnlyBalancedToken>
{
    At AttributeIntroducer { get; }
    
    IReadOnlyIdentifier Name { get; }
    
    LeftParenthesis ParametersStart { get; }
    
    IReadOnlyList<IReadOnlyBalancedToken> BalancedTokens { get; }
    
    RightParenthesis ParametersEnd { get; }
    
    new IReadOnlyBalancedToken this[int index] { get; }
}
