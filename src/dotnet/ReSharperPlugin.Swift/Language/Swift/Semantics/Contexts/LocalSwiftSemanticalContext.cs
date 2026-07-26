using System;
using System.Collections.Generic;
using JetBrains.ReSharper.Psi.Tree;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeIdentifiers;
using SoftOmni.SwiftRd.Language.Swift.Semantics.PrimitiveLiterals;

namespace SoftOmni.SwiftRd.Language.Swift.Semantics.Context;

public class LocalSwiftSemanticalContext : ILocalSwiftSemanticalContext
{
    public IReadOnlyPrimitiveLiteralTypeResolutionContext LiteralTypeResolutionContext { get; }
    public IReadOnlyDictionary<string, IDeclaration> Declarations { get; }
    public bool ContainsDeclaration(string name)
    {
        throw new NotImplementedException();
    }

    public bool ContainsDeclaration(IReadOnlyIdentifier name)
    {
        throw new NotImplementedException();
    }

    public bool ContainsDeclaration(ReadOnlySpan<char> name)
    {
        throw new NotImplementedException();
    }

    public bool ContainsDeclaration(IReadOnlyTypeIdentifier typeIdentifier)
    {
        throw new NotImplementedException();
    }

    public bool TryGetDeclaration(string name, out IDeclaration? declaration)
    {
        throw new NotImplementedException();
    }

    public bool TryGetDeclaration(IReadOnlyIdentifier name, out IDeclaration? declaration)
    {
        throw new NotImplementedException();
    }

    public bool TryGetDeclaration(ReadOnlySpan<char> name, out IDeclaration? declaration)
    {
        throw new NotImplementedException();
    }

    public bool TryGetDeclaration(IReadOnlyTypeIdentifier typeIdentifier)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyModuleBaseSwiftSemanticalContext ModuleContext { get; }
    public IReadOnlyLocalSwiftSemanticalContext.ContextKind Context { get; }
    public bool IsContextClosureContext()
    {
        throw new NotImplementedException();
    }

    public bool IsContextFunctionContext()
    {
        throw new NotImplementedException();
    }

    public bool IsContextTypeContext()
    {
        throw new NotImplementedException();
    }

    public bool IsContextTopLevelTypeContext()
    {
        throw new NotImplementedException();
    }

    public bool IsContextGlobalModuleLevelContext()
    {
        throw new NotImplementedException();
    }

    public bool IsDeclarationExternalToContext(string name)
    {
        throw new NotImplementedException();
    }

    public bool IsDeclarationExternalToContext(IReadOnlyIdentifier name)
    {
        throw new NotImplementedException();
    }

    public bool IsDeclarationExternalToContext(ReadOnlySpan<char> name)
    {
        throw new NotImplementedException();
    }

    public bool IsDeclarationLocalToContext(string name)
    {
        throw new NotImplementedException();
    }

    public bool IsDeclarationLocalToContext(IReadOnlyIdentifier name)
    {
        throw new NotImplementedException();
    }

    public bool IsDeclarationLocalToContext(ReadOnlySpan<char> name)
    {
        throw new NotImplementedException();
    }

    public bool IsDeclarationFromGlobalContext(string name)
    {
        throw new NotImplementedException();
    }

    public bool IsDeclarationFromGlobalContext(IReadOnlyIdentifier name)
    {
        throw new NotImplementedException();
    }

    public bool IsDeclarationFromGlobalContext(ReadOnlySpan<char> name)
    {
        throw new NotImplementedException();
    }

    public bool IsDeclarationFromFunctionContext(string name)
    {
        throw new NotImplementedException();
    }

    public bool IsDeclarationFromFunctionContext(IReadOnlyIdentifier name)
    {
        throw new NotImplementedException();
    }

    public bool IsDeclarationFromFunctionContext(ReadOnlySpan<char> name)
    {
        throw new NotImplementedException();
    }

    public bool IsDeclarationFromClosureContext(string name)
    {
        throw new NotImplementedException();
    }

    public bool IsDeclarationFromClosureContext(IReadOnlyIdentifier name)
    {
        throw new NotImplementedException();
    }

    public bool IsDeclarationFromClosureContext(ReadOnlySpan<char> name)
    {
        throw new NotImplementedException();
    }

    public bool IsDeclarationFromInnerTypeContext(string name)
    {
        throw new NotImplementedException();
    }

    public bool IsDeclarationFromInnerTypeContext(IReadOnlyIdentifier name)
    {
        throw new NotImplementedException();
    }

    public bool IsDeclarationFromInnerTypeContext(ReadOnlySpan<char> name)
    {
        throw new NotImplementedException();
    }

    public bool IsDeclarationFromTypeContext(string name)
    {
        throw new NotImplementedException();
    }

    public bool IsDeclarationFromTypeContext(IReadOnlyIdentifier name)
    {
        throw new NotImplementedException();
    }

    public bool IsDeclarationFromTypeContext(ReadOnlySpan<char> name)
    {
        throw new NotImplementedException();
    }

    public bool IsDeclarationFromTopLevelTypeContext(string name)
    {
        throw new NotImplementedException();
    }

    public bool IsDeclarationFromTopLevelTypeContext(IReadOnlyIdentifier name)
    {
        throw new NotImplementedException();
    }

    public bool IsDeclarationFromTopLevelTypeContext(ReadOnlySpan<char> name)
    {
        throw new NotImplementedException();
    }
}