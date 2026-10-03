using System.Collections;
using System.Collections.Generic;
using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Base;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer;

public class ObjectiveCxxFilteringLexer : FilteringLexer, ICollection<int>
{
    public ObjectiveCxxLexer CoreLexer { get; }

    public ISet<int> SkippedIndexes { get; }

    public ObjectiveCxxFilteringLexer(IBuffer buffer) : this(new ObjectiveCxxLexer(buffer))
    { }

    public ObjectiveCxxFilteringLexer(IBuffer buffer, ISet<ObjectiveCxxTokenNodeType> skippedIndexes) : this(new ObjectiveCxxLexer(buffer),
        skippedIndexes)
    { }

    public ObjectiveCxxFilteringLexer(IBuffer buffer, int eofPosition) : this(buffer, eofPosition,
        new HashSet<ObjectiveCxxTokenNodeType>())
    { }

    public ObjectiveCxxFilteringLexer(IBuffer buffer, int eofPosition, ISet<ObjectiveCxxTokenNodeType> skippedIndexes) : this(
        new ObjectiveCxxLexer(buffer, eofPosition), skippedIndexes)
    { }

    public ObjectiveCxxFilteringLexer(ObjectiveCxxLexer lexer)
        : this(lexer, new HashSet<ObjectiveCxxTokenNodeType>())
    { }

    public ObjectiveCxxFilteringLexer(ObjectiveCxxLexer lexer, ISet<ObjectiveCxxTokenNodeType> skippedIndexes) : base(lexer)
    {
        CoreLexer = lexer;
        SkippedIndexes = new HashSet<int>();
        foreach (ObjectiveCxxTokenNodeType objectiveCToken in skippedIndexes)
        {
            SkippedIndexes.Add(objectiveCToken.Index);
        }
    }

    public static explicit operator ObjectiveCxxLexer(ObjectiveCxxFilteringLexer filteringLexer)
    {
        return filteringLexer.CoreLexer;
    }

    public ObjectiveCxxLexer AsObjectiveCLexer()
    {
        return CoreLexer;
    }

    protected override bool Skip(TokenNodeType tokenType)
    {
        if (tokenType is not ObjectiveCxxTokenNodeType objectiveCTokenNodeType)
        {
            return false;
        }

        if (!SkippedIndexes.Contains(objectiveCTokenNodeType.Index))
        {
            return false;
        }
        
        CoreLexer.Advance();
        return true;
    }

    public IEnumerator<int> GetEnumerator()
    {
        return SkippedIndexes.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(int item)
    {
        SkippedIndexes.Add(item);
    }

    public void Clear()
    {
        SkippedIndexes.Clear();
    }

    public bool Contains(int item)
    {
        return SkippedIndexes.Contains(item);
    }

    public void CopyTo(int[] array, int arrayIndex)
    {
        SkippedIndexes.CopyTo(array, arrayIndex);
    }

    public bool Remove(int item)
    {
        return SkippedIndexes.Remove(item);
    }

    public int Count => SkippedIndexes.Count;

    public bool IsReadOnly => false;
}