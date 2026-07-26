using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Imports;

public interface IReadOnlyImportPath : ISwiftInternalNode<SwiftCompositeNode>,
    IReadOnlyList<IReadOnlyIdentifier>
{
    IReadOnlyList<IReadOnlyIdentifier> Components { get; }
    
    IReadOnlyList<Period> ComponentSeparators { get; }
    
    new IReadOnlyIdentifier this[int index] { get; }
}
