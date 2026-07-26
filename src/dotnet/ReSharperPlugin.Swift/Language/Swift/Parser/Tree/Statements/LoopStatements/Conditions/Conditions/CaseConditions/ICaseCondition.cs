using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Initializers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.Conditions.Conditions.CaseConditions;

public interface ICaseCondition : IReadOnlyCaseCondition
{
    new IPattern Pattern { get; }
    
    new IInitializerDeclaration Initializer { get; }

    void ChangePattern(IPattern newPattern);

    void ChangeInitializer(IInitializerDeclaration newInitializer);
}
