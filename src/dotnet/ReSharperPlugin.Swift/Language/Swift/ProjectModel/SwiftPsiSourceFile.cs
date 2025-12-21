using System;
using System.Collections.Generic;
using JetBrains.Application.Changes;
using JetBrains.DocumentModel;
using JetBrains.Metadata.Reader.API;
using JetBrains.ProjectModel;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.Modules;
using JetBrains.Util;

namespace ReSharperPlugin.Swift.Language.ProjectModel;

public class SwiftPsiSourceFile : IPsiSourceFile
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

    public bool IsValid()
    {
        throw new NotImplementedException();
    }

    public string? GetPersistentID()
    {
        throw new NotImplementedException();
    }

    public IPsiModule PsiModule { get; }
    public IDocument Document { get; }
    public string Name { get; }
    public string DisplayName { get; }
    public ProjectFileType LanguageType { get; }
    public PsiLanguageType PrimaryPsiLanguage { get; }
    public IPsiSourceFileProperties Properties { get; }
    public IModuleReferenceResolveContext ResolveContext { get; }
    public IPsiSourceFileStorage PsiStorage { get; }
    public ModificationStamp? InMemoryModificationStamp { get; }
    public ModificationStamp? ExternalModificationStamp { get; }
    public DateTime LastWriteTimeUtc { get; }
}