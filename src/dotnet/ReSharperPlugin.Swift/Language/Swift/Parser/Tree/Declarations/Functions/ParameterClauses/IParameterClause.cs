using System.Collections.Generic;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses;

public interface IParameterClause : IReadOnlyParameterClause, IList<IParameter>
{
    new IParameterList ParameterList { get; }
    
    new IReadOnlyList<IParameter> Parameters { get; }
    
    new int Count { get; }

    new IEnumerator<IParameter> GetEnumerator();
    
    new IParameter this[int index] { get; set; }

    void ChangeParameterList(IParameterList newParameterList);
}
