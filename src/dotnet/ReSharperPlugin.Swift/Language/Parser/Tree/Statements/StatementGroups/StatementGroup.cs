using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Technology.RelativePositions;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Statements.StatementGroups;

public class StatementGroup : SwiftInternalNode, IList<IStatement>
{
    private readonly List<IStatement> _statements = [];

    // TODO: write the full API for statement group and then decide on the indexes data structure
    private Dictionary<IStatement, int> _statementsIndexes = [];

    public StatementGroup(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    {
        SetupChildren();
    }

    public StatementGroup(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    {
        SetupChildren();
    }

    public StatementGroup(SwiftInternalNode parent, int parentIndex, int parentTextIndex, IEditableBuffer buffer,
        List<ISwiftNode> nodes)
        : base(parent, parentIndex, parentTextIndex, buffer, nodes)
    {
        SetupChildren();
    }

    public StatementGroup(SwiftInternalNode parent, int parentIndex, int parentTextIndex, IEditableBuffer buffer,
        IEnumerable<ISwiftNode> nodes)
        : base(parent, parentIndex, parentTextIndex, buffer, nodes)
    {
        SetupChildren();
    }

    private void SetupChildren()
    {
        // TODO: once data structure around fast index lookup of statements figured out, update this piece of code and all other relevant location
        foreach (ISwiftNode child in Children)
        {
            if (child is IStatement statement)
            {
                _statements.Add(statement);
            }
        }
    }

    public IReadOnlyList<IStatement> Statements => _statements;

    public IEnumerator<IStatement> GetEnumerator()
    {
        return _statements.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void InsertStatement(int index, IStatement statement)
    {
        CheckStatementIndexInclusive(index);
        InsertStatementCore(index, statement);
    }

    public void InsertStatements(int index, IEnumerable<IStatement> statements)
    {
        CheckStatementIndexInclusive(index);

        int childIndexToInsertAt = index == _statements.Count ? Children.Count : _statements[index].ParentIndex;
        AttachChildren(childIndexToInsertAt, statements,
            child =>
            {
                IStatement statement = (child as IStatement)!;
                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index);
            });
    }

    public void InsertStatements(int index, IEnumerable<IStatement> statements, int startIndexInStatementsForInsertion)
    {
        CheckStatementIndexInclusive(index);

        int childIndexToInsertAt = index == _statements.Count ? Children.Count : _statements[index].ParentIndex;
        AttachChildren(childIndexToInsertAt, statements, startIndexInStatementsForInsertion,
            child =>
            {
                IStatement statement = (child as IStatement)!;
                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index);
            });
    }

    public void InsertStatements(int index, IEnumerable<IStatement> statements, int startIndexInStatementsForInsertion,
        int endIndexInStatementsForInsertion)
    {
        CheckStatementIndexInclusive(index);

        int childIndexToInsertAt = index == _statements.Count ? Children.Count : _statements[index].ParentIndex;
        AttachChildren(childIndexToInsertAt, statements, startIndexInStatementsForInsertion,
            endIndexInStatementsForInsertion,
            child =>
            {
                IStatement statement = (child as IStatement)!;
                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index);
            });
    }

