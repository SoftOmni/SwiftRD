using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Lexer;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;
using ReSharperPlugin.Swift.Language.Parser.Tree.Comments;
using ReSharperPlugin.Swift.Language.Parser.Tree.Whitespace;
using ReSharperPlugin.Swift.Technology;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Statements.StatementGroups;

public class StatementGroup : SwiftInternalNode, IList<IStatement>
{
    private readonly List<IStatement> _statements = [];

    // TODO: write the full API for statement group and then decide on the indexes data structure
    private readonly Dictionary<IStatement, int> _statementsIndexes = [];

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

        if (index == _statements.Count)
        {
            AttachChildren(childIndexToInsertAt, statements,
                child =>
                {
                    IStatement statement = (child as IStatement)!;

                    _statements.Insert(index, statement);
                    _statementsIndexes.Add(statement, index++);
                });
            return;
        }

        List<IStatement> nodesToMove = [];
        AttachChildren(childIndexToInsertAt, statements,
            child =>
            {
                IStatement statement = (child as IStatement)!;
                nodesToMove.Add(_statements[index]);

                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index++);
            });

        foreach (IStatement node in nodesToMove)
        {
            int previousIndex = _statementsIndexes[node];
            _statementsIndexes[node] = previousIndex + nodesToMove.Count;
        }
    }

    public void InsertStatements(int index, IEnumerable<IStatement> statements, int startIndexInStatementsForInsertion)
    {
        CheckStatementIndexInclusive(index);

        int childIndexToInsertAt = index == _statements.Count ? Children.Count : _statements[index].ParentIndex;

        if (index == _statements.Count)
        {
            AttachChildren(childIndexToInsertAt, statements, startIndexInStatementsForInsertion,
                child =>
                {
                    IStatement statement = (child as IStatement)!;
                    _statements.Insert(index, statement);
                    _statementsIndexes.Add(statement, index++);
                });
            return;
        }

        List<IStatement> nodesToMove = [];
        AttachChildren(childIndexToInsertAt, statements, startIndexInStatementsForInsertion,
            child =>
            {
                IStatement statement = (child as IStatement)!;
                nodesToMove.Add(_statements[index]);

                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index++);
            }
        );

        foreach (IStatement node in nodesToMove)
        {
            int previousIndex = _statementsIndexes[node];
            _statementsIndexes[node] = previousIndex + nodesToMove.Count;
        }
    }

    public void InsertStatements(int index, IEnumerable<IStatement> statements, int startIndexInStatementsForInsertion,
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
                    IStatement statement = (child as IStatement)!;

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
                IStatement statement = (child as IStatement)!;
                _statementsIndexes[_statements[index]] += distance;

                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index++);
            });
    }

    public void InsertStatements(int index, IList<IStatement> statements)
    {
        CheckStatementIndexInclusive(index);

        int childIndexToInsertAt = index == _statements.Count ? Children.Count : _statements[index].ParentIndex;

        if (index == _statements.Count)
        {
            AttachChildren(childIndexToInsertAt, statements,
                child =>
                {
                    IStatement statement = (child as IStatement)!;
                    _statements.Insert(index, statement);
                    _statementsIndexes.Add(statement, index++);
                });
            return;
        }

        AttachChildren(childIndexToInsertAt, statements,
            child =>
            {
                IStatement statement = (child as IStatement)!;
                _statementsIndexes[_statements[index]] += Children.Count;

                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index++);
            });
    }

    public void InsertStatements(int index, IList<IStatement> statements, int startIndexInStatementsForInsertion)
    {
        CheckStatementIndexInclusive(index);

        int childIndexToInsertAt = index == _statements.Count ? Children.Count : _statements[index].ParentIndex;

        if (index == _statements.Count)
        {
            AttachChildren(childIndexToInsertAt, statements, startIndexInStatementsForInsertion,
                child =>
                {
                    IStatement statement = (child as IStatement)!;

                    _statements.Insert(index, statement);
                    _statementsIndexes.Add(statement, index++);
                });
            return;
        }

        AttachChildren(childIndexToInsertAt, statements, startIndexInStatementsForInsertion,
            child =>
            {
                IStatement statement = (child as IStatement)!;
                _statementsIndexes[_statements[index]] += Children.Count;

                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index++);
            }
        );
    }

    public void InsertStatements(int index, IList<IStatement> statements, int startIndexInStatementsForInsertion,
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
                    IStatement statement = (child as IStatement)!;
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
                IStatement statement = (child as IStatement)!;
                _statementsIndexes[_statements[index]] += distance;

                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index++);
            }
        );
    }

    public void InsertStatements(int index, List<IStatement> statements)
    {
        CheckStatementIndexInclusive(index);

        int childIndexToInsertAt = index == _statements.Count ? Children.Count : _statements[index].ParentIndex;

        if (index == _statements.Count)
        {
            AttachChildren(childIndexToInsertAt, statements,
                child =>
                {
                    IStatement statement = (child as IStatement)!;
                    _statements.Insert(index, statement);
                    _statementsIndexes.Add(statement, index++);
                });
            return;
        }

        AttachChildren(childIndexToInsertAt, statements,
            child =>
            {
                IStatement statement = (child as IStatement)!;
                _statementsIndexes[_statements[index]] += Children.Count;

                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index++);
            });
    }

    public void InsertStatements(int index, List<IStatement> statements, int startIndexInStatementsForInsertion)
    {
        CheckStatementIndexInclusive(index);

        int childIndexToInsertAt = index == _statements.Count ? Children.Count : _statements[index].ParentIndex;

        if (index == _statements.Count)
        {
            AttachChildren(childIndexToInsertAt, statements, startIndexInStatementsForInsertion,
                child =>
                {
                    IStatement statement = (child as IStatement)!;
                    _statements.Insert(index, statement);
                    _statementsIndexes.Add(statement, index++);
                });
            return;
        }

        AttachChildren(childIndexToInsertAt, statements,
            child =>
            {
                IStatement statement = (child as IStatement)!;
                _statementsIndexes[_statements[index]] += Children.Count;

                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index++);
            });
    }

    public void InsertStatements(int index, List<IStatement> statements, int startIndexInStatementsForInsertion,
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
                    IStatement statement = (child as IStatement)!;
                    _statements.Insert(index, statement);
                    _statementsIndexes.Add(statement, index++);
                });
            return;
        }

        AttachChildren(childIndexToInsertAt, statements,
            child =>
            {
                IStatement statement = (child as IStatement)!;
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
                    IStatement statement = (child as IStatement)!;
                    _statements.Insert(index, statement);
                    _statementsIndexes.Add(statement, index++);
                });
            return;
        }

        AttachChildren(childIndexToInsertAt, statements,
            child =>
            {
                IStatement statement = (child as IStatement)!;
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
                    IStatement statement = (child as IStatement)!;
                    _statements.Insert(index, statement);
                    _statementsIndexes.Add(statement, index++);
                });
            return;
        }

        AttachChildren(childIndexToInsertAt, statements,
            child =>
            {
                IStatement statement = (child as IStatement)!;
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
                    IStatement statement = (child as IStatement)!;
                    _statements.Insert(index, statement);
                    _statementsIndexes.Add(statement, index++);
                });
            return;
        }

        AttachChildren(childIndexToInsertAt, statements,
            child =>
            {
                IStatement statement = (child as IStatement)!;
                _statementsIndexes[_statements[index]] += Children.Count;

                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index++);
            });
    }

    public void PrependStatement(IStatement statement)
    {
        PrependChild(statement);

        foreach (IStatement statementToMove in _statements)
        {
            _statementsIndexes[statementToMove]++;
        }

        _statements.Insert(0, statement);
        _statementsIndexes.Add(statement, 0);
    }

    public void PrependStatements(IEnumerable<IStatement> statements)
    {
        int index = 0;

        if (index == _statements.Count)
        {
            PrependChildren(statements, child =>
            {
                IStatement statement = (child as IStatement)!;
                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index++);
            });
            return;
        }

        List<IStatement> statementsToMove = new List<IStatement>(_statements);
        PrependChildren(statements, child =>
        {
            IStatement statement = (child as IStatement)!;
            statementsToMove.Add(statement);

            _statements.Insert(index, statement);
            _statementsIndexes.Add(statement, index++);
        });

        foreach (IStatement statementToMove in statementsToMove)
        {
            _statementsIndexes[statementToMove] += statementsToMove.Count;
        }
    }

    public void PrependStatements(IEnumerable<IStatement> statements, int startIndexInStatementsForInsertion)
    {
        int index = 0;

        if (index == _statements.Count)
        {
            PrependChildren(statements, startIndexInStatementsForInsertion,
                child =>
                {
                    IStatement statement = (child as IStatement)!;
                    _statements.Insert(index, statement);
                    _statementsIndexes.Add(statement, index++);
                });
            return;
        }

        List<IStatement> moveStatements = [];
        PrependChildren(statements, startIndexInStatementsForInsertion,
            child =>
            {
                IStatement statement = (child as IStatement)!;
                moveStatements.Add(statement);

                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index++);
            });

        foreach (IStatement statementToMove in moveStatements)
        {
            _statementsIndexes[statementToMove] += moveStatements.Count;
        }
    }

    public void PrependStatements(IEnumerable<IStatement> statements, int startIndexInStatementsForInsertion,
        int endIndexInStatementsForInsertion)
    {
        int index = 0;

        if (index == _statements.Count)
        {
            PrependChildren(statements, startIndexInStatementsForInsertion, endIndexInStatementsForInsertion,
                child =>
                {
                    IStatement statement = (child as IStatement)!;
                    _statements.Insert(index, statement);
                    _statementsIndexes.Add(statement, index++);
                });
            return;
        }

        int distance = endIndexInStatementsForInsertion - startIndexInStatementsForInsertion;
        PrependChildren(statements, startIndexInStatementsForInsertion, endIndexInStatementsForInsertion,
            child =>
            {
                IStatement statement = (child as IStatement)!;
                _statementsIndexes[_statements[index]] += distance;

                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index++);
            }
        );
    }

    public void PrependStatements(IList<IStatement> statements)
    {
        int index = 0;

        if (index == _statements.Count)
        {
            PrependChildren(statements, child =>
            {
                IStatement statement = (child as IStatement)!;
                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index++);
            });
            return;
        }

        PrependChildren(statements, child =>
        {
            IStatement statement = (child as IStatement)!;
            _statementsIndexes[_statements[index]] += statements.Count;

            _statements.Insert(index, statement);
            _statementsIndexes.Add(statement, index++);
        });
    }

    public void PrependStatements(IList<IStatement> statements, int startIndexInStatementsForInsertion)
    {
        int index = 0;

        if (index == _statements.Count)
        {
            PrependChildren(statements, startIndexInStatementsForInsertion,
                child =>
                {
                    IStatement statement = (child as IStatement)!;
                    _statements.Insert(index, statement);
                    _statementsIndexes.Add(statement, index++);
                });
            return;
        }

        PrependChildren(statements, child =>
        {
            IStatement statement = (child as IStatement)!;
            _statementsIndexes[_statements[index]] += statements.Count;

            _statements.Insert(index, statement);
            _statementsIndexes.Add(statement, index++);
        });
    }

    public void PrependStatements(IList<IStatement> statements, int startIndexInStatementsForInsertion,
        int endIndexInStatementsForInsertion)
    {
        int index = 0;

        if (index == _statements.Count)
        {
            PrependChildren(statements, startIndexInStatementsForInsertion,
                endIndexInStatementsForInsertion,
                child =>
                {
                    IStatement statement = (child as IStatement)!;
                    _statements.Insert(index, statement);
                    _statementsIndexes.Add(statement, index++);
                });
            return;
        }

        PrependChildren(statements, startIndexInStatementsForInsertion, endIndexInStatementsForInsertion,
            child =>
            {
                IStatement statement = (child as IStatement)!;
                _statementsIndexes[_statements[index]] += statements.Count;

                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index++);
            });
    }

    public void PrependStatements(List<IStatement> statements)
    {
        int index = 0;

        if (index == _statements.Count)
        {
            PrependChildren(statements, child =>
            {
                IStatement statement = (child as IStatement)!;
                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index++);
            });
            return;
        }

        PrependChildren(statements, child =>
        {
            IStatement statement = (child as IStatement)!;
            _statementsIndexes[_statements[index]] += statements.Count;

            _statements.Insert(index, statement);
            _statementsIndexes.Add(statement, index++);
        });
    }

    public void PrependStatements(List<IStatement> statements, int startIndexInStatementsForInsertion)
    {
        int index = 0;

        if (index == _statements.Count)
        {
            PrependChildren(statements, startIndexInStatementsForInsertion,
                child =>
                {
                    IStatement statement = (child as IStatement)!;
                    _statements.Insert(index, statement);
                    _statementsIndexes.Add(statement, index++);
                });
            return;
        }

        PrependChildren(statements, startIndexInStatementsForInsertion,
            child =>
            {
                IStatement statement = (child as IStatement)!;
                _statementsIndexes[_statements[index]] += statements.Count;

                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index++);
            });
    }

    public void PrependStatements(List<IStatement> statements, int startIndexInStatementsForInsertion,
        int endIndexInStatementsForInsertion)
    {
        int index = 0;

        if (index == _statements.Count)
        {
            PrependChildren(statements, startIndexInStatementsForInsertion,
                endIndexInStatementsForInsertion,
                child =>
                {
                    IStatement statement = (child as IStatement)!;
                    _statements.Insert(index, statement);
                    _statementsIndexes.Add(statement, index++);
                });
            return;
        }

        int distance = endIndexInStatementsForInsertion - startIndexInStatementsForInsertion;
        PrependChildren(statements, startIndexInStatementsForInsertion,
            endIndexInStatementsForInsertion, child =>
            {
                IStatement statement = (child as IStatement)!;
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
            PrependChildren<StatementGroup, IStatement>(statements,
                child =>
                {
                    IStatement statement = (child as IStatement)!;
                    _statements.Insert(index, statement);
                    _statementsIndexes.Add(statement, index++);
                });
            return;
        }

        PrependChildren<StatementGroup, IStatement>(statements,
            child =>
            {
                IStatement statement = (child as IStatement)!;
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
            PrependChildren<StatementGroup, IStatement>(statements, startIndexInStatementsForInsertion,
                child =>
                {
                    IStatement statement = (child as IStatement)!;
                    _statementsIndexes.Add(statement, index);
                    _statements.Insert(index++, statement);
                });
            return;
        }

        PrependChildren<StatementGroup, IStatement>(statements, startIndexInStatementsForInsertion,
            child =>
            {
                IStatement statement = (child as IStatement)!;
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
            PrependChildren<StatementGroup, IStatement>(statements, startIndexInStatementsForInsertion,
                endIndexInStatementsForInsertion,
                child =>
                {
                    IStatement statement = (child as IStatement)!;
                    _statements.Insert(index, statement);
                    _statementsIndexes.Add(statement, index++);
                });
            return;
        }

        int distance = endIndexInStatementsForInsertion - startIndexInStatementsForInsertion;
        PrependChildren<StatementGroup, IStatement>(statements, startIndexInStatementsForInsertion,
            endIndexInStatementsForInsertion, child =>
            {
                IStatement statement = (child as IStatement)!;
                _statementsIndexes[_statements[index]] += distance;

                _statements.Insert(index, statement);
                _statementsIndexes.Add(statement, index++);
            }
        );
    }

    public void Add(IStatement item)
    {
        AppendStatement(item);
    }

    public void AppendStatement(IStatement statement)
    {
        AppendChild(statement);
        _statements.Insert(Children.Count, statement);
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

    public void SetStatements(IEnumerable<IStatement> statements)
    {
        throw new NotImplementedException();
    }

    public void SetStatements(IEnumerable<IStatement> statements, int startIndexInStatementsForInsertion)
    {
        throw new NotImplementedException();
    }

    public void SetStatements(IEnumerable<IStatement> statements, int startIndexInStatementsForInsertion,
        int endIndexInStatementsForInsertion)
    {
        throw new NotImplementedException();
    }

    public void SetStatements(IList<IStatement> statements)
    {
        throw new NotImplementedException();
    }

    public void SetStatements(IList<IStatement> statements, int startIndexInStatementsForInsertion)
    {
        throw new NotImplementedException();
    }

    public void SetStatements(IList<IStatement> statements, int startIndexInStatementsForInsertion,
        int endIndexInStatementsForInsertion)
    {
        throw new NotImplementedException();
    }

    public void SetStatements(List<IStatement> statements)
    {
        throw new NotImplementedException();
    }

    public void SetStatements(List<IStatement> statements, int startIndexInStatementsForInsertion)
    {
        throw new NotImplementedException();
    }

    public void SetStatements(List<IStatement> statements, int startIndexInStatementsForInsertion,
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

    public List<IStatement> ReplaceStatements(int indexOfReplacement, IEnumerable<IStatement> statements,
        bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<IStatement> ReplaceStatements(int indexOfReplacement, IEnumerable<IStatement> statements,
        int startIndexInStatementsForReplacement, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<IStatement> ReplaceStatements(int indexOfReplacement, IEnumerable<IStatement> statements,
        int startIndexInStatementsForReplacement, int endIndexInStatementsForReplacement, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<IStatement> ReplaceStatements(int indexOfReplacement, IList<IStatement> statements, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<IStatement> ReplaceStatements(int indexOfReplacement, IList<IStatement> statements,
        int startIndexInStatementsForReplacement, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<IStatement> ReplaceStatements(int indexOfReplacement, IList<IStatement> statements,
        int startIndexInStatementsForReplacement, int endIndexInStatementsForReplacement, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<IStatement> ReplaceStatements(int indexOfReplacement, List<IStatement> statements, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<IStatement> ReplaceStatements(int indexOfReplacement, List<IStatement> statements,
        int startIndexInStatementsForReplacement, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<IStatement> ReplaceStatements(int indexOfReplacement, List<IStatement> statements,
        int startIndexInStatementsForReplacement, int endIndexInStatementsForReplacement, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<IStatement> ReplaceStatements(int indexOfReplacement, StatementGroup statements, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<IStatement> ReplaceStatements(int indexOfReplacement, StatementGroup statements,
        int startIndexInStatementsForReplacement, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<IStatement> ReplaceStatements(int indexOfReplacement, StatementGroup statements,
        int startIndexInStatementsForReplacement, int endIndexInStatementsForReplacement, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public bool Contains(IStatement item) => ContainsStatement(item);

    public bool ContainsStatement(IStatement item) => _statementsIndexes.ContainsKey(item);

    public bool ContainsStatement(Func<IStatement, bool> predicate)
    {
        foreach (IStatement statement in _statements)
        {
            if (predicate(statement))
            {
                return true;
            }
        }

        return false;
    }

    public bool ContainsStatement(Func<IStatement, int, bool> predicate)
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

    public void CopyTo(IStatement[] array, int arrayIndex)
    {
        _statements.CopyTo(array, arrayIndex);
    }

    public void RemoveWhere(Func<IStatement, bool> predicate)
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

    public void RemoveWhere(Func<IStatement, int, bool> predicate)
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
        IStatement statement = _statements[index];
        statement.DetachFromParent();
        _statements.RemoveAt(index);

        _statementsIndexes.Remove(statement);
        for (int i = index; i < _statements.Count; i++)
        {
            IStatement statementToAdjust = _statements[i];
            _statementsIndexes[statementToAdjust] = i;
        }
    }

    public bool Remove(IStatement item)
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
            IStatement statementToAdjust = _statements[i];
            _statementsIndexes[statementToAdjust] = i;
        }

        return true;
    }
    
    // TODO: Remove children or statements but API is unclear presently

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

    public int Count => _statements.Count;

    public bool IsReadOnly => false;

    public int IndexOf(IStatement item)
    {
        return _statementsIndexes.GetValueOrDefault(item, -1);
    }

    public void Insert(int index, IStatement item)
    {
        InsertStatement(index, item);
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

            IStatement statement = IStatement.Parser.ParseWithStart(lexer, subBuffer, offsetInSubBuffer);
            offsetInSubBuffer += statement.GetTextLength();

            children.Add(statement);
            lexer.Advance();
        }
    }

    protected override SwiftInternalNode Duplicate()
    {
        throw new NotImplementedException();
    }

    protected override SwiftInternalNode DuplicateWithoutChildren()
    {
        throw new NotImplementedException();
    }
}