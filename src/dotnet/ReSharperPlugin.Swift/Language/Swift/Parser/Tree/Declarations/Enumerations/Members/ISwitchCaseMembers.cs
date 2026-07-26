using System.Collections.Generic;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Enumerations.Members;

public interface ISwitchCaseMembers : IReadOnlySwitchCaseMembers, IList<ISwitchCaseMember>
{
    new IReadOnlyList<ISwitchCaseMember> Members { get; }
    
    new int Count { get; }

    new IEnumerator<ISwitchCaseMember> GetEnumerator();
    
    new ISwitchCaseMember this[int index] { get; set; }
}
