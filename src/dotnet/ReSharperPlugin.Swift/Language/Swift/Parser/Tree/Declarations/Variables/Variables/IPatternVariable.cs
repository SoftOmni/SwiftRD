using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Constants;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables;

public interface IPatternVariable : IReadOnlyPatternVariable, IVariable
{
    new IPatternInitializerList PatternInitializerList { get; }

    void ChangePatternInitializerList(IPatternInitializerList newPatternInitializerList);
}
