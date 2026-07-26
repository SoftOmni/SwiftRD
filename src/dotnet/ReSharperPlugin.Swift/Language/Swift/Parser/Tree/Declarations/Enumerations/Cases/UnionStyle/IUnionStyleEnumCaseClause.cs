using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Enumerations.Cases.UnionValues;

public interface IUnionStyleEnumCaseClause : IReadOnlyUnionStyleEnumCaseClause,
    IUnionStyleMember,
    IList<IUnionStyleEnumCase>
{
    new IAttributeGroup? Attributes { get; }
    
    new IReadOnlyList<IUnionStyleEnumCase> Cases { get; }

    void SetAttributesTo(IAttributeGroup? newAttributes);

    void RemoveAttributes();
    
    new int Count { get; }

    new IEnumerator<IUnionStyleEnumCase> GetEnumerator();
    
    new IUnionStyleEnumCase this[int index] { get; set; }
}
