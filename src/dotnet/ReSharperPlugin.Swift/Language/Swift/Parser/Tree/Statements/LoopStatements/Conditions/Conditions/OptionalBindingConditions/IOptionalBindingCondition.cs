using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Initializers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.Conditions.Conditions.OptionalBindingConditions;

public interface IOptionalBindingCondition :
    IReadOnlyOptionalBindingCondition, ICondition
{
    new IPattern Pattern { get; }
    
    new IInitializerDeclaration? Initializer { get; }

    void ChangePattern(IPattern newPattern);

    void SetInitializer(IInitializerDeclaration? initializer);

    void RemoveInitializer();
}
