using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ArgumentClauses;

public interface IGenericArgumentGroup : IReadOnlyGenericArgumentGroup, IList<IGenericArgument>,
    IList<IType>
{
    public IGenericArgumentClause? EditableGenericArgumentClause { get; }

    public IReadOnlyList<Comma> Commas { get; }
}
