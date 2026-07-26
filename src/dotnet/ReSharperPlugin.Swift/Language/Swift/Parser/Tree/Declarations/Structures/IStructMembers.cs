using System.Collections.Generic;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Structs;

public interface IStructMembers : IReadOnlyStructMembers,
    IList<IStructMember>
{
    new IReadOnlyList<IStructMember> Members { get; }
    
    new int Count { get; }

    new IEnumerator<IStructMember> GetEnumerator();
    
    new IStructMember this[int index] { get; set; }
}