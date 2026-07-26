using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.GetterSetterBlocks.KeywordBlocks.Clauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.GetterSetterBlocks.RegularBlocks;

public interface IReadOnlyDiscreteGetterSetterGetterSetterKeywordBlock : IReadOnlyGetterSetterBlock
{
    LeftCurlyBrace GetterSetterClauseStart { get; }
    
    IReadOnlyGetterKeywordClause GetterClause { get; }
    
    IReadOnlySetterKeywordClause? SetterClause { get; }
    
    RightCurlyBrace GetterSetterClauseEnd { get; }

    bool IsGetterFirst();

    bool IsSetterFirst();

    bool CanSwapPositions();
}
