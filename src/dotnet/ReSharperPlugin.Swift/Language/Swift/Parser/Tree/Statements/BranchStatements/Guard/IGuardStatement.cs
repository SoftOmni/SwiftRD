using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.CodeBlocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.Conditions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Guard;

public interface IGuardStatement : IReadOnlyGuardStatement, IBranchStatement
{
    new IConditionList Conditions { get; }

    void ChangeConditionsList(IConditionList newConditionList);
    
    new ICodeBlock CodeBlock { get; }

    void ChanceCodeBlock(ICodeBlock newCodeBlock);
}
