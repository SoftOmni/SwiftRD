using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Actors;

public interface IReadOnlyActorMembers : ISwiftInternalNode<SwiftCompositeNode>,
    IReadOnlyList<IReadOnlyActorMember>
{
    IReadOnlyList<IReadOnlyActorMember> Members { get; }
    
    new IReadOnlyActorMember this[int index] { get; }
}
