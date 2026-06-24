using System.Collections.Generic;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeInheritanceClauses;

public interface ITypeInheritanceClause : IReadOnlyTypeInheritanceClause, IList<ITypeInheritanceListElement>
{
    new int Count { get; }

    new IEnumerator<ITypeInheritanceListElement> GetEnumerator();
    
    new ITypeInheritanceListElement this[int index] { get; set; }
}
