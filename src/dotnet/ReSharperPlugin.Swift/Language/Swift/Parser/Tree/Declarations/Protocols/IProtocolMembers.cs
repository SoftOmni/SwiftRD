using System.Collections.Generic;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Protocols;

public interface IProtocolMembers : IReadOnlyProtocolMembers,
    IList<IProtocolMember>
{
    new IReadOnlyList<IProtocolMember> Members { get; }
    
    new int Count { get; }

    new IEnumerator<IProtocolMember> GetEnumerator();
    
    new IProtocolMember this[int index] { get; set; }
}