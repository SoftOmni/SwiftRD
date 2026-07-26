using System.Collections.Generic;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Extensions;

public interface IExtensionMembers : IReadOnlyExtensionMembers,
    IList<IExtensionMember>
{
    new IReadOnlyList<IExtensionMember> Members { get; }
    
    new int Count { get; }

    new IEnumerator<IExtensionMember> GetEnumerator();
    
    new IExtensionMember this[int index] { get; set; }
}