using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.CodeBlocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.Conditions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Ifs;

public class IfStatement : SwiftCompositeNode, IIfStatement
{
    private readonly List<If> _ifs;

    private readonly List<IConditionList> _conditions;

    private readonly List<ICodeBlock> _codeBlocks;

    private readonly List<Else> _nonFinalElses;

    public Else? FinalElse { get; }

    internal IfStatement(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        If @if, IConditionList ifCondition, List<ICodeBlock> codeBlocks)
        : base(buffer, children)
    {
        _ifs = [@if];
        _conditions = [ifCondition];
        _nonFinalElses = [];

        _codeBlocks = codeBlocks;
    }

    internal IfStatement(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        If @if, List<IConditionList> conditions, Else finalElse, List<ICodeBlock> codeBlocks)
        : base(buffer, children)
    {
        _ifs = [@if];
        _conditions = conditions;
        FinalElse = finalElse;
        _nonFinalElses = [];

        _codeBlocks = codeBlocks;
    }

    internal IfStatement(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        List<If> ifs, List<Else> nonFinalElses, List<IConditionList> conditions, List<ICodeBlock> codeBlocks)
        : base(buffer, children)
    {
        _ifs = ifs;
        _conditions = conditions;
        FinalElse = null;
        _nonFinalElses = nonFinalElses;

        _codeBlocks = codeBlocks;
    }

    internal IfStatement(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        List<If> ifs, List<Else> nonFinalElses, List<IConditionList> conditions, Else finalElse,
        List<ICodeBlock> codeBlocks)
        : base(buffer, children)
    {
        _ifs = ifs;
        _conditions = conditions;
        FinalElse = finalElse;
        _nonFinalElses = nonFinalElses;

        _codeBlocks = codeBlocks;
    }

    public If If => _ifs[0];

    public ICodeBlock FirstIfCodeBlock => _codeBlocks[0];

    IReadOnlyCodeBlock IReadOnlyIfStatement.FirstIfCodeBlock => FirstIfCodeBlock;

    public IConditionList FirstIfCondition => _conditions[0];

    IReadOnlyConditionList IReadOnlyIfStatement.FirstIfCondition => FirstIfCondition;

    public IReadOnlyList<IConditionList> Conditions => _conditions;

    IReadOnlyList<IReadOnlyConditionList> IReadOnlyIfStatement.Conditions => Conditions;

    public IReadOnlyConditionList? FinalElseCondition => FinalElse is null ? null : _conditions[_conditions.Count - 1];

    public ICodeBlock? FinalElseCodeBlock => FinalElse is null ? null : _codeBlocks[_conditions.Count - 1];

    IReadOnlyCodeBlock? IReadOnlyIfStatement.FinalElseCodeBlock => FinalElseCodeBlock;

    public IReadOnlyList<ICodeBlock> CodeBlocks => _codeBlocks;

    IReadOnlyList<IReadOnlyCodeBlock> IReadOnlyIfStatement.CodeBlocks => CodeBlocks;

    public int Count => _conditions.Count;

    public bool IsReadOnly => false;

    public new IConditionList this[int index]
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

    IReadOnlyConditionList IReadOnlyList<IReadOnlyConditionList>.this[int index]
        => _conditions[index];

    public IEnumerator<IConditionList> GetEnumerator()
    {
        return _conditions.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    IEnumerator<IReadOnlyConditionList> IEnumerable<IReadOnlyConditionList>.GetEnumerator()
    {
        return GetEnumerator();
    }

    public ICodeBlock GetElseIfCodeBlockAt(int index)
    {
        return _codeBlocks[index + 1];
    }

    IReadOnlyCodeBlock IReadOnlyIfStatement.GetElseIfCodeBlockAt(int index)
    {
        return GetElseIfCodeBlockAt(index);
    }

    public IConditionList GetElseIfConditionAt(int index)
    {
        return _conditions[index + 1];
    }

    IReadOnlyConditionList IReadOnlyIfStatement.GetElseIfConditionAt(int index)
    {
        return GetElseIfConditionAt(index);
    }

    public void SetElseIfConditionAt(int index, ICodeBlock codeBlock)
    {
        throw new NotImplementedException();
    }

    public void SetElseIfConditionAt(int index, IConditionList condition)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<(Else @else, If @if, IConditionList condition, ICodeBlock codeBlock)> GetElseIfEnumerator()
    {
        return new ElseIfEnumerator(this);
    }

    IEnumerator<(Else @else, If @if, IReadOnlyConditionList condition, IReadOnlyCodeBlock codeBlock)>
        IReadOnlyIfStatement.GetElseIfEnumerator()
    {
        return new ElseIfEnumerator(this);
    }

    public bool Contains(IConditionList item)
    {
        return _conditions.Contains(item);
    }

    public int IndexOf(IConditionList item)
    {
        return _conditions.IndexOf(item);
    }

    public void CopyTo(IConditionList[] array, int arrayIndex)
    {
        _conditions.CopyTo(array, arrayIndex);
    }

    public void ChangeFirstIfCondition(IConditionList newCondition)
    {
        throw new NotImplementedException();
    }

    public void ChangeFirstIfCodeBlock(ICodeBlock newCodeBlock)
    {
        throw new NotImplementedException();
    }

    public void AddElseIfCondition(int index, IConditionList condition, ICodeBlock codeBlock)
    {
        throw new NotImplementedException();
    }

    public void RemoveElseIfCondition(int index)
    {
        throw new NotImplementedException();
    }

    public void SetFinalElseCodeBlock(ICodeBlock newCodeBlock)
    {
        throw new NotImplementedException();
    }

    public void RemoveFinalElse()
    {
        throw new NotImplementedException();
    }

    public void Add(IConditionList item)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Remove(IConditionList item)
    {
        throw new NotImplementedException();
    }

    public void Insert(int index, IConditionList item)
    {
        throw new NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new NotImplementedException();
    }
    
    

    public struct ElseIfEnumerator(IfStatement ifStatement)
        : IEnumerator<(Else @else, If @if, IConditionList condition, ICodeBlock codeBlock)>,
            IEnumerator<(Else @else, If @if, IReadOnlyConditionList condition, IReadOnlyCodeBlock codeBlock)>
    {
        private int _index = 0;

        public bool MoveNext()
        {
            if (_index + 1 >= ifStatement._conditions.Count)
            {
                return false;
            }

            _index++;
            return true;
        }


        public (Else @else, If @if, IConditionList condition, ICodeBlock codeBlock) Current => GetCurrent();

        (Else @else, If @if, IReadOnlyConditionList condition, IReadOnlyCodeBlock codeBlock)
            IEnumerator<(Else @else, If @if, IReadOnlyConditionList condition, IReadOnlyCodeBlock codeBlock)>.Current => Current;

        object IEnumerator.Current => Current;

        private (Else @else, If @if, IConditionList condition, ICodeBlock codeBlock) GetCurrent()
        {
            IConditionList condition = ifStatement._conditions[_index + 1];
            If @if = ifStatement._ifs[_index + 1];
            Else @else = ifStatement._nonFinalElses[_index];
            ICodeBlock codeBlock = ifStatement._codeBlocks[_index + 1];

            return (@else, @if, condition, codeBlock);
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