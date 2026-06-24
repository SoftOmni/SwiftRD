using System.Collections.Generic;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;

public interface IReadOnlyAttributeGroup : IReadOnlyList<IReadOnlyAttribute>
{
    IReadOnlyList<IReadOnlyAttribute> Attributes { get; }
}
