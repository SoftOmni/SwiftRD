using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.LeafNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

public interface IReadOnlyIdentifier : ISwiftLeafNode<SwiftCompositeNode>, IReadOnlyList<char>
{
    public bool IsOnlyAscii { get; }
}