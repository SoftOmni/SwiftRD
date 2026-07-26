using System.Collections.Generic;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Constants;

public interface IPatternInitializerList : IReadOnlyPatternInitializerList,
    IList<IPatternInitializer>
{
    new IReadOnlyList<IPatternInitializer> PatternInitializers { get; }
    
    new int Count { get; }
    
    new IEnumerator<IPatternInitializer> GetEnumerator();
    
    new IPatternInitializer this[int index] { get; set; }
}
