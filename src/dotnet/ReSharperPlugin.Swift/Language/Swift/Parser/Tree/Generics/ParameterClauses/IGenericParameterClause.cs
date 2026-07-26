using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ParameterClauses.Parameters;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ParameterClauses;

public interface IGenericParameterClause : IReadOnlyGenericParameterClause,
    IList<IGenericParameter>
{
    new IReadOnlyList<IGenericParameter> GenericParameters { get; }
    
    new int Count { get; }

    new IEnumerator<IGenericParameter> GetEnumerator();
    
    new IGenericParameter this[int index] { get; set; }
}
