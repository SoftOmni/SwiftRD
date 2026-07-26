using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Ifs;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ConditionalExpressions.IfExpressions;

public class ElseExpression : SwiftCompositeNode, IElseExpression
{
    public Else Else { get; }
    
    public LeftCurlyBrace LeftCurlyBrace { get; }

    private readonly List<IStatement> _statements;
    
    public RightCurlyBrace RightCurlyBrace { get; }

    internal ElseExpression(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        Else @else, LeftCurlyBrace leftCurlyBrace, List<IStatement> statements,
        RightCurlyBrace rightCurlyBrace)
        : base(buffer, children)
    {
        Else = @else;
        LeftCurlyBrace = leftCurlyBrace;
        _statements = statements;
        RightCurlyBrace = rightCurlyBrace;
        
        ReturnType = UnknownType.Instance;
    }

    public IReadOnlyList<IStatement> Statements => _statements;

    IReadOnlyList<IReadOnlyStatement> IReadOnlyElseExpression.Statements => Statements;

    public IReadOnlyType ReturnType { get; }

    public int Count => _statements.Count;

    public bool IsReadOnly => false;

    IStatement IElseExpression.this[int index] => _statements[index];

    IReadOnlyStatement IReadOnlyList<IReadOnlyStatement>.this[int index] => _statements[index];

    IStatement IList<IStatement>.this[int index]
    {
        get => _statements[index];
        set => throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return _statements.GetEnumerator();
    }

    IEnumerator<IStatement> IElseExpression.GetEnumerator()
    {
        return _statements.GetEnumerator();
    }

    IEnumerator<IStatement> IEnumerable<IStatement>.GetEnumerator()
    {
        return _statements.GetEnumerator();
    }


    IEnumerator<IReadOnlyStatement> IEnumerable<IReadOnlyStatement>.GetEnumerator()
    {
        return _statements.GetEnumerator();
    }

    public bool Contains(IStatement item)
    {
        return _statements.Contains(item);
    }

    public int IndexOf(IStatement item)
    {
        return _statements.IndexOf(item);
    }

    public void CopyTo(IStatement[] array, int arrayIndex)
    {
        _statements.CopyTo(array, arrayIndex);
    }

    public void Add(IStatement item)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Remove(IStatement item)
    {
        throw new NotImplementedException();
    }

    public void Insert(int index, IStatement item)
    {
        throw new NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new NotImplementedException();
    }
}
