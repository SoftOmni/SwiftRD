using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.ArrayTypes;

public class ArrayType : SwiftCompositeNode, IArrayType
{
    public LeftSquareBracket LeftSquareBracket { get; }

    public IType InnerType { get; internal set; }

    public RightSquareBracket RightSquareBracket { get; }

    internal ArrayType(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        LeftSquareBracket leftSquareBracket, IType innerType, RightSquareBracket rightSquareBracket)
        : base(buffer, children)
    {
        LeftSquareBracket = leftSquareBracket;
        InnerType = innerType;
        RightSquareBracket = rightSquareBracket;

        ActualType = GenerateArrayUnderlyingType();
        Dimension = ComputeDimension();
    }

    IReadOnlyType IReadOnlyArrayType.InnerType => InnerType;
    
    public IReadOnlyDeclaration? Declaration => ActualType.Declaration;

    public IReadOnlyType ActualType { get; }

    public string TypeSignature => $"Array<{InnerType.TypeSignature}>";

    public IReadOnlyType? SuperType => ActualType.SuperType;

    public IReadOnlyList<IReadOnlyList<IReadOnlyType>> SubTypeChains => ActualType.SubTypeChains;

    public IReadOnlySet<IReadOnlyType> SubTypes => ActualType.SubTypes;

    public IReadOnlySet<string> SubTypeNames => ActualType.SubTypeNames;

    public bool IsFromStandardLibrary => ActualType.IsFromStandardLibrary;


    public int Dimension { get; internal set; }

    public int MinimumDimension { get; internal set; } = -1;

    public int Size => ActualType.Size;

    public void ChangeInnerType(IType newInnerType)
    {
        InnerType.DetachFromParent();

        Dimension = ComputeDimension();
        // TODO: Remember to update usages
    }

    public void IncrementDimension()
    {
        IncrementDimensionBy(1);
    }

    public void IncrementDimensionBy(int increment)
    {
        throw new NotImplementedException();
    }

    public bool DecrementDimension()
    {
        return DecrementDimensionBy(1);
    }

    public void DecrementDimensionToMinimum()
    {
        throw new NotImplementedException();
    }

    public bool DecrementDimensionBy(int decrement)
    {
        throw new NotImplementedException();
    }

    public void ForInternalUseSetDimension(int dimension)
    {
        throw new NotImplementedException();
    }

    private IReadOnlyType GenerateArrayUnderlyingType()
    {
        throw new NotImplementedException();
    }

    private int ComputeDimension()
    {
        if (InnerType is not IArrayType arrayType)
        {
            return 1;
        }

        return 1 + arrayType.Dimension;
    }

}
