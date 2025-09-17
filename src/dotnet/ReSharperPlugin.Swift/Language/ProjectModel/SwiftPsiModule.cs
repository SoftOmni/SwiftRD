using System;
using System.Collections.Generic;
using JetBrains.Metadata.Reader.API;
using JetBrains.ProjectModel;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.Modules;
using JetBrains.Util;
using JetBrains.Util.Dotnet.TargetFrameworkIds;
using ReSharperPlugin.Swift.Language.File;

namespace ReSharperPlugin.Swift.Language.ProjectModel;

public class SwiftPsiModule : IPsiModule
{
    public T? GetData<T>(Key<T> key) where T : class
    {
        throw new NotImplementedException();
    }

    public void PutData<T>(Key<T> key, T? value) where T : class
    {
        throw new NotImplementedException();
    }

    public T GetOrCreateDataUnderLock<T>(Key<T> key, Func<T> factory) where T : class
    {
        throw new NotImplementedException();
    }

    public T GetOrCreateDataUnderLock<T, TState>(Key<T> key, TState state, Func<TState, T> factory) where T : class
    {
        throw new NotImplementedException();
    }

    public IEnumerable<KeyValuePair<object, object>> EnumerateData()
    {
        throw new NotImplementedException();
    }

    public IPsiServices GetPsiServices()
    {
        throw new NotImplementedException();
    }

    public ISolution GetSolution()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<IPsiModuleReference> GetReferences(IModuleReferenceResolveContext? moduleReferenceResolveContext)
    {
        throw new NotImplementedException();
    }

    public ICollection<PreProcessingDirective> GetAllDefines()
    {
        throw new NotImplementedException();
    }

    public bool IsValid()
    {
        throw new NotImplementedException();
    }

    public string GetPersistentID()
    {
        throw new NotImplementedException();
    }

    public string Name { get; }
    
    public string DisplayName { get; }
    
    public TargetFrameworkId TargetFrameworkId { get; }

    public PsiLanguageType PsiLanguage => SwiftLanguage.Instance!;
    
    public ProjectFileType ProjectFileType => SwiftProjectFileType.Instance;
    
    public IModule? ContainingProjectModule { get; }
    
    public IEnumerable<IPsiSourceFile> SourceFiles { get; }
}