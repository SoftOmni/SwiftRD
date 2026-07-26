using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.CodeBlocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Ifs;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.Conditions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Guard;

public interface IReadOnlyGuardStatement : IReadOnlyBranchStatement
{
    Guard Guard { get; }
    
    IReadOnlyConditionList Conditions { get; }
    
    Else Else { get; }
    
    IReadOnlyCodeBlock CodeBlock { get; }
}
