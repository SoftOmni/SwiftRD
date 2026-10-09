using System.Collections;
using System.Collections.Generic;
using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Base;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer;

public class ObjectiveCXXFilteringLexer : FilteringLexer, ICollection<int>
{
    public ObjectiveCXXLexer CoreLexer { get; }

    public ISet<int> SkippedIndexes { get; }

    public ObjectiveCXXFilteringLexer(IBuffer buffer) : this(new ObjectiveCXXLexer(buffer))
    { }

    public ObjectiveCXXFilteringLexer(IBuffer buffer, ISet<ObjectiveCXXTokenNodeType> skippedIndexes) : this(new ObjectiveCXXLexer(buffer),
        skippedIndexes)
    { }

    public ObjectiveCXXFilteringLexer(IBuffer buffer, int eofPosition) : this(buffer, eofPosition,
        new HashSet<ObjectiveCXXTokenNodeType>())
    { }

    public ObjectiveCXXFilteringLexer(IBuffer buffer, int eofPosition, ISet<ObjectiveCXXTokenNodeType> skippedIndexes) : this(
        new ObjectiveCXXLexer(buffer, eofPosition), skippedIndexes)
    { }

    public ObjectiveCXXFilteringLexer(ObjectiveCXXLexer lexer)
        : this(lexer, new HashSet<ObjectiveCXXTokenNodeType>())
    { }

    public ObjectiveCXXFilteringLexer(ObjectiveCXXLexer lexer, ISet<ObjectiveCXXTokenNodeType> skippedIndexes) : base(lexer)
    {
        CoreLexer = lexer;
        SkippedIndexes = new HashSet<int>();
        foreach (ObjectiveCXXTokenNodeType objectiveCToken in skippedIndexes)
        {
            SkippedIndexes.Add(objectiveCToken.Index);
        }
    }

    public static explicit operator ObjectiveCXXLexer(ObjectiveCXXFilteringLexer filteringLexer)
    {
        return filteringLexer.CoreLexer;
    }

    public ObjectiveCXXLexer AsObjectiveCLexer()
    {
        return CoreLexer;
    }

    protected override bool Skip(TokenNodeType tokenType)
    {
        if (tokenType is not ObjectiveCXXTokenNodeType objectiveCTokenNodeType)
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