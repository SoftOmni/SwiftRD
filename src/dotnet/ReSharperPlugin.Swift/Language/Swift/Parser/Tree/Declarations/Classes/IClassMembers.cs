using System.Collections.Generic;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Classes;

public interface IClassMembers : IReadOnlyClassMembers,
    IList<IClassMember>
{
    new IReadOnlyList<IClassMember> Members { get; }
    
    new int Count { get; }

    new IEnumerator<IClassMember> GetEnumerator();
    
    new IClassMember this[int index] { get; set; }
}