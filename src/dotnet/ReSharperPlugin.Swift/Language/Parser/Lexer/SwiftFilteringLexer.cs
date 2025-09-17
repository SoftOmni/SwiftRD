using System.Collections;
using System.Collections.Generic;
using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Base;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer;

public class SwiftFilteringLexer : FilteringLexer, ICollection<int>
{
    public SwiftLexer CoreLexer { get; }

    public ISet<int> SkippedIndexes { get; }

    public SwiftFilteringLexer(IBuffer buffer) : this(new SwiftLexer(buffer))
    { }

    public SwiftFilteringLexer(IBuffer buffer, ISet<SwiftTokenNodeType> skippedIndexes) : this(new SwiftLexer(buffer),
        skippedIndexes)
    { }

    public SwiftFilteringLexer(IBuffer buffer, int eofPosition) : this(buffer, eofPosition,
        new HashSet<SwiftTokenNodeType>())
    { }

    public SwiftFilteringLexer(IBuffer buffer, int eofPosition, ISet<SwiftTokenNodeType> skippedIndexes) : this(
        new SwiftLexer(buffer, eofPosition), skippedIndexes)
    { }

    public SwiftFilteringLexer(SwiftLexer lexer)
        : this(lexer, new HashSet<SwiftTokenNodeType>())
    { }

    public SwiftFilteringLexer(SwiftLexer lexer, ISet<SwiftTokenNodeType> skippedIndexes) : base(lexer)
    {
        CoreLexer = lexer;
        SkippedIndexes = new HashSet<int>();
        foreach (SwiftTokenNodeType swiftToken in skippedIndexes)
        {
            SkippedIndexes.Add(swiftToken.Index);
        }
    }

    public static explicit operator SwiftLexer(SwiftFilteringLexer filteringLexer)
    {
        return filteringLexer.CoreLexer;
    }

    public SwiftLexer AsSwiftLexer()
    {
        return CoreLexer;
    }

    protected override bool Skip(TokenNodeType tokenType)
    {
        if (tokenType is not SwiftTokenNodeType swiftTokenNodeType)
        {
            return false;
        }

        if (!SkippedIndexes.Contains(swiftTokenNodeType.Index))
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