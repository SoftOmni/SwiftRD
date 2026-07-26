using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Enumerations.Members;

public interface IReadOnlySwitchCaseMembers : ISwiftInternalNode<SwiftCompositeNode>,
    IReadOnlyList<IReadOnlySwitchCaseMember>
{
    IReadOnlyList<IReadOnlySwitchCaseMember> Members { get; }
    
    new IReadOnlySwitchCaseMember this[int index] { get; }
}
