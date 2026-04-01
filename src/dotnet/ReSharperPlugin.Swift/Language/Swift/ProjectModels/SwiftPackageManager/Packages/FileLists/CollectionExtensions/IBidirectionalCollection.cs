using System;
using System.Collections.Generic;

namespace SoftOmni.SwiftRd.Language.Swift.ProjectModels.SwiftPackageManager.Packages.FileLists.CollectionExtensions;

public interface IBidirectionalCollection<T> : IList<T>
{
    T Last { get; }

    CollectionDifference<T> Difference<TCollection, TCollectionElement>(TCollection other, Func<TCollectionElement, bool> areEquivalent)
        where TCollection : IBidirectionalCollection<TCollectionElement> where TCollectionElement : T;

    void FormIndex(ref int index);

    T LastWhere(Func<T, bool> predicate);
    
    int LastIndex(Func<T, bool> predicate);
}