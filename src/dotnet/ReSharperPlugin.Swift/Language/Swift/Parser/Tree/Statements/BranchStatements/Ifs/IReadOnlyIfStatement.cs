using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.CodeBlocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LabeledStatements;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.Conditions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Ifs;

public interface IReadOnlyIfStatement : IReadOnlyBranchStatement, IReadOnlyList<IReadOnlyConditionList>,
    IReadOnlyLabelableStatement
{
    If If { get; }
    
    IReadOnlyConditionList FirstIfCondition { get; }

    IReadOnlyCodeBlock FirstIfCodeBlock { get; }

    IEnumerator<(Else @else, If @if, IReadOnlyConditionList condition, IReadOnlyCodeBlock codeBlock)> GetElseIfEnumerator();

    IReadOnlyCodeBlock GetElseIfCodeBlockAt(int index);
    
    IReadOnlyConditionList GetElseIfConditionAt(int index);
    
    Else? FinalElse { get; }

    IReadOnlyConditionList? FinalElseCondition { get; }
    
    IReadOnlyCodeBlock? FinalElseCodeBlock { get; }

    IReadOnlyList<IReadOnlyConditionList> Conditions { get; }
    
    IReadOnlyList<IReadOnlyCodeBlock> CodeBlocks { get; }
}
