using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions.CaptureLists;

public interface IReadOnlyCaptureList : ISwiftInternalNode<SwiftCompositeNode>, IReadOnlyList<IReadOnlyCaptureListItem>
{
    LeftSquareBracket LeftSquareBracket { get; }
    
    IReadOnlyList<IReadOnlyCaptureListItem> Items { get; }
    
    IReadOnlyList<Comma> Commas { get; }
    
    RightSquareBracket RightSquareBracket { get; }
    
    new IReadOnlyCaptureList this[int index] { get; }
}
// TODO: Finish closures