using System.Collections.Generic;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Actors;

public interface IActorMembers : IReadOnlyActorMembers,
    IList<IActorMember>
{
    new IReadOnlyList<IActorMember> Members { get; }
    
    new int Count { get; }

    new IEnumerator<IActorMember> GetEnumerator();
    
    new IActorMember this[int index] { get; set; }
}