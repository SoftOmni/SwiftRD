using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns.Destructuring.TupleBased;

public interface IReadOnlyTuplePattern : ISwiftInternalNode<SwiftCompositeNode>, IReadOnlyList<IReadOnlyTuplePatternElement>
{
    LeftParenthesis? LeftParenthesis { get; }
    
    IReadOnlyList<Comma> Commas { get; }
    
    IReadOnlyList<IReadOnlyTuplePatternElement> Elements { get; }
    
    RightParenthesis? RightParenthesis { get; }
}