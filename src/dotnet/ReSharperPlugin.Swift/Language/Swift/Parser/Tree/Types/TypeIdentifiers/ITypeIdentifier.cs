using System.Collections.Generic;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeIdentifiers;

public interface ITypeIdentifier : IReadOnlyTypeIdentifier, IType, IList<ITypeIdentifierComponent>
{
    new int Count { get; }
    
    new IEnumerator<ITypeIdentifierComponent> GetEnumerator();
    
    new ITypeIdentifierComponent this[int index] { get; set; }
}