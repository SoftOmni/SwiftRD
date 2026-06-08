using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ArgumentClauses;

public interface IReadOnlyGenericArgumentGroup : ISwiftNode<SwiftCompositeNode>, IReadOnlyList<IType>, 
    IReadOnlyList<IGenericArgument>
{
    public IReadOnlyGenericArgumentClause? GenericArgumentClause { get; }
    
    public IReadOnlyList<IType> GenericArgumentTypes { get; }
    
    public IReadOnlyList<IGenericArgument> GenericArguments { get; }
    
    public new int Count { get; }

    public new IEnumerator<IGenericArgument> GetEnumerator();
    
    public new IGenericArgument this[int index] { get; }
}