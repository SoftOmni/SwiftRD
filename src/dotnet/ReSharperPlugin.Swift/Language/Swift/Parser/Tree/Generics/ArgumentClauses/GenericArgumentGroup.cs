using System;
using System.Collections.Generic;
using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;
using SoftOmni.SwiftRd.Technology;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ArgumentClauses;

public class GenericArgumentGroup : ReadOnlyGenericArgumentGroup, IGenericArgumentGroup
{
    public IGenericArgumentClause? EditableGenericArgumentClause { get; private set; }

    internal GenericArgumentGroup(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        List<IGenericArgument> genericArguments, List<IType> genericArgumentsType, List<Comma> commas) 
        : base(buffer, children, genericArguments, genericArgumentsType, commas)
    { }
    
    protected override void UpdateParentRelatedNodeConfiguration()
    {
        if (Parent is IGenericArgumentClause genericArgumentClause)
        {
            EditableGenericArgumentClause = genericArgumentClause;
        }
        
        base.UpdateParentRelatedNodeConfiguration();
    }

    public void Add(IType item)
    {
        throw new NotImplementedException();
    }

    public void Add(IGenericArgument item)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        if (EditableGenericArgumentClause is IncompleteGenericArgumentClause incompleteGenericArgumentClause)
        {
            ClearChildren(0, NumberOfChildren);
            DetachFromParent();

            incompleteGenericArgumentClause.GenericArgumentGroup = null;
            return;
        }

        if (Parent is null || GenericArgumentClause is null)
        {
            ClearChildren(0, NumberOfChildren);
            DetachFromParent();
            return;
        }

        SwiftCompositeNode? genericArgumentClauseParent = GenericArgumentClause.GetParent();
        if (genericArgumentClauseParent is null)
        {
            ClearChildren(0, NumberOfChildren);
            return;
        }

        int clauseParentIndex = GenericArgumentClause.ParentIndex;
        GenericArgumentClause.DetachFromParent();

        IEditableBuffer incompleteGenericArgumentClauseBuffer =
            new EditableBuffer(LeftAngleBracket.Value + RightAngleBracket.Value);

        LeftAngleBracket leftAngleBracket = new(
                new SubEditableBuffer(incompleteGenericArgumentClauseBuffer, 0, LeftAngleBracket.Value.Length)
            );

        RightAngleBracket rightAngleBracket = new(new SubEditableBuffer(incompleteGenericArgumentClauseBuffer,
            LeftAngleBracket.Value.Length, RightAngleBracket.Value.Length));

        IncompleteGenericArgumentClause newIncompleteGenericArgumentClause = new(incompleteGenericArgumentClauseBuffer,
            IncompleteGenericArgumentClause.MissingArgumentsErrorMessage, leftAngleBracket, null,
            rightAngleBracket);

        genericArgumentClauseParent.InsertChild(clauseParentIndex, newIncompleteGenericArgumentClause);
    }

    public bool Contains(IType item)
    {
        return GenericArgumentTypesUnderlying.Contains(item);
    }

    public bool Contains(IGenericArgument item)
    {
        throw new NotImplementedException();
    }

    public void CopyTo(IType[] array, int arrayIndex)
    {
        GenericArgumentTypesUnderlying.CopyTo(array, arrayIndex);
    }

    public void CopyTo(IGenericArgument[] array, int arrayIndex)
    {
        throw new NotImplementedException();
    }

    public bool Remove(IType item)
    {
        throw new NotImplementedException();
    }

    public bool Remove(IGenericArgument item)
    {
        throw new NotImplementedException();
    }

    public bool IsReadOnly => false;

    public int IndexOf(IType item)
    {
        return GenericArgumentTypesUnderlying.IndexOf(item);
    }

    public int IndexOf(IGenericArgument item)
    {
        throw new NotImplementedException();
    }

    public void Insert(int index, IType item)
    {
        throw new NotImplementedException();
    }

    public void Insert(int index, IGenericArgument item)
    {
        throw new NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new NotImplementedException();
    }

    void IList<IType>.RemoveAt(int index)
    {
        throw new NotImplementedException();
    }

    IType IList<IType>.this[int index]
    {
        get => GenericArgumentTypes[index];
        set => throw new NotImplementedException();
    }

    public new IGenericArgument this[int index]
    {
        get => GenericArguments[index];
        set => throw new NotImplementedException();
    }
}