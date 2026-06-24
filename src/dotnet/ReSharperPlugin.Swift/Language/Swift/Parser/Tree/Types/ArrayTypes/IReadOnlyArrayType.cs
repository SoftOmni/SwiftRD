using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.ArrayTypes;

public interface IReadOnlyArrayType : IReadOnlyType
{
    LeftSquareBracket LeftSquareBracket { get; }
    
    IReadOnlyType InnerType { get; }
    
    RightSquareBracket RightSquareBracket { get; }
    
    int Dimension { get; }
    
    int MinimumDimension { get; }

    void ForInternalUseSetDimension(int dimension);
}
