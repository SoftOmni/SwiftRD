using System.Collections.Generic;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;

public interface IAttributeGroup : IReadOnlyAttributeGroup, IList<IAttributeGroup>
{
    new IList<IAttributeGroup> Attributes { get; }
    
    new int Count { get; }

    new IEnumerator<IAttributeGroup> GetEnumerator();
    
    new IAttributeGroup this[int index] { get; set; }
}
