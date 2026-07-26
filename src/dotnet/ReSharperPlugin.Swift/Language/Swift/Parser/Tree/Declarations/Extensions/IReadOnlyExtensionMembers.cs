using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Extensions;

public interface IReadOnlyExtensionMembers : ISwiftInternalNode<SwiftCompositeNode>,
    IReadOnlyList<IReadOnlyExtensionMember>
{
    IReadOnlyList<IReadOnlyExtensionMember> Members { get; }
    
    new IReadOnlyExtensionMember this[int index] { get; }
}
