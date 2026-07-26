using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.CodeBlocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.DoStatements.CatchClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.FunctionTypes.ThrowClauses;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.DoStatements;

public class DoStatement : SwiftCompositeNode, IDoStatement
{
    public Do Do { get; }
    
    public IThrowsClause? ThrowsClause { get; }
    
    public ICodeBlock CodeBlock { get; }
    
    public ICatchClauseList CatchClauseList { get; }

    internal DoStatement(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children, 
        Do @do, IThrowsClause? throwsClause, ICodeBlock codeBlock, ICatchClauseList catchClauseList)
        : base(buffer, children)
    {
        Do = @do;
        ThrowsClause = throwsClause;
        CodeBlock = codeBlock;
        CatchClauseList = catchClauseList;
    }

    IReadOnlyThrowsClause? IReadOnlyDoStatement.ThrowsClause => ThrowsClause;

    IReadOnlyCodeBlock IReadOnlyDoStatement.CodeBlock => CodeBlock;

    IReadOnlyCatchClauseList IReadOnlyDoStatement.CatchClauseList => CatchClauseList;

    public IReadOnlyList<ICatchClause> CatchClauses => CatchClauseList.CatchClauses;

    public int Count => CatchClauseList.Count;

    public bool IsReadOnly => false;

    public new ICatchClause this[int index]
    {
        get => CatchClauseList[index];
        set => CatchClauseList[index] = value;
    }

    public IEnumerator<ICatchClause> GetEnumerator()
    {
        return CatchClauseList.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public bool Contains(ICatchClause item)
    {
        return CatchClauseList.Contains(item);
    }

    public int IndexOf(ICatchClause item)
    {
        return CatchClauseList.IndexOf(item);
    }

    public void CopyTo(ICatchClause[] array, int arrayIndex)
    {
        CatchClauseList.CopyTo(array, arrayIndex);
    }

    public void Add(ICatchClause item)
    {
        CatchClauseList.Add(item);
    }

    public void Clear()
    {
        CatchClauseList.Clear();
    }

    public bool Remove(ICatchClause item)
    {
        return CatchClauseList.Remove(item);
    }

    public void Insert(int index, ICatchClause item)
    {
        CatchClauseList.Insert(index, item);
    }

    public void RemoveAt(int index)
    {
        CatchClauseList.RemoveAt(index);
    }

    public void SetThrowsClauseTo(IThrowsClause? throwsClause)
    {
        throw new NotImplementedException();
    }

    public void RemoveThrowsClause()
    {
        throw new NotImplementedException();
    }

    public void ChangeCodeBlock(ICodeBlock newCodeBlock)
    {
        throw new NotImplementedException();
    }

    public void ChangeClauseList(ICatchClauseList newCatchClauseList)
    {
        throw new NotImplementedException();
    }
}
