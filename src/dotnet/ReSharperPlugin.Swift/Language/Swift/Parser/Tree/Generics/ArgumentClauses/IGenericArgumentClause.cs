using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ArgumentClauses;

public interface IGenericArgumentClause : IReadOnlyGenericArgumentClause, IList<IGenericArgument>, IList<IType>
{
    public new IGenericArgumentGroup? GenericArgumentGroup { get; }
}