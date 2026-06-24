using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ArgumentClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeIdentifiers;

public interface ITypeIdentifierComponent : IReadOnlyTypeIdentifierComponent
{
    new IIdentifier Name { get; }
    
    new IGenericArgumentClause? GenericArgumentClause { get; }
    
    void ChangeName(IIdentifier name);
    
    void ChangeGenericArgumentClause(IGenericArgumentClause? genericArgumentClause);
}
