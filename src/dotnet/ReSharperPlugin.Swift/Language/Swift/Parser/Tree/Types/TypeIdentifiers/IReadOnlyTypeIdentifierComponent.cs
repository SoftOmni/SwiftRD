using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ArgumentClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeIdentifiers;

public interface IReadOnlyTypeIdentifierComponent
{
    IReadOnlyIdentifier Name { get; }
    
    IReadOnlyGenericArgumentClause? GenericArgumentClause { get; }
}
