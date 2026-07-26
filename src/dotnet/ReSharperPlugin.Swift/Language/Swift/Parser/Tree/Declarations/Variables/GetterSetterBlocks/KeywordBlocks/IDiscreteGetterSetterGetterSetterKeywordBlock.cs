using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.GetterSetterBlocks.RegularBlocks.Clauses;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.GetterSetterBlocks.RegularBlocks;

public interface IDiscreteGetterSetterGetterSetterKeywordBlock : 
    IReadOnlyDiscreteGetterSetterGetterSetterBlock,
    IGetterSetterBlock
{
    new IGetterClause GetterClause { get; }
    
    new ISetterClause? SetterClause { get; }

    void SwapPositions();

    void ChangeGetterClause(IGetterClause newGetterClause);

    void SetSetterClauseTo(ISetterClause? setterClause);

    void RemoveSetterClause();
}
