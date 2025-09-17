using System;
using System.Collections.Generic;
using JetBrains.ProjectModel;
using JetBrains.Util;

namespace ReSharperPlugin.Swift.Language.ProjectModel;

public class SwiftModule : IModule
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

    public void Accept(ProjectVisitor projectVisitor)
    {
        throw new NotImplementedException();
    }

    public ISolution GetSolution()
    {
        throw new NotImplementedException();
    }

    public object GetProperty(Key propertyName)
    {
        throw new NotImplementedException();
    }

    public void SetProperty(Key propertyName, object propertyValue)
    {
        throw new NotImplementedException();
    }

    public bool IsValid()
    {
        throw new NotImplementedException();
    }

    public bool IsValidAndAlive()
    {
        throw new NotImplementedException();
    }

    public string Name { get; }
    public Type? MarshallerType { get; }
    public string Presentation { get; }
}