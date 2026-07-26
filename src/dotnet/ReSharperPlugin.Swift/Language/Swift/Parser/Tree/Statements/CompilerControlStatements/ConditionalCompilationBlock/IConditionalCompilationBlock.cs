using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.CompilationConditions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.Directives;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.StatementGroups;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock;

public interface IConditionalCompilationBlock : IReadOnlyConditionalCompilationBlock, ICompilerControlStatement,
    IList<ICompilationCondition>
{
    new ICompilationCondition FirstIfCondition { get; }

    void ChangeFirstIfCondition(ICompilationCondition newCondition);

    new IStatementGroup FirstIfStatements { get; }

    void ChangeFirstIfStatements(IStatementGroup newStatements);

    new IEnumerator<(ElseIfDirective elseIfDirective, ICompilationCondition condition, IStatementGroup statements
        )> GetElseIfEnumerator();

    new IStatementGroup GetElseIfStatementsAt(int index);

    new ICompilationCondition GetElseIfConditionAt(int index);

    void AddElseIfCondition(int index, ICompilationCondition condition, IStatementGroup statements);

    void RemoveElseIfCondition(int index);

    void SetElseIfConditionAt(int index, IStatementGroup statements);

    void SetElseIfConditionAt(int index, ICompilationCondition condition);

    new IStatementGroup? FinalElseStatements { get; }

    void SetFinalElseStatements(IStatementGroup newStatements);

    void RemoveFinalElse();

    new IReadOnlyList<ICompilationCondition> Conditions { get; }

    new int Count { get; }

    new IEnumerator<ICompilationCondition> GetEnumerator();

    new ICompilationCondition this[int index] { get; }

    new IReadOnlyList<IStatementGroup> StatementGroups { get; }
}