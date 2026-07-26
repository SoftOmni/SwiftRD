using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.GetterSetterBlocks.KeywordBlocks.Clauses;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.GetterSetterBlocks.RegularBlocks;

public interface IDiscreteGetterSetterGetterSetterKeywordBlock : 
    IReadOnlyDiscreteGetterSetterGetterSetterKeywordBlock,
    IGetterSetterBlock
{
    new IGetterKeywordClause GetterClause { get; }
    
    new ISetterKeywordClause? SetterClause { get; }

    void SwapPositions();

    void ChangeGetterClause(IGetterKeywordClause newGetterClause);

    void SetSetterClauseTo(ISetterKeywordClause? setterClause);

    void RemoveSetterClause();
}
