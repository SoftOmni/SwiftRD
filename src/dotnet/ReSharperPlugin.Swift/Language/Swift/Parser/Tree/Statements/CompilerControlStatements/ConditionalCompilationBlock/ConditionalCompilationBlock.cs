using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.CompilationConditions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.Directives;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.StatementGroups;

// ReSharper disable UseIndexFromEndExpression

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock;

public class ConditionalCompilationBlock : SwiftCompositeNode, IConditionalCompilationBlock
{
    public IfDirective If { get; }

    private readonly List<ICompilationCondition> _conditions;

    private readonly List<IStatementGroup> _statements;

    private readonly List<ElseIfDirective> _elseIfDirectives;

    public EndIfDirective EndIf { get; }

    public ElseDirective? FinalElse { get; }

    internal ConditionalCompilationBlock(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IfDirective @if, ICompilationCondition ifCondition, List<IStatementGroup> statements, EndIfDirective endIf)
        : base(buffer, children)
    {
        If = @if;
        _conditions = [ifCondition];
        _elseIfDirectives = [];

        _statements = statements;
        EndIf = endIf;
    }

    internal ConditionalCompilationBlock(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IfDirective @if, List<ICompilationCondition> conditions, ElseDirective finalElse, List<IStatementGroup> statements,
        EndIfDirective endIf)
        : base(buffer, children)
    {
        If = @if;
        _conditions = conditions;
        FinalElse = finalElse;
        _elseIfDirectives = [];

        _statements = statements;
        EndIf = endIf;
    }

    internal ConditionalCompilationBlock(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IfDirective @if, List<ElseIfDirective> elseIfDirectives, List<ICompilationCondition> conditions, 
        List<IStatementGroup> statements, EndIfDirective endIf)
        : base(buffer, children)
    {
        If = @if;
        _conditions = conditions;
        FinalElse = null;
        _elseIfDirectives = elseIfDirectives;

        _statements = statements;
        EndIf = endIf;
    }

    internal ConditionalCompilationBlock(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IfDirective @if, List<ElseIfDirective> elseIfDirectives, List<ICompilationCondition> conditions, ElseDirective finalElse,
        List<IStatementGroup> statements, EndIfDirective endIf)
        : base(buffer, children)
    {
        If = @if;
        _conditions = conditions;
        FinalElse = finalElse;
        _elseIfDirectives = elseIfDirectives;

        _statements = statements;
        EndIf = endIf;
    }

    public IStatementGroup FirstIfStatements => _statements[0];

    IReadOnlyStatementGroup IReadOnlyConditionalCompilationBlock.FirstIfStatements => FirstIfStatements;

    public ICompilationCondition FirstIfCondition => _conditions[0];

    IReadOnlyCompilationCondition IReadOnlyConditionalCompilationBlock.FirstIfCondition => FirstIfCondition;

    public IReadOnlyList<ICompilationCondition> Conditions => _conditions;

    IReadOnlyList<IReadOnlyCompilationCondition> IReadOnlyConditionalCompilationBlock.Conditions => Conditions;

    public IReadOnlyCompilationCondition? FinalElseCondition => FinalElse is null ? null : _conditions[_conditions.Count - 1];

    public IStatementGroup? FinalElseStatements => FinalElse is null ? null : _statements[_conditions.Count - 1];

    IReadOnlyStatementGroup? IReadOnlyConditionalCompilationBlock.FinalElseStatements => FinalElseStatements;

    public IReadOnlyList<IStatementGroup> StatementGroups => _statements;

    IReadOnlyList<IReadOnlyStatementGroup> IReadOnlyConditionalCompilationBlock.StatementGroups => StatementGroups;

    public int Count => _conditions.Count;

    public bool IsReadOnly => false;

    public new ICompilationCondition this[int index]
    {
        get => _conditions[index];
        set
        {
            if (index == 0)
            {
                ChangeFirstIfCondition(value);
            }
            else
            {
                SetElseIfConditionAt(index, value);
            }
        }
    }

    IReadOnlyCompilationCondition IReadOnlyList<IReadOnlyCompilationCondition>.this[int index]
        => _conditions[index];

