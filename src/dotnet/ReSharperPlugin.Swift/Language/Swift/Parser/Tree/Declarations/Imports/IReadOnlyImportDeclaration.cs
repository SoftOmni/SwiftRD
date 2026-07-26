using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Imports;

public interface IReadOnlyImportDeclaration : ISwiftNode<SwiftCompositeNode>,
    IReadOnlyList<IReadOnlyIdentifier>
{
    IReadOnlyAttributeGroup? Attributes { get; }

    Import Import { get; }

    IReadOnlyImportKind? ImportKind { get; }

    IReadOnlyImportPath ImportPath { get; }
    
    IReadOnlyList<IReadOnlyIdentifier> PathComponents { get; }
}
