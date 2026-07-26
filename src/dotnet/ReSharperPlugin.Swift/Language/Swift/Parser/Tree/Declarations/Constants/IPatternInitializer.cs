using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Constants;

public interface IPatternInitializer : IReadOnlyPatternInitializer
{
    new IPattern Pattern { get; }
    
    new IInitializer? Initializer { get; }

    void ChangePattern(IPattern newPattern);

    void SetInitializerTo(IInitializer? initializer);

    void RemoveInitializer();
}
