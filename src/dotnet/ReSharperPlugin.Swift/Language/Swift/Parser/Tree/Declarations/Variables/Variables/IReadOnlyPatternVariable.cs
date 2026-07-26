using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Constants;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables;

public interface IReadOnlyPatternVariable : IReadOnlyVariable
{
    IReadOnlyPatternInitializerList PatternInitializerList { get; }
}
