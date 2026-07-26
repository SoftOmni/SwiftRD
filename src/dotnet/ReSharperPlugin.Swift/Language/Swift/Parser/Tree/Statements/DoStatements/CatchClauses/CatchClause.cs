using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.CodeBlocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.DoStatements.CatchClauses.CatchPatterns;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.DoStatements.CatchClauses;

public class CatchClause : SwiftCompositeNode, ICatchClause
{
    public Catch Catch { get; }

    public ICatchPatternList CatchPatternList { get; }

    public ICodeBlock CodeBlock { get; }

    internal CatchClause(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        Catch @catch, ICatchPatternList catchPatternList, ICodeBlock codeBlock)
        : base(buffer, children)
    {
        CatchPatternList = catchPatternList;
        CodeBlock = codeBlock;
        Catch = @catch;
    }

    IReadOnlyCatchPatternList IReadOnlyCatchClause.CatchPatternList => CatchPatternList;

    IReadOnlyCodeBlock IReadOnlyCatchClause.CodeBlock => CodeBlock;

    public IReadOnlyList<ICatchPattern> CatchPatterns => CatchPatternList.CatchPatterns;
    
    IReadOnlyList<IReadOnlyCatchPattern> IReadOnlyCatchClause.CatchPatterns => CatchPatterns;

    public int Count => CatchPatternList.Count;

    public bool IsReadOnly => CatchPatternList.IsReadOnly;

    public new ICatchPattern this[int index]
    {
        get => CatchPatternList[index];
        set => CatchPatternList[index] = value;
    }

    IReadOnlyCatchPattern IReadOnlyList<IReadOnlyCatchPattern>.this[int index]
        => CatchPatternList[index];

    public IEnumerator<ICatchPattern> GetEnumerator()
    {
        return CatchPatternList.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    IEnumerator<IReadOnlyCatchPattern> IEnumerable<IReadOnlyCatchPattern>.GetEnumerator()
    {
        return GetEnumerator();
    }

    public bool Contains(ICatchPattern item)
    {
        return CatchPatternList.Contains(item);
    }

    public int IndexOf(ICatchPattern item)
    {
        return CatchPatternList.IndexOf(item);
    }

    public void CopyTo(ICatchPattern[] array, int arrayIndex)
    {
        CatchPatternList.CopyTo(array, arrayIndex);
    }

    public void Add(ICatchPattern item)
    {
        CatchPatternList.Add(item);
    }

    public void Clear()
    {
        CatchPatternList.Clear();
    }

    public bool Remove(ICatchPattern item)
    {
        return CatchPatternList.Remove(item);
    }

    public void Insert(int index, ICatchPattern item)
    {
        CatchPatternList.Insert(index, item);
    }

    public void RemoveAt(int index)
    {
        CatchPatternList.RemoveAt(index);
    }

    public void ChangeCatchPatternList(ICatchPatternList newCatchPatternList)
    {
        throw new NotImplementedException();
    }

    public void ChangeCodeBlock(ICodeBlock newCodeBlock)
    {
        throw new NotImplementedException();
    }
}
