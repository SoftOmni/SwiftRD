using System.Collections.Generic;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TupleTypes;

public interface ITupleType : IReadOnlyTupleType, IType, IList<ITupleTypeElement>
{
    new int Count { get; }
    
    new IEnumerator<ITupleTypeElement> GetEnumerator();
    
    new ITupleTypeElement this[int index] { get; set; }
}
