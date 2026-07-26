using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators.Usages;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators.Declarations;

public interface IPrefixOperatorDeclaration : IReadOnlyPrefixOperatorDeclaration, IOperatorDeclaration
{
    new IOperator Operator { get; }

    void ChangeOperator(IOperator newOperator);
}
