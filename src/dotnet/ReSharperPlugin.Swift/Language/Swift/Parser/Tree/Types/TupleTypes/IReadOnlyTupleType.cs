using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TupleTypes;

public interface IReadOnlyTupleType : IReadOnlyType, IReadOnlyList<IReadOnlyTupleTypeElement>
{
    LeftParenthesis LeftParenthesis { get; }
    
    IReadOnlyList<IReadOnlyTupleTypeElement> Elements { get; }
    
    IReadOnlyList<Comma> Commas { get; }
    
    RightParenthesis RightParenthesis { get; }
}
