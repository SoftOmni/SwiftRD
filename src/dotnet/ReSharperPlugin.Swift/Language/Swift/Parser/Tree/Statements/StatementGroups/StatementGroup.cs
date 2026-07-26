using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.BaseNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.StatementGroups;


//TODO: refactor
public class StatementGroup : SwiftCompositeNode, IStatementGroup
{
    private readonly List<IStatement> _statements = [];


    // TODO: write the full API for statement group and then decide on the indexes data structure

    private readonly Dictionary<IReadOnlyStatement, int> _statementsIndexes = [];

    internal StatementGroup(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        List<IStatement> statements)
        : base(buffer, children)
    {
        _statements = statements;
    }


    IReadOnlyList<IStatement> IStatementGroup.Statements => _statements;

    public bool IsEmpty => _statements.Count == 0;
    
    public bool HasStatements => _statements.Count > 0;

    IStatement IList<IStatement>.this[int index]
    {
        get => _statements[index];
        set => throw new NotImplementedException();
    }

    IStatement IStatementGroup.this[int index]
    {
        get => _statements[index];
        set => throw new NotImplementedException();
    }

    IEnumerator<IStatement> IEnumerable<IStatement>.GetEnumerator()
    {
        return _statements.GetEnumerator();
    }

    private void SetupChildren()
    {
        // TODO: once data structure around fast index lookup of statements figured out, update this piece of code and all other relevant location
        foreach (INode? node in ChildNodes)
        {
            if (node is IReadOnlyStatement statement)
            {
                // _statements.Add(statement);
            }
        }
    }

    public IReadOnlyList<IReadOnlyStatement> Statements => _statements;

