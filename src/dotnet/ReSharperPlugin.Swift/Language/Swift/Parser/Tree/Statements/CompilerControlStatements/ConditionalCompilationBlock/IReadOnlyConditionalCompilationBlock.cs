using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.CompilationConditions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.Directives;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.StatementGroups;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock;

public interface IReadOnlyConditionalCompilationBlock : IReadOnlyCompilerControlStatement, IReadOnlyList<IReadOnlyCompilationCondition>
{
    IfDirective If { get; }
    
    IReadOnlyCompilationCondition FirstIfCondition { get; }

    IReadOnlyStatementGroup FirstIfStatements { get; }

    IEnumerator<(ElseIfDirective elseIfDirective, IReadOnlyCompilationCondition condition, IReadOnlyStatementGroup statements)> GetElseIfEnumerator();

    IReadOnlyStatementGroup GetElseIfStatementsAt(int index);
    
    IReadOnlyCompilationCondition GetElseIfConditionAt(int index);
    
    ElseDirective? FinalElse { get; }

    IReadOnlyCompilationCondition? FinalElseCondition { get; }
    
    IReadOnlyStatementGroup? FinalElseStatements { get; }

    IReadOnlyList<IReadOnlyCompilationCondition> Conditions { get; }
    
    IReadOnlyList<IReadOnlyStatementGroup> StatementGroups { get; }
    
    EndIfDirective EndIf { get; }
}

