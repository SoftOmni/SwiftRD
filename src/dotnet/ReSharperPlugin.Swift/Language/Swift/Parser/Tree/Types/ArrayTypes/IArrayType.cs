namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.ArrayTypes;

public interface IArrayType : IReadOnlyArrayType, IType
{
    new IType InnerType { get; }
    
    void ChangeInnerType(IType newInnerType);
    
    void IncrementDimension();

    void IncrementDimensionBy(int increment);
    
    bool DecrementDimension();

    void DecrementDimensionToMinimum();

    bool DecrementDimensionBy(int decrement);
}
