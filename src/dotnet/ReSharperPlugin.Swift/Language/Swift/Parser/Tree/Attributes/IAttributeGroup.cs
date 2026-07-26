using System.Collections.Generic;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;

public interface IAttributeGroup : IReadOnlyAttributeGroup, IList<IAttribute>
{
    new IReadOnlyList<IAttribute> Attributes { get; }
    
    new int Count { get; }

    new IEnumerator<IAttribute> GetEnumerator();
    
    new IAttribute this[int index] { get; set; }
}
