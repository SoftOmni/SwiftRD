using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ParameterClauses.Parameters;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ParameterClauses;

public interface IReadOnlyGenericParameterClause : ISwiftInternalNode<SwiftCompositeNode>,
    IReadOnlyList<IReadOnlyGenericParameter>
{
    LeftAngleBracket ParameterClauseStart { get; }
    
    IReadOnlyList<IReadOnlyGenericParameter> GenericParameters { get; }

    IReadOnlyList<Comma> GenericParameterSeparators { get; }
    
    RightAngleBracket ParameterClauseEnd { get; }
    
    new IReadOnlyGenericParameter this[int index] { get; }
}
