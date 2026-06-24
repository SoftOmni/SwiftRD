using System;
using System.Collections.Generic;
using JetBrains.Util;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.TopLevel;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeIdentifiers;
using SoftOmni.SwiftRd.Language.Swift.ProjectModels.Modules;

namespace SoftOmni.SwiftRd.Language.Swift.Semantics.Context;

public interface IReadOnlyModuleBaseSwiftSemanticalContext : IReadOnlySwiftSemanticalContext
{
    IReadOnlySwiftModule Module { get; }

    IReadOnlyDictionary<string, (IReadOnlyTopLevelDeclaration declaration, IPath path)> TopLevelDeclarationMap { get; }

    bool TryGetTopLevelDeclarationForDeclaration(string name,
        out (IReadOnlyTopLevelDeclaration declaration, IPath path)? declaration);

    bool TryGetTopLevelDeclarationForDeclaration(IReadOnlyIdentifier name,
        out (IReadOnlyTopLevelDeclaration declaration, IPath path)? declaration);

    bool TryGetTopLevelDeclarationForDeclaration(ReadOnlySpan<char> name,
        out (IReadOnlyTopLevelDeclaration declaration, IPath path)? declaration);

    bool TryGetTopLevelDeclarationForDeclaration(ITypeIdentifier name,
        out (IReadOnlyTopLevelDeclaration declaration, IPath path)? declaration, bool assumeAlreadyInModule = false);

    bool IsModuleDependency(IReadOnlySwiftModule swiftModule);

    bool IsModuleDependantOnThisModule(IReadOnlySwiftModule swiftModule);
    
    List<IReadOnlySwiftModule> GetImmediateModuleDependencies();

    List<IReadOnlySwiftModule> ComputeFullModuleDependencies();

    List<IReadOnlySwiftModule> GetImmediateModuleWhichDependOnThisModule();

    List<IReadOnlySwiftModule> ComputeAllModulesWhichDependOnThisModule();
    
    bool IsStandardLibrary { get; }
}
