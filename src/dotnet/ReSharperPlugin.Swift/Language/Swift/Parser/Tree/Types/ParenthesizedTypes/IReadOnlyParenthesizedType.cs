using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.ParenthesizedTypes;

public interface IReadOnlyParenthesizedType : IReadOnlyType
{
    LeftParenthesis LeftParenthesis { get; }
    
    IReadOnlyType Type { get; }
    
    RightParenthesis RightParenthesis { get; }
}
