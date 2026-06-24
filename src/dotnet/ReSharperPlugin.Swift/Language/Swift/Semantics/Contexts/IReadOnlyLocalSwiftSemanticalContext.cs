using System;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Semantics.Context;

public interface IReadOnlyLocalSwiftSemanticalContext : IReadOnlySwiftSemanticalContext
{
    IReadOnlyModuleBaseSwiftSemanticalContext ModuleContext { get; }

    enum ContextKind
    {
        Global,
        TopLevelType,
        InnerType,
        Function,
        Closure
    }

    ContextKind Context { get; }

    bool IsContextClosureContext();
    
    bool IsContextFunctionContext();

    bool IsContextTypeContext();

    bool IsContextTopLevelTypeContext();

    bool IsContextGlobalModuleLevelContext();
    
    bool IsDeclarationExternalToContext(string name);

    bool IsDeclarationExternalToContext(IReadOnlyIdentifier name);

    bool IsDeclarationExternalToContext(ReadOnlySpan<char> name);
    
    bool IsDeclarationLocalToContext(string name);

    bool IsDeclarationLocalToContext(IReadOnlyIdentifier name);

    bool IsDeclarationLocalToContext(ReadOnlySpan<char> name);
    
    bool IsDeclarationFromGlobalContext(string name);

    bool IsDeclarationFromGlobalContext(IReadOnlyIdentifier name);

    bool IsDeclarationFromGlobalContext(ReadOnlySpan<char> name);
    
    bool IsDeclarationFromFunctionContext(string name);

    bool IsDeclarationFromFunctionContext(IReadOnlyIdentifier name);

    bool IsDeclarationFromFunctionContext(ReadOnlySpan<char> name);
    
    bool IsDeclarationFromClosureContext(string name);

    bool IsDeclarationFromClosureContext(IReadOnlyIdentifier name);

    bool IsDeclarationFromClosureContext(ReadOnlySpan<char> name);
    
    bool IsDeclarationFromInnerTypeContext(string name);

    bool IsDeclarationFromInnerTypeContext(IReadOnlyIdentifier name);

    bool IsDeclarationFromInnerTypeContext(ReadOnlySpan<char> name);
    
    bool IsDeclarationFromTypeContext(string name);

    bool IsDeclarationFromTypeContext(IReadOnlyIdentifier name);

    bool IsDeclarationFromTypeContext(ReadOnlySpan<char> name);
    
    bool IsDeclarationFromTopLevelTypeContext(string name);

    bool IsDeclarationFromTopLevelTypeContext(IReadOnlyIdentifier name);

    bool IsDeclarationFromTopLevelTypeContext(ReadOnlySpan<char> name);
}
