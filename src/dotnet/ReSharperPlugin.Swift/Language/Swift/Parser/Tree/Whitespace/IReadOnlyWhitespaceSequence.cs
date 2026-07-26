using System;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Whitespace;

public interface IReadOnlyWhitespaceSequence : IReadOnlyWhitespaceNode
{
    public bool ContainsSpaces { get; }

    public bool ContainsTabs { get; }

    public bool IsOnlySpaces { get; }

    public bool IsOnlyTabs { get; }

    public bool IsMixed { get; }

    public bool IsEmpty { get; }

    public int TabWidth { get; }

    public bool IsTabWidthDefault { get; }

    public bool IsTabWidthSet { get; }

    public int TotalSpaceCount { get; }

    public int TotalTabCount { get; }

    public int GetTabWidth();

    public enum TabWidthRounding
    {
        Floor,
        Ceiling,
        RoundingUpIfMiddle,
        RoundingDownIfMiddle
    }

    public bool Contains(char character);

    public bool Contains(char character, int startIndex);

    public bool Contains(char character, int startIndex, int endIndex);

    public bool Contains(Func<char, bool> predicate);

    public bool Contains(Func<char, bool> predicate, int startIndex);

    public bool Contains(Func<char, bool> predicate, int startIndex, int endIndex);
    
    public bool Contains(Func<int, bool> predicate);

    public bool Contains(Func<int, bool> predicate, int startIndex);

    public bool Contains(Func<int, bool> predicate, int startIndex, int endIndex);

    public bool Contains(Func<int, char, bool> predicate);

    public bool Contains(Func<int, char, bool> predicate, int startIndex);

    public bool Contains(Func<int, char, bool> predicate, int startIndex, int endIndex);
}
