using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators.Usages;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators.Declarations;

public interface IInfixOperatorDeclaration : IReadOnlyInfixOperatorDeclaration, IOperatorDeclaration
{
    new IOperator Operator { get; }
    
    new IInfixOperatorGroup? InfixOperatorGroup { get; }

    void ChangeOperator(IOperator newOperator);

    void SetInfixOperatorGroup(IInfixOperatorGroup? newInfixOperatorGroup);

    void RemoveInfixOperatorGroup();
}
