using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ArgumentClauses;

public class ReadOnlyGenericArgumentGroup : SwiftCompositeNode, IReadOnlyGenericArgumentGroup
{
    protected readonly List<IGenericArgument> GenericArgumentsUnderlying;
    
    protected readonly List<IType> GenericArgumentTypesUnderlying;

    public IReadOnlyGenericArgumentClause? GenericArgumentClause { get; private set; }

    protected readonly List<Comma> CommasUnderlying;

    internal ReadOnlyGenericArgumentGroup(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        List<IGenericArgument> genericArguments, List<IType> genericArgumentTypes, List<Comma> commas)
        : base(buffer, children)
    {
        GenericArgumentsUnderlying = genericArguments;
        GenericArgumentTypesUnderlying = genericArgumentTypes;
        CommasUnderlying = commas;
    }

    public IReadOnlyList<IType> GenericArgumentTypes => GenericArgumentTypesUnderlying;

    public IReadOnlyList<IGenericArgument> GenericArguments => GenericArgumentsUnderlying;

    public IReadOnlyList<Comma> Commas => CommasUnderlying;

    protected override void UpdateParentRelatedNodeConfiguration()
    {
        if (Parent is IReadOnlyGenericArgumentClause genericArgumentClause)
        {
            GenericArgumentClause = genericArgumentClause;
        }
    }

    IEnumerator<IType> IEnumerable<IType>.GetEnumerator()
    {
        return GenericArgumentTypes.GetEnumerator();
    }

    public IEnumerator<IGenericArgument> GetEnumerator()
    {
        return GenericArguments.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public int Count => GenericArgumentTypesUnderlying.Count;

    public new IGenericArgument this[int index] => GenericArguments[index];
    
    IType IReadOnlyList<IType>.this[int index] => GenericArgumentTypes[index];
}