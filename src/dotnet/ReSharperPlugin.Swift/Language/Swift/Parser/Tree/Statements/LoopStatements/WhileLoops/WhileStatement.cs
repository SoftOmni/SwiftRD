using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.WhileLoops;

public class WhileStatement : SwiftCompositeNode, IWhileStatement
{
    public While? While { get; internal set; }
    
    public IReadOnlyConditionList? ConditionList { get; internal set; }
    
    
}