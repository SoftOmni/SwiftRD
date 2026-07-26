using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses;

public interface IReadOnlyParameterList : 
    ISwiftInternalNode<SwiftCompositeNode>, 
    IReadOnlyList<IReadOnlyParameter>
{
    IReadOnlyList<IReadOnlyParameter> Parameters { get; }

    IReadOnlyList<Comma> ParameterSeparators { get; }
    
    new IReadOnlyParameter this[int index] { get; }
}
