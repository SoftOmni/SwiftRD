using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Constants;

public interface IReadOnlyPatternInitializerList : ISwiftInternalNode<SwiftCompositeNode>,
    IReadOnlyList<IReadOnlyPatternInitializer>
{
    IReadOnlyList<IReadOnlyPatternInitializer> PatternInitializers { get; }
    
    IReadOnlyList<Comma> PatternInitializerSeparators { get; }
    
    new IReadOnlyPatternInitializer this[int index] { get; }
}
