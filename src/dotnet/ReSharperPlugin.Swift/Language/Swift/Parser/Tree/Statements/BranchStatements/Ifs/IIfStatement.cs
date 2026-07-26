using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.CodeBlocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LabeledStatements;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.Conditions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Ifs;

public interface IIfStatement : IReadOnlyIfStatement, IBranchStatement, IList<IConditionList>,
    ILabelableStatement
{
    new IConditionList FirstIfCondition { get; }

    void ChangeFirstIfCondition(IConditionList newCondition);
    
    new ICodeBlock FirstIfCodeBlock { get; }

    void ChangeFirstIfCodeBlock(ICodeBlock newCodeBlock);

    new IEnumerator<(Else @else, If @if, IConditionList condition, ICodeBlock codeBlock)> GetElseIfEnumerator();

    new ICodeBlock GetElseIfCodeBlockAt(int index);
    
    new IConditionList GetElseIfConditionAt(int index);

    void AddElseIfCondition(int index, IConditionList condition, ICodeBlock codeBlock);

    void RemoveElseIfCondition(int index);

    void SetElseIfConditionAt(int index, ICodeBlock codeBlock);
    
    void SetElseIfConditionAt(int index, IConditionList condition);
    
    new ICodeBlock? FinalElseCodeBlock { get; }

    void SetFinalElseCodeBlock(ICodeBlock newCodeBlock);

    void RemoveFinalElse();
    
    new IReadOnlyList<IConditionList> Conditions { get; }
    
    new int Count { get; }

    new IEnumerator<IConditionList> GetEnumerator();
    
    new IConditionList this[int index] { get; }
    
    new IReadOnlyList<ICodeBlock> CodeBlocks { get; }
}
