using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Classes;

public interface IReadOnlyClassMembers : ISwiftInternalNode<SwiftCompositeNode>,
    IReadOnlyList<IReadOnlyClassMember>
{
    IReadOnlyList<IReadOnlyClassMember> Members { get; }
    
    new IReadOnlyClassMember this[int index] { get; }
}
