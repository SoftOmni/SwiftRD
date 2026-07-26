using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;

namespace ReSharperPlugin.Swift.Language.Swift.Parser.Tree.Declarations.Enumerations.Members.RawValueStyle;

public interface IReadOnlyRawValueStyleMembers : ISwiftInternalNode<SwiftCompositeNode>,
    IReadOnlyList<IReadOnlySwitchCaseMember>
{
    IReadOnlyList<IReadOnlySwitchCaseMember> Members { get; }
    
    new IReadOnlySwitchCaseMember this[int index] { get; }
}
