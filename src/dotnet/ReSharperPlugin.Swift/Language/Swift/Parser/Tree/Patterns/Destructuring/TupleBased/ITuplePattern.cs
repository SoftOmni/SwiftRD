using System.Collections.Generic;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns.Destructuring.TupleBased;

public interface ITuplePattern : IReadOnlyTuplePattern, IList<ITuplePatternElement>
{
    new int Count { get; }
    
    new ITuplePatternElement this[int index] { get; }
    
    new IReadOnlyList<ITuplePatternElement> Elements { get; }

    new IEnumerator<ITuplePatternElement> GetEnumerator();
}