    public IEnumerator<IReadOnlyStatement> GetEnumerator()
    {
        return _statements.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void InsertStatement(int index, IReadOnlyStatement statement)
    {
        // CheckStatementIndexInclusive(index);
        // InsertStatementCore(index, statement); TODO: address
    }
    
    /*

    public void InsertStatements(int index, IEnumerable<IReadOnlyStatement> statements)
    {
        CheckStatementIndexInclusive(index);

        
        int childIndexToInsertAt = index == _statements.Count ? ChildNodes.Count : _statements[index].ParentIndex;

        if (index == _statements.Count)
        {
            AttachChildren(childIndexToInsertAt, statements,
                child =>
                {
                    IReadOnlyStatement statement = (child as IReadOnlyStatement)!;

                    _statements.Insert(index, statement);
                    _statementsIndexes.Add(statement, index++);
                });
            return;
        }

        List<IReadOnlyStatement> nodesToMove = [];
        AttachChildren(childIndexToInsertAt, statements,
            child =>
            {
                IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
                nodesToMove.Add(_statements[index]);

                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index++);
            });

        foreach (IReadOnlyStatement node in nodesToMove)
        {
            int previousIndex = _statementsIndexes[node];
            _statementsIndexes[node] = previousIndex + nodesToMove.Count;
        }
    }

    public void InsertStatements(int index, IEnumerable<IReadOnlyStatement> statements, int startIndexInStatementsForInsertion)
    {
        CheckStatementIndexInclusive(index);

        int childIndexToInsertAt = index == _statements.Count 
            ? ChildNodes.Count 
            : _statements[index].ParentIndex;

        if (index == _statements.Count)
        {
            AttachChildren(childIndexToInsertAt, statements, startIndexInStatementsForInsertion,
                child =>
                {
                    IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
                    _statements.Insert(index, statement);
                    _statementsIndexes.Add(statement, index++);
                });
            return;
        }

        List<IReadOnlyStatement> nodesToMove = [];
        AttachChildren(childIndexToInsertAt, statements, startIndexInStatementsForInsertion,
            child =>
            {
                IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
                nodesToMove.Add(_statements[index]);

                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index++);
            }
        );

        foreach (IReadOnlyStatement node in nodesToMove)
        {
            int previousIndex = _statementsIndexes[node];
            _statementsIndexes[node] = previousIndex + nodesToMove.Count;
        }
    }

    public void InsertStatements(int index, IEnumerable<IReadOnlyStatement> statements, int startIndexInStatementsForInsertion,
        int endIndexInStatementsForInsertion)
    {
        CheckStatementIndexInclusive(index);

        int childIndexToInsertAt = index == _statements.Count ? Children.Count : _statements[index].ParentIndex;

        if (index == _statements.Count)
        {
            AttachChildren(childIndexToInsertAt, statements, startIndexInStatementsForInsertion,
                endIndexInStatementsForInsertion,
                child =>
                {
                    IReadOnlyStatement statement = (child as IReadOnlyStatement)!;

                    _statements.Insert(index, statement);
                    _statementsIndexes.Add(statement, index++);
                });
            return;
        }

        int distance = endIndexInStatementsForInsertion - startIndexInStatementsForInsertion;
        AttachChildren(childIndexToInsertAt, statements, startIndexInStatementsForInsertion,
            endIndexInStatementsForInsertion,
            child =>
            {
                IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
                _statementsIndexes[_statements[index]] += distance;

                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index++);
            });
    }

    public void InsertStatements(int index, IList<IReadOnlyStatement> statements)
    {
        CheckStatementIndexInclusive(index);

        int childIndexToInsertAt = index == _statements.Count ? Children.Count : _statements[index].ParentIndex;

        if (index == _statements.Count)
        {
            AttachChildren(childIndexToInsertAt, statements,
                child =>
                {
                    IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
                    _statements.Insert(index, statement);
                    _statementsIndexes.Add(statement, index++);
                });
            return;
        }

        AttachChildren(childIndexToInsertAt, statements,
            child =>
            {
                IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
                _statementsIndexes[_statements[index]] += Children.Count;

                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index++);
            });
    }

    public void InsertStatements(int index, IList<IReadOnlyStatement> statements, int startIndexInStatementsForInsertion)
    {
        CheckStatementIndexInclusive(index);

        int childIndexToInsertAt = index == _statements.Count ? Children.Count : _statements[index].ParentIndex;

        if (index == _statements.Count)
        {
            AttachChildren(childIndexToInsertAt, statements, startIndexInStatementsForInsertion,
                child =>
                {
                    IReadOnlyStatement statement = (child as IReadOnlyStatement)!;

                    _statements.Insert(index, statement);
                    _statementsIndexes.Add(statement, index++);
                });
            return;
        }

        AttachChildren(childIndexToInsertAt, statements, startIndexInStatementsForInsertion,
            child =>
            {
                IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
                _statementsIndexes[_statements[index]] += Children.Count;

                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index++);
            }
        );
    }

    public void InsertStatements(int index, IList<IReadOnlyStatement> statements, int startIndexInStatementsForInsertion,
        int endIndexInStatementsForInsertion)
    {
        CheckStatementIndexInclusive(index);

        int childIndexToInsertAt = index == _statements.Count ? Children.Count : _statements[index].ParentIndex;

        if (index == _statements.Count)
        {
            AttachChildren(childIndexToInsertAt, statements, startIndexInStatementsForInsertion,
                endIndexInStatementsForInsertion,
                child =>
                {
                    IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
                    _statements.Insert(index, statement);
                    _statementsIndexes.Add(statement, index++);
                });
            return;
        }

        int distance = endIndexInStatementsForInsertion - startIndexInStatementsForInsertion;
        AttachChildren(childIndexToInsertAt, statements, startIndexInStatementsForInsertion,
            endIndexInStatementsForInsertion,
            child =>
            {
                IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
                _statementsIndexes[_statements[index]] += distance;

                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index++);
            }
        );
    }

    public void InsertStatements(int index, List<IReadOnlyStatement> statements)
    {
        CheckStatementIndexInclusive(index);

        int childIndexToInsertAt = index == _statements.Count ? Children.Count : _statements[index].ParentIndex;

        if (index == _statements.Count)
        {
            AttachChildren(childIndexToInsertAt, statements,
                child =>
                {
                    IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
                    _statements.Insert(index, statement);
                    _statementsIndexes.Add(statement, index++);
                });
            return;
        }

        AttachChildren(childIndexToInsertAt, statements,
            child =>
            {
                IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
                _statementsIndexes[_statements[index]] += Children.Count;

                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index++);
            });
    }

    public void InsertStatements(int index, List<IReadOnlyStatement> statements, int startIndexInStatementsForInsertion)
    {
        CheckStatementIndexInclusive(index);

        int childIndexToInsertAt = index == _statements.Count ? Children.Count : _statements[index].ParentIndex;

        if (index == _statements.Count)
        {
            AttachChildren(childIndexToInsertAt, statements, startIndexInStatementsForInsertion,
                child =>
                {
                    IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
                    _statements.Insert(index, statement);
                    _statementsIndexes.Add(statement, index++);
                });
            return;
        }

        AttachChildren(childIndexToInsertAt, statements,
            child =>
            {
                IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
                _statementsIndexes[_statements[index]] += Children.Count;

                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index++);
            });
    }

    public void InsertStatements(int index, List<IReadOnlyStatement> statements, int startIndexInStatementsForInsertion,
        int endIndexInStatementsForInsertion)
    {
        CheckStatementIndexInclusive(index);

        int childIndexToInsertAt = index == _statements.Count ? Children.Count : _statements[index].ParentIndex;
        if (index == _statements.Count)
        {
            AttachChildren(childIndexToInsertAt, statements, startIndexInStatementsForInsertion,
                endIndexInStatementsForInsertion,
                child =>
                {
                    IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
                    _statements.Insert(index, statement);
                    _statementsIndexes.Add(statement, index++);
                });
            return;
        }

        AttachChildren(childIndexToInsertAt, statements,
            child =>
            {
                IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
                _statementsIndexes[_statements[index]] += Children.Count;

                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index++);
            });
    }

    public void InsertStatements(int index, StatementGroup statements)
    {
        CheckStatementIndexInclusive(index);

        int childIndexToInsertAt = index == _statements.Count ? Children.Count : _statements[index].ParentIndex;

        if (index == _statements.Count)
        {
            AttachChildren(childIndexToInsertAt, statements,
                child =>
                {
                    IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
                    _statements.Insert(index, statement);
                    _statementsIndexes.Add(statement, index++);
                });
            return;
        }

        AttachChildren(childIndexToInsertAt, statements,
            child =>
            {
                IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
                _statementsIndexes[_statements[index]] += Children.Count;

                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index++);
            });
    }

    public void InsertStatements(int index, StatementGroup statements, int startIndexInStatementsForInsertion)
    {
        CheckStatementIndexInclusive(index);

        int childIndexToInsertAt = index == _statements.Count ? Children.Count : _statements[index].ParentIndex;

        if (index == _statements.Count)
        {
            AttachChildren(childIndexToInsertAt, statements, startIndexInStatementsForInsertion,
                child =>
                {
                    IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
                    _statements.Insert(index, statement);
                    _statementsIndexes.Add(statement, index++);
                });
            return;
        }

        AttachChildren(childIndexToInsertAt, statements,
            child =>
            {
                IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
                _statementsIndexes[_statements[index]] += Children.Count;

                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index++);
            });
    }

    public void InsertStatements(int index, StatementGroup statements, int startIndexInStatementsForInsertion,
        int endIndexInStatementsForInsertion)
    {
        CheckStatementIndexInclusive(index);

        int childIndexToInsertAt = index == _statements.Count ? Children.Count : _statements[index].ParentIndex;
        if (index == _statements.Count)
        {
            AttachChildren(childIndexToInsertAt, statements, startIndexInStatementsForInsertion,
                endIndexInStatementsForInsertion,
                child =>
                {
                    IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
                    _statements.Insert(index, statement);
                    _statementsIndexes.Add(statement, index++);
                });
            return;
        }

        AttachChildren(childIndexToInsertAt, statements,
            child =>
            {
                IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
                _statementsIndexes[_statements[index]] += Children.Count;

                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index++);
            });
    }

    public void PrependStatement(IReadOnlyStatement statement)
    {
        PrependChild(statement);

        foreach (IReadOnlyStatement statementToMove in _statements)
        {
            _statementsIndexes[statementToMove]++;
        }

        _statements.Insert(0, statement);
        _statementsIndexes.Add(statement, 0);
    }

    public void PrependStatements(IEnumerable<IReadOnlyStatement> statements)
    {
        int index = 0;

        if (index == _statements.Count)
        {
            PrependChildren(statements, child =>
            {
                IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index++);
            });
            return;
        }

        List<IReadOnlyStatement> statementsToMove = new List<IReadOnlyStatement>(_statements);
        PrependChildren(statements, child =>
        {
            IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
            statementsToMove.Add(statement);

            _statements.Insert(index, statement);
            _statementsIndexes.Add(statement, index++);
        });

        foreach (IReadOnlyStatement statementToMove in statementsToMove)
        {
            _statementsIndexes[statementToMove] += statementsToMove.Count;
        }
    }

    public void PrependStatements(IEnumerable<IReadOnlyStatement> statements, int startIndexInStatementsForInsertion)
    {
        int index = 0;

        if (index == _statements.Count)
        {
            PrependChildren(statements, startIndexInStatementsForInsertion,
                child =>
                {
                    IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
                    _statements.Insert(index, statement);
                    _statementsIndexes.Add(statement, index++);
                });
            return;
        }

        List<IReadOnlyStatement> moveStatements = [];
        PrependChildren(statements, startIndexInStatementsForInsertion,
            child =>
            {
                IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
                moveStatements.Add(statement);

                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index++);
            });

        foreach (IReadOnlyStatement statementToMove in moveStatements)
        {
            _statementsIndexes[statementToMove] += moveStatements.Count;
        }
    }

    public void PrependStatements(IEnumerable<IReadOnlyStatement> statements, int startIndexInStatementsForInsertion,
        int endIndexInStatementsForInsertion)
    {
        int index = 0;

        if (index == _statements.Count)
        {
            PrependChildren(statements, startIndexInStatementsForInsertion, endIndexInStatementsForInsertion,
                child =>
                {
                    IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
                    _statements.Insert(index, statement);
                    _statementsIndexes.Add(statement, index++);
                });
            return;
        }

        int distance = endIndexInStatementsForInsertion - startIndexInStatementsForInsertion;
        PrependChildren(statements, startIndexInStatementsForInsertion, endIndexInStatementsForInsertion,
            child =>
            {
                IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
                _statementsIndexes[_statements[index]] += distance;

                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index++);
            }
        );
    }

    public void PrependStatements(IList<IReadOnlyStatement> statements)
    {
        int index = 0;

        if (index == _statements.Count)
        {
            PrependChildren(statements, child =>
            {
                IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index++);
            });
            return;
        }

        PrependChildren(statements, child =>
        {
            IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
            _statementsIndexes[_statements[index]] += statements.Count;

            _statements.Insert(index, statement);
            _statementsIndexes.Add(statement, index++);
        });
    }

    public void PrependStatements(IList<IReadOnlyStatement> statements, int startIndexInStatementsForInsertion)
    {
        int index = 0;

        if (index == _statements.Count)
        {
            PrependChildren(statements, startIndexInStatementsForInsertion,
                child =>
                {
                    IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
                    _statements.Insert(index, statement);
                    _statementsIndexes.Add(statement, index++);
                });
            return;
        }

        PrependChildren(statements, child =>
        {
            IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
            _statementsIndexes[_statements[index]] += statements.Count;

            _statements.Insert(index, statement);
            _statementsIndexes.Add(statement, index++);
        });
    }

    public void PrependStatements(IList<IReadOnlyStatement> statements, int startIndexInStatementsForInsertion,
        int endIndexInStatementsForInsertion)
    {
        int index = 0;

        if (index == _statements.Count)
        {
            PrependChildren(statements, startIndexInStatementsForInsertion,
                endIndexInStatementsForInsertion,
                child =>
                {
                    IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
                    _statements.Insert(index, statement);
                    _statementsIndexes.Add(statement, index++);
                });
            return;
        }

        PrependChildren(statements, startIndexInStatementsForInsertion, endIndexInStatementsForInsertion,
            child =>
            {
                IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
                _statementsIndexes[_statements[index]] += statements.Count;

                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index++);
            });
    }

    public void PrependStatements(List<IReadOnlyStatement> statements)
    {
        int index = 0;

        if (index == _statements.Count)
        {
            PrependChildren(statements, child =>
            {
                IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index++);
            });
            return;
        }

        PrependChildren(statements, child =>
        {
            IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
            _statementsIndexes[_statements[index]] += statements.Count;

            _statements.Insert(index, statement);
            _statementsIndexes.Add(statement, index++);
        });
    }

    public void PrependStatements(List<IReadOnlyStatement> statements, int startIndexInStatementsForInsertion)
    {
        int index = 0;

        if (index == _statements.Count)
        {
            PrependChildren(statements, startIndexInStatementsForInsertion,
                child =>
                {
                    IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
                    _statements.Insert(index, statement);
                    _statementsIndexes.Add(statement, index++);
                });
            return;
        }

        PrependChildren(statements, startIndexInStatementsForInsertion,
            child =>
            {
                IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
                _statementsIndexes[_statements[index]] += statements.Count;

                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index++);
            });
    }

    public void PrependStatements(List<IReadOnlyStatement> statements, int startIndexInStatementsForInsertion,
        int endIndexInStatementsForInsertion)
    {
        int index = 0;

        if (index == _statements.Count)
        {
            PrependChildren(statements, startIndexInStatementsForInsertion,
                endIndexInStatementsForInsertion,
                child =>
                {
                    IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
                    _statements.Insert(index, statement);
                    _statementsIndexes.Add(statement, index++);
                });
            return;
        }

        int distance = endIndexInStatementsForInsertion - startIndexInStatementsForInsertion;
        PrependChildren(statements, startIndexInStatementsForInsertion,
            endIndexInStatementsForInsertion, child =>
            {
                IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
                _statementsIndexes[_statements[index]] += distance;

                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index++);
            });
    }

    public void PrependStatements(StatementGroup statements)
    {
        int index = 0;

        if (index == _statements.Count)
        {
            PrependChildren<StatementGroup, IReadOnlyStatement>(statements,
                child =>
                {
                    IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
                    _statements.Insert(index, statement);
                    _statementsIndexes.Add(statement, index++);
                });
            return;
        }

        PrependChildren<StatementGroup, IReadOnlyStatement>(statements,
            child =>
            {
                IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
                _statementsIndexes[_statements[index]] += Children.Count;

                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index++);
            });
    }

    public void PrependStatements(StatementGroup statements, int startIndexInStatementsForInsertion)
    {
        int index = 0;
        if (index == _statements.Count)
        {
            PrependChildren<StatementGroup, IReadOnlyStatement>(statements, startIndexInStatementsForInsertion,
                child =>
                {
                    IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
                    _statementsIndexes.Add(statement, index);
                    _statements.Insert(index++, statement);
                });
            return;
        }

        PrependChildren<StatementGroup, IReadOnlyStatement>(statements, startIndexInStatementsForInsertion,
            child =>
            {
                IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
                _statementsIndexes[_statements[index]] += Children.Count;

                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index++);
            });
    }

    public void PrependStatements(StatementGroup statements, int startIndexInStatementsForInsertion,
        int endIndexInStatementsForInsertion)
    {
        int index = 0;

        if (index == _statements.Count)
        {
            PrependChildren<StatementGroup, IReadOnlyStatement>(statements, startIndexInStatementsForInsertion,
                endIndexInStatementsForInsertion,
                child =>
                {
                    IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
                    _statements.Insert(index, statement);
                    _statementsIndexes.Add(statement, index++);
                });
            return;
        }

        int distance = endIndexInStatementsForInsertion - startIndexInStatementsForInsertion;
        PrependChildren<StatementGroup, IReadOnlyStatement>(statements, startIndexInStatementsForInsertion,
            endIndexInStatementsForInsertion, child =>
            {
                IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
                _statementsIndexes[_statements[index]] += distance;

                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index++);
            }
        );
    }

    public void Add(IReadOnlyStatement item)
    {
        AppendStatement(item);
    }

    public void AppendStatement(IReadOnlyStatement statement)
    {
        AppendChild(statement);
        _statements.Insert(Children.Count, statement);
    }

    public void AppendStatements(IEnumerable<IReadOnlyStatement> statements)
    {
        AppendChildren(statements, child =>
        {
            IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
            _statements.Add(statement);
            _statementsIndexes.Add(statement, Children.Count);
        });
    }

    public void AppendStatements(IEnumerable<IReadOnlyStatement> statements, int startIndexInStatementsForInsertion)
    {
        AppendChildren(statements, startIndexInStatementsForInsertion,
            child =>
            {
                IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
                _statements.Add(statement);
                _statementsIndexes.Add(statement, Children.Count);
            });
    }

    public void AppendStatements(IEnumerable<IReadOnlyStatement> statements, int startIndexInStatementsForInsertion,
        int endIndexInStatementsForInsertion)
    {
        AppendChildren(statements, startIndexInStatementsForInsertion, endIndexInStatementsForInsertion,
            child =>
            {
                IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
                _statements.Add(statement);
                _statementsIndexes.Add(statement, Children.Count);
            });
    }

    public void AppendStatements(IList<IReadOnlyStatement> statements)
    {
        AppendChildren(statements, child =>
        {
            IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
            _statements.Add(statement);
            _statementsIndexes.Add(statement, Children.Count);
        });
    }

    public void AppendStatements(IList<IReadOnlyStatement> statements, int startIndexInStatementsForInsertion)
    {
        AppendChildren(statements, startIndexInStatementsForInsertion,
            child =>
            {
                IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
                _statements.Add(statement);
                _statementsIndexes.Add(statement, Children.Count);
            });
    }

    public void AppendStatements(IList<IReadOnlyStatement> statements, int startIndexInStatementsForInsertion,
        int endIndexInStatementsForInsertion)
    {
        AppendChildren(statements, startIndexInStatementsForInsertion,
            endIndexInStatementsForInsertion,
            child =>
            {
                IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
                _statements.Add(statement);
                _statementsIndexes.Add(statement, Children.Count);
            });
    }

    public void AppendStatements(List<IReadOnlyStatement> statements)
    {
        AppendChildren(statements, child =>
        {
            IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
            _statements.Add(statement);
            _statementsIndexes.Add(statement, Children.Count);
        });
    }

    public void AppendStatements(List<IReadOnlyStatement> statements, int startIndexInStatementsForInsertion)
    {
        AppendChildren(statements, startIndexInStatementsForInsertion,
            child =>
            {
                IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
                _statements.Add(statement);
                _statementsIndexes.Add(statement, Children.Count);
            });
    }

    public void AppendStatements(List<IReadOnlyStatement> statements, int startIndexInStatementsForInsertion,
        int endIndexInStatementsForInsertion)
    {
        AppendChildren(statements, startIndexInStatementsForInsertion,
            endIndexInStatementsForInsertion,
            child =>
            {
                IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
                _statements.Add(statement);
                _statementsIndexes.Add(statement, Children.Count);
            });
    }

    public void AppendStatements(StatementGroup statements)
    {
        AppendChildren<StatementGroup, IReadOnlyStatement>(statements,
            child =>
            {
                IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
                _statements.Add(statement);
                _statementsIndexes.Add(statement, Children.Count);
            });
    }

    public void AppendStatements(StatementGroup statements, int startIndexInStatementsForInsertion)
    {
        AppendChildren<StatementGroup, IReadOnlyStatement>(statements, startIndexInStatementsForInsertion,
            child =>
            {
                IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
                _statements.Add(statement);
                _statementsIndexes.Add(statement, Children.Count);
            });
    }

    public void AppendStatements(StatementGroup statements, int startIndexInStatementsForInsertion,
        int endIndexInStatementsForInsertion)
    {
        AppendChildren<StatementGroup, IReadOnlyStatement>(statements, startIndexInStatementsForInsertion,
            endIndexInStatementsForInsertion,
            child =>
            {
                IReadOnlyStatement statement = (child as IReadOnlyStatement)!;
                _statements.Add(statement);
                _statementsIndexes.Add(statement, Children.Count);
            });
    }

    private void InsertStatementCore(int index, IReadOnlyStatement statement)
    {
        int childIndexToInsertAt = index == _statements.Count ? Children.Count : _statements[index].ParentIndex;
        _statements.Insert(index, statement);
        AttachChild(childIndexToInsertAt, statement);
    }*/

    public void SetStatement(int index, IReadOnlyStatement statement)
    {
        throw new NotImplementedException();
    }

    public void SetStatements(IEnumerable<IReadOnlyStatement> statements)
    {
        throw new NotImplementedException();
    }

    public void SetStatements(IEnumerable<IReadOnlyStatement> statements, int startIndexInStatementsForInsertion)
    {
        throw new NotImplementedException();
    }

    public void SetStatements(IEnumerable<IReadOnlyStatement> statements, int startIndexInStatementsForInsertion,
        int endIndexInStatementsForInsertion)
    {
        throw new NotImplementedException();
    }

    public void SetStatements(IList<IReadOnlyStatement> statements)
    {
        throw new NotImplementedException();
    }

    public void SetStatements(IList<IReadOnlyStatement> statements, int startIndexInStatementsForInsertion)
    {
        throw new NotImplementedException();
    }

    public void SetStatements(IList<IReadOnlyStatement> statements, int startIndexInStatementsForInsertion,
        int endIndexInStatementsForInsertion)
    {
        throw new NotImplementedException();
    }

    public void SetStatements(List<IReadOnlyStatement> statements)
    {
        throw new NotImplementedException();
    }

    public void SetStatements(List<IReadOnlyStatement> statements, int startIndexInStatementsForInsertion)
    {
        throw new NotImplementedException();
    }

    public void SetStatements(List<IReadOnlyStatement> statements, int startIndexInStatementsForInsertion,
        int endIndexInStatementsForInsertion)
    {
        throw new NotImplementedException();
    }

    public void SetStatements(StatementGroup statements)
    {
        throw new NotImplementedException();
    }

    public void SetStatements(StatementGroup statements, int startIndexInStatementsForInsertion)
    {
        throw new NotImplementedException();
    }

    public void SetStatements(StatementGroup statements, int startIndexInStatementsForInsertion,
        int endIndexInStatementsForInsertion)
    {
        throw new NotImplementedException();
    }

    public List<IReadOnlyStatement> ReplaceStatements(int indexOfReplacement, IEnumerable<IReadOnlyStatement> statements,
        bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<IReadOnlyStatement> ReplaceStatements(int indexOfReplacement, IEnumerable<IReadOnlyStatement> statements,
        int startIndexInStatementsForReplacement, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<IReadOnlyStatement> ReplaceStatements(int indexOfReplacement, IEnumerable<IReadOnlyStatement> statements,
        int startIndexInStatementsForReplacement, int endIndexInStatementsForReplacement, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<IReadOnlyStatement> ReplaceStatements(int indexOfReplacement, IList<IReadOnlyStatement> statements, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<IReadOnlyStatement> ReplaceStatements(int indexOfReplacement, IList<IReadOnlyStatement> statements,
        int startIndexInStatementsForReplacement, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<IReadOnlyStatement> ReplaceStatements(int indexOfReplacement, IList<IReadOnlyStatement> statements,
        int startIndexInStatementsForReplacement, int endIndexInStatementsForReplacement, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<IReadOnlyStatement> ReplaceStatements(int indexOfReplacement, List<IReadOnlyStatement> statements, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<IReadOnlyStatement> ReplaceStatements(int indexOfReplacement, List<IReadOnlyStatement> statements,
        int startIndexInStatementsForReplacement, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<IReadOnlyStatement> ReplaceStatements(int indexOfReplacement, List<IReadOnlyStatement> statements,
        int startIndexInStatementsForReplacement, int endIndexInStatementsForReplacement, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<IReadOnlyStatement> ReplaceStatements(int indexOfReplacement, StatementGroup statements, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<IReadOnlyStatement> ReplaceStatements(int indexOfReplacement, StatementGroup statements,
        int startIndexInStatementsForReplacement, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<IReadOnlyStatement> ReplaceStatements(int indexOfReplacement, StatementGroup statements,
        int startIndexInStatementsForReplacement, int endIndexInStatementsForReplacement, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public bool Contains(IReadOnlyStatement item) => ContainsStatement(item);

    public bool ContainsStatement(IReadOnlyStatement item) => _statementsIndexes.ContainsKey(item);

    public bool ContainsStatement(Func<IReadOnlyStatement, bool> predicate)
    {
        foreach (IReadOnlyStatement statement in _statements)
        {
            if (predicate(statement))
            {
                return true;
            }
        }

        return false;
    }

    public bool ContainsStatement(Func<IReadOnlyStatement, int, bool> predicate)
    {
        for (int i = 0; i < _statements.Count; i++)
        {
            if (predicate(_statements[i], i))
            {
                return true;
            }
        }
        
        return false;
    }

    public void RemoveWhere(Func<IReadOnlyStatement, bool> predicate)
    {
        int index = 0;
        while (index < _statements.Count)
        {
            if (predicate(_statements[index]))
            {
                RemoveAt(index);
                continue;
            }

            index += 1;
        }
    }

    public void RemoveWhere(Func<IReadOnlyStatement, int, bool> predicate)
    {
        int index = 0;
        while (index < _statements.Count)
        {
            if (predicate(_statements[index], index))
            {
                RemoveAt(index);
                continue;
            }

            index += 1;
        }
    }

    public void RemoveAt(int index)
    {
        IReadOnlyStatement statement = _statements[index];
        statement.DetachFromParent();
        _statements.RemoveAt(index);

        _statementsIndexes.Remove(statement);
        for (int i = index; i < _statements.Count; i++)
        {
            IReadOnlyStatement statementToAdjust = _statements[i];
            _statementsIndexes[statementToAdjust] = i;
        }
    }

    public bool Remove(IReadOnlyStatement item)
    {
        if (!_statementsIndexes.TryGetValue(item, out int index))
        {
            return false;
        }

        item.DetachFromParent();
        _statements.RemoveAt(index);
        _statementsIndexes.Remove(item);

        for (int i = index; i < _statements.Count; i++)
        {
            IReadOnlyStatement statementToAdjust = _statements[i];
            _statementsIndexes[statementToAdjust] = i;
        }

        return true;
    }

    // TODO: Remove children or statements but API is unclear presently


    public void Clear()
    {
        ClearChildren();
    }

    public void ClearStatements()
    {
        while (_statements.Count > 0)
        {
            IReadOnlyStatement statement = _statements[_statements.Count - 1];
            statement.DetachFromParent();
            _statements.RemoveAt(_statements.Count - 1);
            _statementsIndexes.Remove(statement);
        }
    }

    public int Count => _statements.Count;

    public bool IsReadOnly => false;

    public int IndexOf(IReadOnlyStatement item)
    {
        return _statementsIndexes.GetValueOrDefault(item, -1);
    }

    public void Insert(int index, IReadOnlyStatement item)
    {
        InsertStatement(index, item);
    }

    public new IReadOnlyStatement this[int index]
    {
        get => _statements[index];
        set => SetStatement(index, value);
    }

    /*
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

    internal static StatementGroup Parse(SwiftLexer lexer, IEditableBuffer parentBuffer, int offset)
    {
        SubEditableBuffer subBuffer = new(parentBuffer, offset);
        List<ISwiftNode> children = [];
        int offsetInSubBuffer = 0;
        while (true)
        {
            if (lexer.TokenType is null || ReferenceEquals(lexer.TokenType, SwiftTokens.EndOfFileToken))
            {
                return new StatementGroup(subBuffer, children);
            }

            if (lexer.TokenType.IsWhitespace)
            {
                subBuffer.Length += lexer.TokenLength;

                WhitespaceSequence whitespaceSequence =
                    new(new SubEditableBuffer(subBuffer, offsetInSubBuffer, lexer.TokenLength));
                offsetInSubBuffer += lexer.TokenLength;
                children.Add(whitespaceSequence);
                lexer.Advance();

                continue;
            }

            if (lexer.TokenType.IsComment)
            {
                if (ReferenceEquals(lexer.TokenType, SwiftTokens.LineCommentToken))
                {
                    subBuffer.Length += lexer.TokenLength;

                    LineCommentNode lineComment =
                        new LineCommentNode(new SubEditableBuffer(subBuffer, offsetInSubBuffer, lexer.TokenLength));
                    offsetInSubBuffer += lexer.TokenLength;
                    children.Add(lineComment);
                    lexer.Advance();

                    continue;
                }

                subBuffer.Length += lexer.TokenLength;
                BlockCommentNode blockComment = BlockCommentNode.ParseWithStart(lexer, subBuffer, offsetInSubBuffer);
                offsetInSubBuffer += blockComment.GetTextLength();

                children.Add(blockComment);
                lexer.Advance();

                continue;
            }

            IReadOnlyStatement statement = IReadOnlyStatement.Parser.ParseWithStart(lexer, subBuffer, offsetInSubBuffer);
            offsetInSubBuffer += statement.GetTextLength();

            children.Add(statement);
            lexer.Advance();
        }
    }*/

    private void AttachChildren(int index, IEnumerable<IStatement> statements, Action<ISwiftNode<SwiftCompositeNode>> onAttachment)
    {
        
    }

    private void PrependChildren(int index, IEnumerable<IStatement> statements, Action<ISwiftNode<SwiftCompositeNode>> onAttachment)
    {
        
    }

    private void AppendChildren(IEnumerable<IStatement> statements, Action<ISwiftNode<SwiftCompositeNode>> onAttachment)
    {
        
    }

    public void Add(IStatement item)
    {
        throw new NotImplementedException();
    }

    public bool Contains(IStatement item)
    {
        throw new NotImplementedException();
    }

    public void CopyTo(IStatement[] array, int arrayIndex)
    {
        throw new NotImplementedException();
    }

    public bool Remove(IStatement item)
    {
        throw new NotImplementedException();
    }

    public int IndexOf(IStatement item)
    {
        throw new NotImplementedException();
    }

    public void Insert(int index, IStatement item)
    {
        throw new NotImplementedException();
    }

    IEnumerator<IStatement> IStatementGroup.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}