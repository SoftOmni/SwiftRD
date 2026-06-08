using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ArgumentClauses;

public interface IReadOnlyGenericArgumentClause : ISwiftNode<SwiftCompositeNode>, IReadOnlyList<IType>,
    IReadOnlyList<IGenericArgument>
{
    public LeftAngleBracket? LeftAngleBracket { get; }
    
    public IReadOnlyGenericArgumentGroup? GenericArgumentGroup { get; }
    
    public RightAngleBracket? RightAngleBracket { get; }
}
