using System.Collections;
using System.Collections.Generic;
using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Base;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer;

public class ObjectiveCFilteringLexer : FilteringLexer, ICollection<int>
{
    public ObjectiveCLexer CoreLexer { get; }

    public ISet<int> SkippedIndexes { get; }

    public ObjectiveCFilteringLexer(IBuffer buffer) : this(new ObjectiveCLexer(buffer))
    { }

    public ObjectiveCFilteringLexer(IBuffer buffer, ISet<ObjectiveCTokenNodeType> skippedIndexes) : this(new ObjectiveCLexer(buffer),
        skippedIndexes)
    { }

    public ObjectiveCFilteringLexer(IBuffer buffer, int eofPosition) : this(buffer, eofPosition,
        new HashSet<ObjectiveCTokenNodeType>())
    { }

    public ObjectiveCFilteringLexer(IBuffer buffer, int eofPosition, ISet<ObjectiveCTokenNodeType> skippedIndexes) : this(
        new ObjectiveCLexer(buffer, eofPosition), skippedIndexes)
    { }

    public ObjectiveCFilteringLexer(ObjectiveCLexer lexer)
        : this(lexer, new HashSet<ObjectiveCTokenNodeType>())
    { }

    public ObjectiveCFilteringLexer(ObjectiveCLexer lexer, ISet<ObjectiveCTokenNodeType> skippedIndexes) : base(lexer)
    {
        CoreLexer = lexer;
        SkippedIndexes = new HashSet<int>();
        foreach (ObjectiveCTokenNodeType objectiveCToken in skippedIndexes)
        {
            SkippedIndexes.Add(objectiveCToken.Index);
        }
    }

    public static explicit operator ObjectiveCLexer(ObjectiveCFilteringLexer filteringLexer)
    {
        return filteringLexer.CoreLexer;
    }

    public ObjectiveCLexer AsObjectiveCLexer()
    {
        return CoreLexer;
    }

    protected override bool Skip(TokenNodeType tokenType)
    {
        if (tokenType is not ObjectiveCTokenNodeType objectiveCTokenNodeType)
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