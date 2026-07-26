using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Protocols;

public interface IReadOnlyProtocolMembers : ISwiftInternalNode<SwiftCompositeNode>,
    IReadOnlyList<IReadOnlyProtocolMember>
{
    IReadOnlyList<IReadOnlyProtocolMember> Members { get; }
    
    new IReadOnlyProtocolMember this[int index] { get; }
}
