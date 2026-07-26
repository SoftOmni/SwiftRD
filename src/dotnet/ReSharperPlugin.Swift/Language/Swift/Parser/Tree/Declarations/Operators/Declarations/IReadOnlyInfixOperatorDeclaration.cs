using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators.Usages;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators.Declarations;

public interface IReadOnlyInfixOperatorDeclaration : IReadOnlyOperatorDeclaration
{
    Infix InfixKeyword { get; }

    IReadOnlyOperator Operator { get; }
    
    IReadOnlyInfixOperatorGroup? InfixOperatorGroup { get; }
}
