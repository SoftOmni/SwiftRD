using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Enumerations.Members.RawValueStyle;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Enumerations.Cases.RawValue;

public interface IRawValueStyleEnumCaseClause :
    IReadOnlyRawValueStyleEnumCaseClause, 
    IReadOnlyRawValueStyleMember,
    IList<IRawValueStyleEnumCase>
{
    new IAttributeGroup? Attributes { get; }
    
    new IReadOnlyList<IRawValueStyleEnumCase> Cases { get; }

    new int Count { get; }
    
    new IEnumerator<IRawValueStyleEnumCase> GetEnumerator();
    
    new IRawValueStyleEnumCase this[int index] { get; set; }
}
