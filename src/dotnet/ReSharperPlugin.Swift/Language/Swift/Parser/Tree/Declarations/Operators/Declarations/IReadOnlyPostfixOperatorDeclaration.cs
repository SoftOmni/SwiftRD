using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators.Usages;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators.Declarations;

public interface IReadOnlyPostfixOperatorDeclaration : IReadOnlyOperatorDeclaration
{
    Postfix PostfixKeyword { get; }
    
    IReadOnlyOperator Operator { get; }
}