    public IEnumerator<ICompilationCondition> GetEnumerator()
    {
        return _conditions.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    IEnumerator<IReadOnlyCompilationCondition> IEnumerable<IReadOnlyCompilationCondition>.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IStatementGroup GetElseIfStatementsAt(int index)
    {
        return _statements[index + 1];
    }

    IReadOnlyStatementGroup IReadOnlyConditionalCompilationBlock.GetElseIfStatementsAt(int index)
    {
        return GetElseIfStatementsAt(index);
    }

    public ICompilationCondition GetElseIfConditionAt(int index)
    {
        return _conditions[index + 1];
    }

    IReadOnlyCompilationCondition IReadOnlyConditionalCompilationBlock.GetElseIfConditionAt(int index)
    {
        return GetElseIfConditionAt(index);
    }

    public void SetElseIfConditionAt(int index, IStatementGroup statements)
    {
        throw new NotImplementedException();
    }

    public void SetElseIfConditionAt(int index, ICompilationCondition condition)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<(ElseIfDirective elseIfDirective, ICompilationCondition condition, IStatementGroup statements)> GetElseIfEnumerator()
    {
        return new ElseIfEnumerator(this);
    }

    IEnumerator<(ElseIfDirective elseIfDirective, IReadOnlyCompilationCondition condition, IReadOnlyStatementGroup statements)>
        IReadOnlyConditionalCompilationBlock.GetElseIfEnumerator()
    {
        return new ElseIfEnumerator(this);
    }

    public bool Contains(ICompilationCondition item)
    {
        return _conditions.Contains(item);
    }

    public int IndexOf(ICompilationCondition item)
    {
        return _conditions.IndexOf(item);
    }

    public void CopyTo(ICompilationCondition[] array, int arrayIndex)
    {
        _conditions.CopyTo(array, arrayIndex);
    }

    public void ChangeFirstIfCondition(ICompilationCondition newCondition)
    {
        throw new NotImplementedException();
    }

    public void ChangeFirstIfStatements(IStatementGroup newStatements)
    {
        throw new NotImplementedException();
    }

    public void AddElseIfCondition(int index, ICompilationCondition condition, IStatementGroup statements)
    {
        throw new NotImplementedException();
    }

    public void RemoveElseIfCondition(int index)
    {
        throw new NotImplementedException();
    }

    public void SetFinalElseStatements(IStatementGroup newStatements)
    {
        throw new NotImplementedException();
    }

    public void RemoveFinalElse()
    {
        throw new NotImplementedException();
    }

    public void Add(ICompilationCondition item)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Remove(ICompilationCondition item)
    {
        throw new NotImplementedException();
    }

    public void Insert(int index, ICompilationCondition item)
    {
        throw new NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new NotImplementedException();
    }
    
    

    public struct ElseIfEnumerator(ConditionalCompilationBlock conditionalCompilationBlock)
        : IEnumerator<(ElseIfDirective elseIfDirective, ICompilationCondition condition, IStatementGroup statements)>,
            IEnumerator<(ElseIfDirective elseIfDirective, IReadOnlyCompilationCondition condition, IReadOnlyStatementGroup statements)>
    {
        private int _index = 0;

        public bool MoveNext()
        {
            if (_index + 1 >= conditionalCompilationBlock._conditions.Count)
            {
                return false;
            }

            _index++;
            return true;
        }


        public (ElseIfDirective elseIfDirective, ICompilationCondition condition, IStatementGroup statements) Current => GetCurrent();

        (ElseIfDirective elseIfDirective, IReadOnlyCompilationCondition condition, IReadOnlyStatementGroup statements)
            IEnumerator<(ElseIfDirective elseIfDirective, IReadOnlyCompilationCondition condition, IReadOnlyStatementGroup statements)>.Current => Current;

        object IEnumerator.Current => Current;

        private (ElseIfDirective elseIfDirective, ICompilationCondition condition, IStatementGroup statements) GetCurrent()
        {
            ICompilationCondition condition = conditionalCompilationBlock._conditions[_index + 1];
            ElseIfDirective elseIfDirective = conditionalCompilationBlock._elseIfDirectives[_index];
            IStatementGroup statements = conditionalCompilationBlock._statements[_index + 1];

            return (elseIfDirective, condition, statements);
        }

        public void Reset()
        {
            _index = -1;
        }

        public void Dispose()
        {
            // Nothing to do
        }
    }
}