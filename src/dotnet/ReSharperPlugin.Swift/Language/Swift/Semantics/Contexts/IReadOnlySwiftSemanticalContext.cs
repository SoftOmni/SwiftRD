using System;
using System.Collections.Generic;
using JetBrains.ReSharper.Psi.Tree;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeIdentifiers;
using SoftOmni.SwiftRd.Language.Swift.Semantics.PrimitiveLiterals;

namespace SoftOmni.SwiftRd.Language.Swift.Semantics.Context;

public interface IReadOnlySwiftSemanticalContext
{
    IReadOnlyPrimitiveLiteralTypeResolutionContext LiteralTypeResolutionContext { get; }
    
    IReadOnlyDictionary<string, IDeclaration> Declarations { get; }

    bool ContainsDeclaration(string name);

    bool ContainsDeclaration(IReadOnlyIdentifier name);

    bool ContainsDeclaration(ReadOnlySpan<char> name);

    bool ContainsDeclaration(IReadOnlyTypeIdentifier typeIdentifier);

    bool TryGetDeclaration(string name, out IDeclaration? declaration);

    bool TryGetDeclaration(IReadOnlyIdentifier name, out IDeclaration? declaration);

    bool TryGetDeclaration(ReadOnlySpan<char> name, out IDeclaration? declaration);

    bool TryGetDeclaration(IReadOnlyTypeIdentifier typeIdentifier);
}
