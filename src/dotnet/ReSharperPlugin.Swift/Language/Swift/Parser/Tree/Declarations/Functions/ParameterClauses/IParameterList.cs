using System.Collections.Generic;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses;

public interface IParameterList : IReadOnlyParameterList, IList<IParameter>
{
    new IReadOnlyList<IParameter> Parameters { get; }
    
    new int Count { get; }

    new IEnumerator<IParameter> GetEnumerator();
    
    new IParameter this[int index] { get; set; }
}
