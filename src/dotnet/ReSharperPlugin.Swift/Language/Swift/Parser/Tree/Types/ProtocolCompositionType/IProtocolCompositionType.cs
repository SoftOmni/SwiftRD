using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeIdentifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.ProtocolCompositionType;

public interface IProtocolCompositionType : IReadOnlyProtocolCompositionType, IType, IList<ITypeIdentifier>
{
    new int Count { get; }
    
    new IEnumerator<ITypeIdentifier> GetEnumerator();
    
    new ITypeIdentifier this[int index] { get; set; }
}
