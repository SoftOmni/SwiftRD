using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.OptionalTypes;

public interface IReadOnlyOptionalType : IReadOnlyType
{
    IReadOnlyType Type { get; }
    
    QuestionMark QuestionMark { get; }
}
