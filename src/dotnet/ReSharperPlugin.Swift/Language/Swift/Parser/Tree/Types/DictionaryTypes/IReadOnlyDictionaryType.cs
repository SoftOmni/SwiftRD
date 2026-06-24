using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.DictionaryTypes;

public interface IReadOnlyDictionaryType : IReadOnlyType
{
    LeftSquareBracket LeftSquareBracket { get; }
    
    IReadOnlyType KeyType { get; }
    
    Colon Colon { get; }
    
    IReadOnlyType ValueType { get; }
    
    RightSquareBracket RightSquareBracket { get; }
}
