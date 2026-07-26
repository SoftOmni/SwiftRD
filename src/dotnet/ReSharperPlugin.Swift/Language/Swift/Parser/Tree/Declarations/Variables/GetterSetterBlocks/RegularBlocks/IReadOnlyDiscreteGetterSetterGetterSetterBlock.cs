using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.GetterSetterBlocks.RegularBlocks.Clauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.GetterSetterBlocks.RegularBlocks;

public interface IReadOnlyDiscreteGetterSetterGetterSetterBlock : IReadOnlyGetterSetterBlock
{
    LeftCurlyBrace GetterSetterClauseStart { get; }
    
    IReadOnlyGetterClause GetterClause { get; }
    
    IReadOnlySetterClause? SetterClause { get; }
    
    RightCurlyBrace GetterSetterClauseEnd { get; }

    bool IsGetterFirst();

    bool IsSetterFirst();

    bool CanSwapPositions();
}