    public void InsertStatements(int index, IList<IStatement> statements)
    {
        CheckStatementIndexInclusive(index);

        int childIndexToInsertAt = index == _statements.Count ? Children.Count : _statements[index].ParentIndex;
        AttachChildren(childIndexToInsertAt, statements,
            child =>
            {
                IStatement statement = (child as IStatement)!;
                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index);
            });
    }

    public void InsertStatements(int index, IList<IStatement> statements, int startIndexInStatementsForInsertion)
    {
        CheckStatementIndexInclusive(index);

        int childIndexToInsertAt = index == _statements.Count ? Children.Count : _statements[index].ParentIndex;
        AttachChildren(childIndexToInsertAt, statements, startIndexInStatementsForInsertion,
            child =>
            {
                IStatement statement = (child as IStatement)!;
                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index);
            });
    }

    public void InsertStatements(int index, IList<IStatement> statements, int startIndexInStatementsForInsertion,
        int endIndexInStatementsForInsertion)
    {
        CheckStatementIndexInclusive(index);

        int childIndexToInsertAt = index == _statements.Count ? Children.Count : _statements[index].ParentIndex;
        AttachChildren(childIndexToInsertAt, statements, startIndexInStatementsForInsertion,
            endIndexInStatementsForInsertion,
            child =>
            {
                IStatement statement = (child as IStatement)!;
                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index);
            });
    }

    public void InsertStatements(int index, List<IStatement> statements)
    {
        CheckStatementIndexInclusive(index);

        int childIndexToInsertAt = index == _statements.Count ? Children.Count : _statements[index].ParentIndex;
        AttachChildren(childIndexToInsertAt, statements,
            child =>
            {
                IStatement statement = (child as IStatement)!;
                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index);
            });
    }

    public void InsertStatements(int index, List<IStatement> statements, int startIndexInStatementsForInsertion)
    {
        CheckStatementIndexInclusive(index);

        int childIndexToInsertAt = index == _statements.Count ? Children.Count : _statements[index].ParentIndex;
        AttachChildren(childIndexToInsertAt, statements, startIndexInStatementsForInsertion,
            child =>
            {
                IStatement statement = (child as IStatement)!;
                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index);
            });
    }

    public void InsertStatements(int index, List<IStatement> statements, int startIndexInStatementsForInsertion,
        int endIndexInStatementsForInsertion)
    {
        CheckStatementIndexInclusive(index);

        int childIndexToInsertAt = index == _statements.Count ? Children.Count : _statements[index].ParentIndex;
        AttachChildren(childIndexToInsertAt, statements, startIndexInStatementsForInsertion,
            endIndexInStatementsForInsertion,
            child =>
            {
                IStatement statement = (child as IStatement)!;
                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index);
            });
    }

    public void InsertStatements(int index, StatementGroup statements)
    {
        CheckStatementIndexInclusive(index);

        int childIndexToInsertAt = index == _statements.Count ? Children.Count : _statements[index].ParentIndex;
        AttachChildren(childIndexToInsertAt, statements,
            child =>
            {
                IStatement statement = (child as IStatement)!;
                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index);
            });
    }

    public void InsertStatements(int index, StatementGroup statements, int startIndexInStatementsForInsertion)
    {
        CheckStatementIndexInclusive(index);

        int childIndexToInsertAt = index == _statements.Count ? Children.Count : _statements[index].ParentIndex;
        AttachChildren(childIndexToInsertAt, statements, startIndexInStatementsForInsertion,
            child =>
            {
                IStatement statement = (child as IStatement)!;
                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index);
            });
    }

    public void InsertStatements(int index, StatementGroup statements, int startIndexInStatementsForInsertion,
        int endIndexInStatementsForInsertion)
    {
        CheckStatementIndexInclusive(index);

        int childIndexToInsertAt = index == _statements.Count ? Children.Count : _statements[index].ParentIndex;
        AttachChildren(childIndexToInsertAt, statements, startIndexInStatementsForInsertion,
            endIndexInStatementsForInsertion,
            child =>
            {
                IStatement statement = (child as IStatement)!;
                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index);
            });
    }

    public void PrependStatement(IStatement statement)
    {
        PrependChild(statement);
        _statements.Insert(0, statement);
    }

    public void PrependStatements(IEnumerable<IStatement> statements)
    {
        int index = 0;
        PrependChildren(statements, child =>
            {
                IStatement statement = (child as IStatement)!;
                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index);
            });
    }

    public void PrependStatements(IEnumerable<IStatement> statements, int startIndexInStatementsForInsertion)
    {
        int index = 0;
        PrependChildren(statements, startIndexInStatementsForInsertion,
            child =>
            {
                IStatement statement = (child as IStatement)!;
                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index);
            });
    }

    public void PrependStatements(IEnumerable<IStatement> statements, int startIndexInStatementsForInsertion,
        int endIndexInStatementsForInsertion)
    {
        int index = 0;
        PrependChildren(statements, startIndexInStatementsForInsertion, endIndexInStatementsForInsertion,
            child =>
            {
                IStatement statement = (child as IStatement)!;
                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index);
            });
    }

    public void PrependStatements(IList<IStatement> statements)
    {
        int index = 0;
        PrependChildren(statements, child =>
            {
                IStatement statement = (child as IStatement)!;
                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index);
            });
    }

    public void PrependStatements(IList<IStatement> statements, int startIndexInStatementsForInsertion)
    {
        int index = 0;
        PrependChildren(statements, startIndexInStatementsForInsertion,
            child =>
            {
                IStatement statement = (child as IStatement)!;
                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index);
            });
    }

    public void PrependStatements(IList<IStatement> statements, int startIndexInStatementsForInsertion,
        int endIndexInStatementsForInsertion)
    {
        int index = 0;
        PrependChildren(statements, startIndexInStatementsForInsertion,
            endIndexInStatementsForInsertion,
            child =>
            {
                IStatement statement = (child as IStatement)!;
                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index);
            });
    }

    public void PrependStatements(List<IStatement> statements)
    {
        int index = 0;
        PrependChildren(statements, child =>
            {
                IStatement statement = (child as IStatement)!;
                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index);
            });
    }

    public void PrependStatements(List<IStatement> statements, int startIndexInStatementsForInsertion)
    {
        int index = 0;
        PrependChildren(statements, startIndexInStatementsForInsertion,
            child =>
            {
                IStatement statement = (child as IStatement)!;
                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index);
            });
    }

    public void PrependStatements(List<IStatement> statements, int startIndexInStatementsForInsertion,
        int endIndexInStatementsForInsertion)
    {
        int index = 0;
        PrependChildren(statements, startIndexInStatementsForInsertion,
            endIndexInStatementsForInsertion,
            child =>
            {
                IStatement statement = (child as IStatement)!;
                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index);
            });
    }

    public void PrependStatements(StatementGroup statements)
    {
        int index = 0;
        PrependChildren<StatementGroup, IStatement>(statements,
            child =>
            {
                IStatement statement = (child as IStatement)!;
                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index);
            });
    }

    public void PrependStatements(StatementGroup statements, int startIndexInStatementsForInsertion)
    {
        int index = 0;
        PrependChildren<StatementGroup, IStatement>(statements, startIndexInStatementsForInsertion,
            child =>
            {
                IStatement statement = (child as IStatement)!;
                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index);
            });
    }

    public void PrependStatements(StatementGroup statements, int startIndexInStatementsForInsertion,
        int endIndexInStatementsForInsertion)
    {
        int index = 0;
        PrependChildren<StatementGroup, IStatement>(statements, startIndexInStatementsForInsertion,
            endIndexInStatementsForInsertion,
            child =>
            {
                IStatement statement = (child as IStatement)!;
                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index);
            });
    }

    public void AppendStatement(IStatement statement)
    {
        AppendChild(statement);
        _statements.Insert(0, statement);
    }

    public void AppendStatements(IEnumerable<IStatement> statements)
    {
        AppendChildren(statements, child =>
        {
            IStatement statement = (child as IStatement)!;
            _statements.Add(statement);
            _statementsIndexes.Add(statement, Children.Count);
        });
    }

    public void AppendStatements(IEnumerable<IStatement> statements, int startIndexInStatementsForInsertion)
    {
        AppendChildren(statements, startIndexInStatementsForInsertion,
            child =>
        {
            IStatement statement = (child as IStatement)!;
            _statements.Add(statement);
            _statementsIndexes.Add(statement, Children.Count);
        });
    }

    public void AppendStatements(IEnumerable<IStatement> statements, int startIndexInStatementsForInsertion,
        int endIndexInStatementsForInsertion)
    {
        AppendChildren(statements, startIndexInStatementsForInsertion, endIndexInStatementsForInsertion,
            child =>
        {
            IStatement statement = (child as IStatement)!;
            _statements.Add(statement);
            _statementsIndexes.Add(statement, Children.Count);
        });
    }

    public void AppendStatements(IList<IStatement> statements)
    {
        AppendChildren(statements, child =>
        {
            IStatement statement = (child as IStatement)!;
            _statements.Add(statement);
            _statementsIndexes.Add(statement, Children.Count);
        });
    }

    public void AppendStatements(IList<IStatement> statements, int startIndexInStatementsForInsertion)
    {
        AppendChildren(statements, startIndexInStatementsForInsertion,
            child =>
        {
            IStatement statement = (child as IStatement)!;
            _statements.Add(statement);
            _statementsIndexes.Add(statement, Children.Count);
        });
    }

    public void AppendStatements(IList<IStatement> statements, int startIndexInStatementsForInsertion,
        int endIndexInStatementsForInsertion)
    {
        AppendChildren(statements, startIndexInStatementsForInsertion,
            endIndexInStatementsForInsertion,
            child =>
        {
            IStatement statement = (child as IStatement)!;
            _statements.Add(statement);
            _statementsIndexes.Add(statement, Children.Count);
        });
    }

    public void AppendStatements(List<IStatement> statements)
    {
        AppendChildren(statements, child =>
        {
            IStatement statement = (child as IStatement)!;
            _statements.Add(statement);
            _statementsIndexes.Add(statement, Children.Count);
        });
    }

    public void AppendStatements(List<IStatement> statements, int startIndexInStatementsForInsertion)
    {
        AppendChildren(statements, startIndexInStatementsForInsertion,
            child =>
        {
            IStatement statement = (child as IStatement)!;
            _statements.Add(statement);
            _statementsIndexes.Add(statement, Children.Count);
        });
    }

    public void AppendStatements(List<IStatement> statements, int startIndexInStatementsForInsertion,
        int endIndexInStatementsForInsertion)
    {
        AppendChildren(statements, startIndexInStatementsForInsertion,
            endIndexInStatementsForInsertion,
            child =>
        {
            IStatement statement = (child as IStatement)!;
            _statements.Add(statement);
            _statementsIndexes.Add(statement, Children.Count);
        });
    }

    public void AppendStatements(StatementGroup statements)
    {
        AppendChildren<StatementGroup, IStatement>(statements,
            child =>
        {
            IStatement statement = (child as IStatement)!;
            _statements.Add(statement);
            _statementsIndexes.Add(statement, Children.Count);
        });
    }

    public void AppendStatements(StatementGroup statements, int startIndexInStatementsForInsertion)
    {
        AppendChildren<StatementGroup, IStatement>(statements, startIndexInStatementsForInsertion,
            child =>
        {
            IStatement statement = (child as IStatement)!;
            _statements.Add(statement);
            _statementsIndexes.Add(statement, Children.Count);
        });
    }

    public void AppendStatements(StatementGroup statements, int startIndexInStatementsForInsertion,
        int endIndexInStatementsForInsertion)
    {
        AppendChildren<StatementGroup, IStatement>(statements, startIndexInStatementsForInsertion,
            endIndexInStatementsForInsertion,
            child =>
        {
            IStatement statement = (child as IStatement)!;
            _statements.Add(statement);
            _statementsIndexes.Add(statement, Children.Count);
        });
    }

    private void InsertStatementCore(int index, IStatement statement)
    {
        int childIndexToInsertAt = index == _statements.Count ? Children.Count : _statements[index].ParentIndex;
        _statements.Insert(index, statement);
        AttachChild(childIndexToInsertAt, statement);
    }

    public void SetStatement(int index, IStatement statement)
    {
        throw new NotImplementedException();
    }

    public void Add(IStatement item)
    {
        AppendStatement(item);
    }

    public void Clear()
    {
        base.ClearChildren();
    }

    public void ClearStatements()
    {
        while (_statements.Count > 0)
        {
            IStatement statement = _statements[_statements.Count - 1];
            statement.DetachFromParent();
            _statements.RemoveAt(_statements.Count - 1);
            _statementsIndexes.Remove(statement);
        }
    }

    public bool Contains(IStatement item) => _statementsIndexes.ContainsKey(item);

    public void CopyTo(IStatement[] array, int arrayIndex)
    {
        _statements.CopyTo(array, arrayIndex);
    }

    public bool Remove(IStatement item)
    {
        if (!_statementsIndexes.ContainsKey(item))
        {
            return false;
        }
        
        int index = _statementsIndexes[item];
        item.DetachFromParent();
        _statements.RemoveAt(index);
        _statementsIndexes.Remove(item);

        return true;
    }

    public int Count => _statements.Count;

    public bool IsReadOnly => false;

    public int IndexOf(IStatement item)
    {
        return _statementsIndexes.TryGetValue(item, out int index) ? index : -1;
    }

    public void Insert(int index, IStatement item)
    {
        
    }

    public void RemoveAt(int index)
    {
        throw new System.NotImplementedException();
    }

    public new IStatement this[int index]
    {
        get => _statements[index];
        set => SetStatement(index, value);
    }

    private void CheckStatementIndexInclusive(int index)
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }
    }

    private void CheckStatementIndexExclusive(int index)
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }
    }
}