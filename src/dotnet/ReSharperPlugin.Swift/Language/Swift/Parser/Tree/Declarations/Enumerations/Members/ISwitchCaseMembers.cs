using System.Collections.Generic;

namespace ReSharperPlugin.Swift.Language.Swift.Parser.Tree.Declarations.Enumerations.Members.RawValueStyle;

public interface IRawValueStyleMembers : IReadOnlyRawValueStyleMembers, IList<IMember>
{
    new IReadOnlyList<IMember> Members { get; }
    
    new int Count { get; }

    new IEnumerator<IMember> GetEnumerator();
    
    new IMember this[int index] { get; set; }
}
