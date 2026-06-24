using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

public interface IReadOnlyType : ISwiftNode<SwiftCompositeNode>
{
    IReadOnlyDeclaration? Declaration { get; } // TODO: Investigate this further later
    
    IReadOnlyType ActualType { get; }

    string TypeSignature { get; }

    IReadOnlyType? SuperType { get; }

    IReadOnlyList<IReadOnlyList<IReadOnlyType>> SubTypeChains { get; }

    IReadOnlySet<IReadOnlyType> SubTypes { get; }

    IReadOnlySet<string> SubTypeNames { get; }

    bool IsFromStandardLibrary { get; }
    
    int Size { get; }
}
