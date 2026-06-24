using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ArgumentClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeIdentifiers;

public class TypeIdentifierComponent : SwiftCompositeNode, ITypeIdentifierComponent
{
    public IIdentifier Name { get; internal set; }
    
    public IGenericArgumentClause? GenericArgumentClause { get; internal set; }

    internal TypeIdentifierComponent(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IIdentifier name, IGenericArgumentClause? genericArgumentClause = null)
        : base(buffer, children)
    {
        Name = name;
        GenericArgumentClause = genericArgumentClause;
    }

    IReadOnlyIdentifier IReadOnlyTypeIdentifierComponent.Name => Name;

    IReadOnlyGenericArgumentClause? IReadOnlyTypeIdentifierComponent.GenericArgumentClause => GenericArgumentClause;
    
    public void ChangeName(IIdentifier name)
    {
        throw new System.NotImplementedException();
    }

    public void ChangeGenericArgumentClause(IGenericArgumentClause? genericArgumentClause)
    {
        throw new System.NotImplementedException();
    }
}