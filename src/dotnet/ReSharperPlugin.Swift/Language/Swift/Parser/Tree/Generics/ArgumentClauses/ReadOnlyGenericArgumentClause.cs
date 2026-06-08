using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ArgumentClauses;

public class ReadOnlyGenericArgumentClause : SwiftCompositeNode, IReadOnlyGenericArgumentClause
{
    public LeftAngleBracket LeftAngleBracket { get; }
    
    public IReadOnlyGenericArgumentGroup GenericArgumentGroup { get; }
    
    public RightAngleBracket RightAngleBracket { get; }

    internal ReadOnlyGenericArgumentClause(IEditableBuffer buffer, LeftAngleBracket leftAngleBracket,
        ReadOnlyGenericArgumentGroup genericArgumentGroup, RightAngleBracket rightAngleBracket) 
        : base(buffer, children: [leftAngleBracket, genericArgumentGroup, rightAngleBracket])
    {
        LeftAngleBracket = leftAngleBracket;
        GenericArgumentGroup = genericArgumentGroup;
        RightAngleBracket = rightAngleBracket;
    }

    public int Count => GenericArgumentGroup.Count;

    int IReadOnlyCollection<IType>.Count => GenericArgumentGroup.Count;

    IType IReadOnlyList<IType>.this[int index] => ((IReadOnlyList<IType>)GenericArgumentGroup)[index];

    public new IGenericArgument this[int index] => GenericArgumentGroup[index];

    public IEnumerator<IGenericArgument> GetEnumerator()
    {
        return GenericArgumentGroup.GetEnumerator();
    }

    IEnumerator<IType> IEnumerable<IType>.GetEnumerator()
    {
        return ((IEnumerable<IType>)GenericArgumentGroup).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}