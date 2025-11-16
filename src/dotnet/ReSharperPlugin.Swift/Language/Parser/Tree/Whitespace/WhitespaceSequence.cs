using System;
using System.Collections.Generic;
using System.Text;
using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Formatting;
using ReSharperPlugin.Swift.Language.Parser.Lexer;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Whitespace;

public class WhitespaceSequence : SwiftLeafNode
{
    public const char Space = SwiftLexer.Space;

    public const char Tab = SwiftLexer.HorizontalTab;

    private readonly SortedSet<int> _spaces = [];

    private readonly SortedSet<int> _tabs = [];

    internal WhitespaceSequence(IEditableBuffer buffer)
        : base(buffer, NodeTypes.NodeTypes.Whitespace)
    {
        CountElements(buffer);
        TabWidth = FormattingConfiguration.TabWidth;
    }

    internal WhitespaceSequence(IEditableBuffer buffer, int tabWidth)
        : base(buffer, NodeTypes.NodeTypes.Whitespace)
    {
        CountElements(buffer);
        TabWidth = tabWidth;
    }

    internal WhitespaceSequence(IEditableBuffer buffer, int tabWidth, SortedSet<int> spaces, SortedSet<int> tabs)
        : base(buffer, NodeTypes.NodeTypes.Whitespace)
    {
        TabWidth = tabWidth;
        _spaces = new SortedSet<int>(spaces);
        _tabs = new SortedSet<int>(tabs);
    }

    internal WhitespaceSequence(ISwiftNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Whitespace)
    {
        CountElements(buffer);
        TabWidth = FormattingConfiguration.TabWidth;
    }

    internal WhitespaceSequence(ISwiftNode parent, IEditableBuffer buffer, int tabWidth)
        : base(parent, buffer, NodeTypes.NodeTypes.Whitespace)
    {
        CountElements(buffer);
        TabWidth = tabWidth;
    }

    private void CountElements(IEditableBuffer buffer)
        => CountElements(0, buffer);

    private void CountElements(int offset, IEditableBuffer buffer)
    {
        for (int index = 0; index < buffer.Length; index++)
        {
            if (buffer[index] == SwiftLexer.Space)
            {
                _spaces.Add(offset + index);
            }
            else
            {
                _tabs.Add(offset + index);
            }
        }
    }

    public bool ContainsSpaces => _spaces.Count == 0;

    public bool ContainsTabs => _tabs.Count == 0;

    public bool IsOnlySpaces => !ContainsTabs;

    public bool IsOnlyTabs => !ContainsSpaces;

    public bool IsMixed => ContainsSpaces && ContainsTabs;

    public bool IsEmpty => _spaces.Count == 0 && _tabs.Count == 0;

    public int TabWidth { get; private set; }

    public bool IsTabWidthDefault => TabWidth == FormattingConfiguration.TabWidth;

    public bool IsTabWidthSet => TabWidth != FormattingConfiguration.TabWidth;

    public int TotalSpaceCount => _spaces.Count;

    public int TotalTabCount => _tabs.Count;

    public void MakeOnlyTabs(TabWidthRounding rounding = TabWidthRounding.RoundingUpIfMiddle)
    {
        MakeOnlyTabs(TabWidth, rounding);
    }

    public void MakeOnlyTabs(int tabWidth, TabWidthRounding rounding = TabWidthRounding.RoundingUpIfMiddle)
    {
        int totalSpaceCount = _spaces.Count + _tabs.Count * tabWidth;
        if (totalSpaceCount % tabWidth == 0)
        {
            PerformChange();
            return;
        }

        switch (rounding)
        {
            case TabWidthRounding.Floor:
                totalSpaceCount -= totalSpaceCount % tabWidth;
                PerformChange();
                return;
            case TabWidthRounding.Ceiling:
                totalSpaceCount += tabWidth - totalSpaceCount % tabWidth;
                PerformChange();
                return;
        }

        int upperSpaceCount = totalSpaceCount + tabWidth - totalSpaceCount % tabWidth;
        double midPoint = (double)(upperSpaceCount - totalSpaceCount) / 2;
        double normalMidPoint = (double)tabWidth / 2;

        if (midPoint > normalMidPoint && Math.Abs(midPoint - normalMidPoint) > 0.25)
        {
            totalSpaceCount += tabWidth - totalSpaceCount % tabWidth;
        }
        else if (midPoint < normalMidPoint && Math.Abs(midPoint - normalMidPoint) > 0.25)
        {
            totalSpaceCount -= totalSpaceCount % tabWidth;
        }
        else if (rounding is TabWidthRounding.RoundingUpIfMiddle)
        {
            totalSpaceCount += tabWidth;
        }
        else
        {
            totalSpaceCount -= totalSpaceCount % tabWidth;
        }

        PerformChange();
        return;

        void PerformChange()
        {
            EditableBuffer.Remove(0, EditableBuffer.Length);
            _spaces.Clear();

            int tabCount = totalSpaceCount / tabWidth;
            for (int i = 0; i < tabCount; i++)
            {
                EditableBuffer.Insert(EditableBuffer.Length, "\t");
                _tabs.Add(i * tabWidth);
            }
        }
    }

    public void MakeOnlySpaces()
    {
        MakeOnlySpaces(TabWidth);
    }

    public void MakeOnlySpaces(int tabWidth)
    {
        string spaces = new(' ', tabWidth);
        foreach (int tabIndex in _tabs)
        {
            EditableBuffer.Replace(tabIndex, 1, spaces);
            for (int i = 0; i < tabWidth; i++)
            {
                _spaces.Add(tabIndex + i);
            }
        }

        _tabs.Clear();
    }

    public int GetTabWidth() => TabWidth;

    public void SetTabWidthToDefault()
    {
        TabWidth = FormattingConfiguration.TabWidth;
    }

    public void SetTabWidth(int tabWidth)
    {
        TabWidth = tabWidth;
    }

    protected override ISwiftNode Clone()
    {
        return new WhitespaceSequence(EditableBufferExtensions.CloneBuffer(EditableBuffer), TabWidth, _spaces, _tabs);
    }

    public enum TabWidthRounding
    {
        Floor,
        Ceiling,
        RoundingUpIfMiddle,
        RoundingDownIfMiddle
    }

    public static WhitespaceSequence CreateFromValue(IBuffer value)
    {
        IEditableBuffer bufferToSet = CheckNewUserValue(value);
        return new WhitespaceSequence(bufferToSet);
    }

    public static WhitespaceSequence CreateFromValueWithTabWidth(IBuffer value, int tabWidth)
    {
        CheckTabWidth(tabWidth);
        IEditableBuffer bufferToSet = CheckNewUserValue(value);
        return new WhitespaceSequence(bufferToSet, tabWidth);
    }

    public static WhitespaceSequence CreateFromValue(IBuffer value, int startIndex)
    {
        IEditableBuffer bufferToSet = CheckNewUserValue(value, startIndex);
        return new WhitespaceSequence(bufferToSet);
    }

    public static WhitespaceSequence CreateFromValueWithTabWidth(IBuffer value, int startIndex, int tabWidth)
    {
        CheckTabWidth(tabWidth);
        IEditableBuffer bufferToSet = CheckNewUserValue(value, startIndex);
        return new WhitespaceSequence(bufferToSet, tabWidth);
    }

    public static WhitespaceSequence CreateFromValue(IBuffer value, int startIndex, int endIndex)
    {
        IEditableBuffer bufferToSet = CheckNewUserValue(value, startIndex, endIndex);
        return new WhitespaceSequence(bufferToSet);
    }

    public static WhitespaceSequence CreateFromValueWithTabWidth(IBuffer value, int startIndex, int endIndex,
        int tabWidth)
    {
        CheckTabWidth(tabWidth);
        IEditableBuffer bufferToSet = CheckNewUserValue(value, startIndex, endIndex);
        return new WhitespaceSequence(bufferToSet, tabWidth);
    }

    public static WhitespaceSequence CreateFromValue(ISwiftNode parent, IBuffer value)
    {
        IEditableBuffer bufferToSet = CheckNewUserValue(value);
        return new WhitespaceSequence(parent, bufferToSet);
    }

    public static WhitespaceSequence CreateFromValueWithTabWidth(ISwiftNode parent, IBuffer value, int tabWidth)
    {
        CheckTabWidth(tabWidth);
        IEditableBuffer bufferToSet = CheckNewUserValue(value);
        return new WhitespaceSequence(parent, bufferToSet, tabWidth);
    }

    public static WhitespaceSequence CreateFromValue(ISwiftNode parent, IBuffer value, int startIndex)
    {
        IEditableBuffer bufferToSet = CheckNewUserValue(value, startIndex);
        return new WhitespaceSequence(parent, bufferToSet);
    }

    public static WhitespaceSequence CreateFromValueWithTabWidth(ISwiftNode parent, IBuffer value, int startIndex,
        int tabWidth)
    {
        CheckTabWidth(tabWidth);
        IEditableBuffer bufferToSet = CheckNewUserValue(value, startIndex);
        return new WhitespaceSequence(parent, bufferToSet, tabWidth);
    }

    public static WhitespaceSequence CreateFromValue(ISwiftNode parent, IBuffer value, int startIndex, int endIndex)
    {
        IEditableBuffer bufferToSet = CheckNewUserValue(value, startIndex, endIndex);
        return new WhitespaceSequence(parent, bufferToSet);
    }

    public static WhitespaceSequence CreateFromValueWithTabWidth(ISwiftNode parent, IBuffer value, int startIndex,
        int endIndex, int tabWidth)
    {
        CheckTabWidth(tabWidth);
        IEditableBuffer bufferToSet = CheckNewUserValue(value, startIndex, endIndex);
        return new WhitespaceSequence(parent, bufferToSet, tabWidth);
    }

    internal static WhitespaceSequence CreateFromValue(IEditableBuffer value, bool setWithoutCopy = false)
    {
        if (setWithoutCopy)
        {
            CheckNewUserValueSimplified(value);
            return new WhitespaceSequence(value);
        }

        IEditableBuffer bufferToSet = CheckNewUserValue(value);
        return new WhitespaceSequence(bufferToSet);
    }

    internal static WhitespaceSequence CreateFromValueWithTabWidth(IEditableBuffer value, int tabWidth,
        bool setWithoutCopy = false)
    {
        CheckTabWidth(tabWidth);
        if (setWithoutCopy)
        {
            CheckNewUserValueSimplified(value);
            return new WhitespaceSequence(value, tabWidth);
        }

        IEditableBuffer bufferToSet = CheckNewUserValue(value);
        return new WhitespaceSequence(bufferToSet, tabWidth);
    }

    internal static WhitespaceSequence CreateFromValue(IEditableBuffer value, int startIndex,
        bool setWithoutCopy = false)
    {
        if (setWithoutCopy)
        {
            CheckNewUserValueSimplified(value, startIndex);
            return new WhitespaceSequence(value);
        }

        IEditableBuffer bufferToSet = CheckNewUserValue(value, startIndex);
        return new WhitespaceSequence(bufferToSet);
    }

    internal static WhitespaceSequence CreateFromValueWithTabWidth(IEditableBuffer value, int startIndex, int tabWidth,
        bool setWithoutCopy = false)
    {
        CheckTabWidth(tabWidth);
        if (setWithoutCopy)
        {
            CheckNewUserValueSimplified(value, startIndex);
            return new WhitespaceSequence(value, tabWidth);
        }

        IEditableBuffer bufferToSet = CheckNewUserValue(value, startIndex);
        return new WhitespaceSequence(bufferToSet, tabWidth);
    }

    internal static WhitespaceSequence CreateFromValue(IEditableBuffer value, int startIndex, int endIndex,
        bool setWithoutCopy = false)
    {
        if (setWithoutCopy)
        {
            CheckNewUserValueSimplified(value, startIndex, endIndex);
            return new WhitespaceSequence(value);
        }

        IEditableBuffer bufferToSet = CheckNewUserValue(value, startIndex, endIndex);
        return new WhitespaceSequence(bufferToSet);
    }

    internal static WhitespaceSequence CreateFromValueWithTabWidth(IEditableBuffer value, int startIndex, int endIndex,
        int tabWidth,
        bool setWithoutCopy = false)
    {
        CheckTabWidth(tabWidth);
        if (setWithoutCopy)
        {
            CheckNewUserValueSimplified(value, startIndex, endIndex);
            return new WhitespaceSequence(value, tabWidth);
        }

        IEditableBuffer bufferToSet = CheckNewUserValue(value, startIndex, endIndex);
        return new WhitespaceSequence(bufferToSet, tabWidth);
    }

    internal static WhitespaceSequence CreateFromValue(ISwiftNode parent, IEditableBuffer value,
        bool setWithoutCopy = false)
    {
        if (setWithoutCopy)
        {
            CheckNewUserValueSimplified(value);
            return new WhitespaceSequence(parent, value);
        }

        IEditableBuffer bufferToSet = CheckNewUserValue(value);
        return new WhitespaceSequence(parent, bufferToSet);
    }

    internal static WhitespaceSequence CreateFromValueWithTabWidth(ISwiftNode parent, IEditableBuffer value,
        int tabWidth, bool setWithoutCopy = false)
    {
        CheckTabWidth(tabWidth);
        if (setWithoutCopy)
        {
            CheckNewUserValueSimplified(value);
            return new WhitespaceSequence(parent, value, tabWidth);
        }

        IEditableBuffer bufferToSet = CheckNewUserValue(value);
        return new WhitespaceSequence(parent, bufferToSet, tabWidth);
    }

    internal static WhitespaceSequence CreateFromValue(ISwiftNode parent, IEditableBuffer value, int startIndex,
        bool setWithoutCopy = false)
    {
        if (setWithoutCopy)
        {
            CheckNewUserValueSimplified(value, startIndex);
            return new WhitespaceSequence(parent, value);
        }

        IEditableBuffer bufferToSet = CheckNewUserValue(value, startIndex);
        return new WhitespaceSequence(parent, bufferToSet);
    }

    internal static WhitespaceSequence CreateFromValueWithTabWidth(ISwiftNode parent, IEditableBuffer value,
        int startIndex, int tabWidth, bool setWithoutCopy = false)
    {
        CheckTabWidth(tabWidth);
        if (setWithoutCopy)
        {
            CheckNewUserValueSimplified(value, startIndex);
            return new WhitespaceSequence(parent, value, tabWidth);
        }

        IEditableBuffer bufferToSet = CheckNewUserValue(value, startIndex);
        return new WhitespaceSequence(parent, bufferToSet, tabWidth);
    }

    internal static WhitespaceSequence CreateFromValue(ISwiftNode parent, IEditableBuffer value, int startIndex,
        int endIndex, bool setWithoutCopy = false)
    {
        if (setWithoutCopy)
        {
            CheckNewUserValueSimplified(value, startIndex, endIndex);
            return new WhitespaceSequence(parent, value);
        }

        IEditableBuffer bufferToSet = CheckNewUserValue(value, startIndex, endIndex);
        return new WhitespaceSequence(parent, bufferToSet);
    }

    internal static WhitespaceSequence CreateFromValueWithTabWidth(ISwiftNode parent, IEditableBuffer value,
        int startIndex, int endIndex, int tabWidth, bool setWithoutCopy = false)
    {
        CheckTabWidth(tabWidth);
        if (setWithoutCopy)
        {
            CheckNewUserValueSimplified(value, startIndex, endIndex);
            return new WhitespaceSequence(parent, value, tabWidth);
        }

        IEditableBuffer bufferToSet = CheckNewUserValue(value, startIndex, endIndex);
        return new WhitespaceSequence(parent, bufferToSet, tabWidth);
    }

    public static WhitespaceSequence CreateFromValue(StringBuilder value)
    {
        IEditableBuffer bufferToSet = CheckNewUserValue(value);
        return new WhitespaceSequence(bufferToSet);
    }

    public static WhitespaceSequence CreateFromValueWithTabWidth(StringBuilder value, int tabWidth)
    {
        CheckTabWidth(tabWidth);
        IEditableBuffer bufferToSet = CheckNewUserValue(value);
        return new WhitespaceSequence(bufferToSet, tabWidth);
    }

    public static WhitespaceSequence CreateFromValue(StringBuilder value, int startIndex)
    {
        IEditableBuffer bufferToSet = CheckNewUserValue(value, startIndex);
        return new WhitespaceSequence(bufferToSet);
    }

    public static WhitespaceSequence CreateFromValueWithTabWidth(StringBuilder value, int startIndex, int tabWidth)
    {
        CheckTabWidth(tabWidth);
        IEditableBuffer bufferToSet = CheckNewUserValue(value, startIndex);
        return new WhitespaceSequence(bufferToSet, tabWidth);
    }

    public static WhitespaceSequence CreateFromValue(StringBuilder value, int startIndex, int endIndex)
    {
        IEditableBuffer bufferToSet = CheckNewUserValue(value, startIndex, endIndex);
        return new WhitespaceSequence(bufferToSet);
    }

    public static WhitespaceSequence CreateFromValueWithTabWidth(StringBuilder value, int startIndex, int endIndex,
        int tabWidth)
    {
        CheckTabWidth(tabWidth);
        IEditableBuffer bufferToSet = CheckNewUserValue(value, startIndex, endIndex);
        return new WhitespaceSequence(bufferToSet, tabWidth);
    }

    public static WhitespaceSequence CreateFromValue(ISwiftNode parent, StringBuilder value)
    {
        IEditableBuffer bufferToSet = CheckNewUserValue(value);
        return new WhitespaceSequence(parent, bufferToSet);
    }

    public static WhitespaceSequence CreateFromValueWithTabWidth(ISwiftNode parent, StringBuilder value, int tabWidth)
    {
        CheckTabWidth(tabWidth);
        IEditableBuffer bufferToSet = CheckNewUserValue(value);
        return new WhitespaceSequence(parent, bufferToSet, tabWidth);
    }

    public static WhitespaceSequence CreateFromValue(ISwiftNode parent, StringBuilder value, int startIndex)
    {
        IEditableBuffer bufferToSet = CheckNewUserValue(value, startIndex);
        return new WhitespaceSequence(parent, bufferToSet);
    }

    public static WhitespaceSequence CreateFromValueWithTabWidth(ISwiftNode parent, StringBuilder value, int startIndex,
        int tabWidth)
    {
        CheckTabWidth(tabWidth);
        IEditableBuffer bufferToSet = CheckNewUserValue(value, startIndex);
        return new WhitespaceSequence(parent, bufferToSet, tabWidth);
    }

    public static WhitespaceSequence CreateFromValue(ISwiftNode parent, StringBuilder value, int startIndex,
        int endIndex)
    {
        IEditableBuffer bufferToSet = CheckNewUserValue(value, startIndex, endIndex);
        return new WhitespaceSequence(parent, bufferToSet);
    }

    public static WhitespaceSequence CreateFromValueWithTabWidth(ISwiftNode parent, StringBuilder value, int startIndex,
        int endIndex, int tabWidth)
    {
        CheckTabWidth(tabWidth);
        IEditableBuffer bufferToSet = CheckNewUserValue(value, startIndex, endIndex);
        return new WhitespaceSequence(parent, bufferToSet, tabWidth);
    }

    public static WhitespaceSequence CreateFromValue(string value)
    {
        IEditableBuffer bufferToSet = CheckNewUserValue(value);
        return new WhitespaceSequence(bufferToSet);
    }

    public static WhitespaceSequence CreateFromValueWithTabWidth(string value, int tabWidth)
    {
        CheckTabWidth(tabWidth);
        IEditableBuffer bufferToSet = CheckNewUserValue(value);
        return new WhitespaceSequence(bufferToSet, tabWidth);
    }

    public static WhitespaceSequence CreateFromValue(string value, int startIndex)
    {
        IEditableBuffer bufferToSet = CheckNewUserValue(value, startIndex);
        return new WhitespaceSequence(bufferToSet);
    }

    public static WhitespaceSequence CreateFromValueWithTabWidth(string value, int startIndex, int tabWidth)
    {
        CheckTabWidth(tabWidth);
        IEditableBuffer bufferToSet = CheckNewUserValue(value, startIndex);
        return new WhitespaceSequence(bufferToSet, tabWidth);
    }

    public static WhitespaceSequence CreateFromValue(string value, int startIndex, int endIndex)
    {
        IEditableBuffer bufferToSet = CheckNewUserValue(value, startIndex, endIndex);
        return new WhitespaceSequence(bufferToSet);
    }

    public static WhitespaceSequence CreateFromValueWithTabWidth(string value, int startIndex, int endIndex,
        int tabWidth)
    {
        CheckTabWidth(tabWidth);
        IEditableBuffer bufferToSet = CheckNewUserValue(value, startIndex, endIndex);
        return new WhitespaceSequence(bufferToSet, tabWidth);
    }

    public static WhitespaceSequence CreateFromValue(ISwiftNode parent, string value)
    {
        IEditableBuffer bufferToSet = CheckNewUserValue(value);
        return new WhitespaceSequence(parent, bufferToSet);
    }

    public static WhitespaceSequence CreateFromValueWithTabWidth(ISwiftNode parent, string value, int tabWidth)
    {
        CheckTabWidth(tabWidth);
        IEditableBuffer bufferToSet = CheckNewUserValue(value);
        return new WhitespaceSequence(parent, bufferToSet, tabWidth);
    }

    public static WhitespaceSequence CreateFromValue(ISwiftNode parent, string value, int startIndex)
    {
        IEditableBuffer bufferToSet = CheckNewUserValue(value, startIndex);
        return new WhitespaceSequence(parent, bufferToSet);
    }

    public static WhitespaceSequence CreateFromValueWithTabWidth(ISwiftNode parent, string value, int startIndex,
        int tabWidth)
    {
        CheckTabWidth(tabWidth);
        IEditableBuffer bufferToSet = CheckNewUserValue(value, startIndex);
        return new WhitespaceSequence(parent, bufferToSet, tabWidth);
    }

    public static WhitespaceSequence CreateFromValue(ISwiftNode parent, string value, int startIndex, int endIndex)
    {
        IEditableBuffer bufferToSet = CheckNewUserValue(value, startIndex, endIndex);
        return new WhitespaceSequence(parent, bufferToSet);
    }

    public static WhitespaceSequence CreateFromValueWithTabWidth(ISwiftNode parent, string value, int startIndex,
        int endIndex, int tabWidth)
    {
        CheckTabWidth(tabWidth);
        IEditableBuffer bufferToSet = CheckNewUserValue(value, startIndex, endIndex);
        return new WhitespaceSequence(parent, bufferToSet, tabWidth);
    }

    public static WhitespaceSequence CreateFromValue(ReadOnlySpan<char> value)
    {
        IEditableBuffer bufferToSet = CheckNewUserValue(value);
        return new WhitespaceSequence(bufferToSet);
    }

    public static WhitespaceSequence CreateFromValueWithTabWidth(ReadOnlySpan<char> value, int tabWidth)
    {
        CheckTabWidth(tabWidth);
        IEditableBuffer bufferToSet = CheckNewUserValue(value);
        return new WhitespaceSequence(bufferToSet, tabWidth);
    }

    public static WhitespaceSequence CreateFromValue(ReadOnlySpan<char> value, int startIndex)
    {
        IEditableBuffer bufferToSet = CheckNewUserValue(value, startIndex);
        return new WhitespaceSequence(bufferToSet);
    }

    public static WhitespaceSequence CreateFromValueWithTabWidth(ReadOnlySpan<char> value, int startIndex, int tabWidth)
    {
        CheckTabWidth(tabWidth);
        IEditableBuffer bufferToSet = CheckNewUserValue(value, startIndex);
        return new WhitespaceSequence(bufferToSet, tabWidth);
    }

    public static WhitespaceSequence CreateFromValue(ReadOnlySpan<char> value, int startIndex, int endIndex)
    {
        IEditableBuffer bufferToSet = CheckNewUserValue(value, startIndex, endIndex);
        return new WhitespaceSequence(bufferToSet);
    }

    public static WhitespaceSequence CreateFromValueWithTabWidth(ReadOnlySpan<char> value, int startIndex, int endIndex,
        int tabWidth)
    {
        CheckTabWidth(tabWidth);
        IEditableBuffer bufferToSet = CheckNewUserValue(value, startIndex, endIndex);
        return new WhitespaceSequence(bufferToSet, tabWidth);
    }

    public static WhitespaceSequence CreateFromValue(ISwiftNode parent, ReadOnlySpan<char> value)
    {
        IEditableBuffer bufferToSet = CheckNewUserValue(value);
        return new WhitespaceSequence(parent, bufferToSet);
    }

    public static WhitespaceSequence CreateFromValueWithTabWidth(ISwiftNode parent, ReadOnlySpan<char> value,
        int tabWidth)
    {
        CheckTabWidth(tabWidth);
        IEditableBuffer bufferToSet = CheckNewUserValue(value);
        return new WhitespaceSequence(parent, bufferToSet, tabWidth);
    }

    public static WhitespaceSequence CreateFromValue(ISwiftNode parent, ReadOnlySpan<char> value, int startIndex)
    {
        IEditableBuffer bufferToSet = CheckNewUserValue(value, startIndex);
        return new WhitespaceSequence(parent, bufferToSet);
    }

    public static WhitespaceSequence CreateFromValueWithTabWidth(ISwiftNode parent, ReadOnlySpan<char> value,
        int startIndex, int tabWidth)
    {
        CheckTabWidth(tabWidth);
        IEditableBuffer bufferToSet = CheckNewUserValue(value, startIndex);
        return new WhitespaceSequence(parent, bufferToSet, tabWidth);
    }

    public static WhitespaceSequence CreateFromValue(ISwiftNode parent, ReadOnlySpan<char> value, int startIndex,
        int endIndex)
    {
        IEditableBuffer bufferToSet = CheckNewUserValue(value, startIndex, endIndex);
        return new WhitespaceSequence(parent, bufferToSet);
    }

    public static WhitespaceSequence CreateFromValueWithTabWidth(ISwiftNode parent, ReadOnlySpan<char> value,
        int startIndex, int endIndex, int tabWidth)
    {
        CheckTabWidth(tabWidth);
        IEditableBuffer bufferToSet = CheckNewUserValue(value, startIndex, endIndex);
        return new WhitespaceSequence(parent, bufferToSet, tabWidth);
    }

    private static IEditableBuffer CheckNewUserValue(IBuffer value)
    {
        return CheckNewUserValueCore(value, 0, value.Length);
    }

    private static IEditableBuffer CheckNewUserValue(IBuffer value, int startIndex)
    {
        CheckNewUserValueIndexes(value.Length, startIndex);
        return CheckNewUserValueCore(value, startIndex, value.Length);
    }

    private static IEditableBuffer CheckNewUserValue(IBuffer value, int startIndex, int endIndex)
    {
        CheckNewUserValueIndexes(value.Length, startIndex, endIndex);
        return CheckNewUserValueCore(value, startIndex, endIndex);
    }

    private static IEditableBuffer CheckNewUserValue(IEditableBuffer value)
    {
        return CheckNewUserValueCore(value, 0, value.Length);
    }

    private static IEditableBuffer CheckNewUserValue(IEditableBuffer value, int startIndex)
    {
        CheckNewUserValueIndexes(value.Length, startIndex);
        return CheckNewUserValueCore(value, startIndex, value.Length);
    }

    private static IEditableBuffer CheckNewUserValue(IEditableBuffer value, int startIndex, int endIndex)
    {
        CheckNewUserValueIndexes(value.Length, startIndex, endIndex);
        return CheckNewUserValueCore(value, startIndex, endIndex);
    }

    private static IEditableBuffer CheckNewUserValue(StringBuilder value)
    {
        return CheckNewUserValueCore(value, 0, value.Length);
    }

    private static IEditableBuffer CheckNewUserValue(StringBuilder value, int startIndex)
    {
        CheckNewUserValueIndexes(value.Length, startIndex);
        return CheckNewUserValueCore(value, startIndex, value.Length);
    }

    private static IEditableBuffer CheckNewUserValue(StringBuilder value, int startIndex, int endIndex)
    {
        CheckNewUserValueIndexes(value.Length, startIndex, endIndex);
        return CheckNewUserValueCore(value, startIndex, endIndex);
    }

    private static IEditableBuffer CheckNewUserValue(string value)
    {
        return CheckNewUserValueCore(value, 0, value.Length);
    }

    private static IEditableBuffer CheckNewUserValue(string value, int startIndex)
    {
        CheckNewUserValueIndexes(value.Length, startIndex);
        return CheckNewUserValueCore(value, startIndex, value.Length);
    }

    private static IEditableBuffer CheckNewUserValue(string value, int startIndex, int endIndex)
    {
        CheckNewUserValueIndexes(value.Length, startIndex, endIndex);
        return CheckNewUserValueCore(value, startIndex, endIndex);
    }

    private static IEditableBuffer CheckNewUserValue(ReadOnlySpan<char> value)
    {
        return CheckNewUserValueCore(value, 0, value.Length);
    }

    private static IEditableBuffer CheckNewUserValue(ReadOnlySpan<char> value, int startIndex)
    {
        CheckNewUserValueIndexes(value.Length, startIndex);
        return CheckNewUserValueCore(value, startIndex, value.Length);
    }

    private static IEditableBuffer CheckNewUserValue(ReadOnlySpan<char> value, int startIndex, int endIndex)
    {
        CheckNewUserValueIndexes(value.Length, startIndex, endIndex);
        return CheckNewUserValueCore(value, startIndex, endIndex);
    }

    private static void CheckNewUserValueSimplified(IEditableBuffer value)
    {
        CheckNewUserValueSimplifiedCore(value, 0, value.Length);
    }

    private static void CheckNewUserValueSimplified(IEditableBuffer value, int startIndex)
    {
        CheckNewUserValueIndexes(value.Length, startIndex);
        CheckNewUserValueSimplifiedCore(value, startIndex, value.Length);
    }

    private static void CheckNewUserValueSimplified(IEditableBuffer value, int startIndex, int endIndex)
    {
        CheckNewUserValueIndexes(value.Length, startIndex, endIndex);
        CheckNewUserValueSimplifiedCore(value, startIndex, endIndex);
    }

    private static void CheckNewUserValueSimplifiedCore(IEditableBuffer value, int startIndex, int endIndex)
    {
        for (int index = startIndex; index < endIndex; index++)
        {
            char character = value[index];
            if (!character.IsWhitespace())
            {
                throw new ArgumentException(
                    $"Cannot create a whitespace sequence because a non whitespace character was found at position {index} ('{character}' (U+{(int)character:2X})) " +
                    $"in \"\n{value}\"", nameof(value));
            }
        }
    }

    private static IEditableBuffer CheckNewUserValueCore(IBuffer value, int startIndex, int endIndex)
    {
        IEditableBuffer editableBuffer = new EditableBuffer();
        for (int index = startIndex; index < endIndex; index++)
        {
            char character = value[index];
            if (!character.IsWhitespace())
            {
                throw new ArgumentException(
                    $"Cannot create a whitespace sequence because a non whitespace character was found at position {index} ('{character}' (U+{(int)character:2X})) " +
                    $"in \"\n{value}\"", nameof(value));
            }

            editableBuffer.Insert(index, value[index].ToString());
        }

        return editableBuffer;
    }

    private static IEditableBuffer CheckNewUserValueCore(IEditableBuffer value, int startIndex, int endIndex)
    {
        IEditableBuffer editableBuffer = new EditableBuffer();
        for (int index = startIndex; index < endIndex; index++)
        {
            char character = value[index];
            if (!character.IsWhitespace())
            {
                throw new ArgumentException(
                    $"Cannot create a whitespace sequence because a non whitespace character was found at position {index} ('{character}' (U+{(int)character:2X})) " +
                    $"in \"\n{value}\"", nameof(value));
            }

            editableBuffer.Insert(index, value[index].ToString());
        }

        return editableBuffer;
    }

    private static IEditableBuffer CheckNewUserValueCore(StringBuilder value, int startIndex, int endIndex)
    {
        IEditableBuffer editableBuffer = new EditableBuffer();
        for (int index = startIndex; index < endIndex; index++)
        {
            char character = value[index];
            if (!character.IsWhitespace())
            {
                throw new ArgumentException(
                    $"Cannot create a whitespace sequence because a non whitespace character was found at position {index} ('{character}' (U+{(int)character:2X})) " +
                    $"in \"\n{value}\"", nameof(value));
            }

            editableBuffer.Insert(index, value[index].ToString());
        }

        return editableBuffer;
    }

    private static IEditableBuffer CheckNewUserValueCore(string value, int startIndex, int endIndex)
    {
        IEditableBuffer editableBuffer = new EditableBuffer();
        for (int index = startIndex; index < endIndex; index++)
        {
            char character = value[index];
            if (!character.IsWhitespace())
            {
                throw new ArgumentException(
                    $"Cannot create a whitespace sequence because a non whitespace character was found at position {index} ('{character}' (U+{(int)character:2X})) " +
                    $"in \"\n{value}\"", nameof(value));
            }

            editableBuffer.Insert(index, value[index].ToString());
        }

        return editableBuffer;
    }

    private static IEditableBuffer CheckNewUserValueCore(ReadOnlySpan<char> value, int startIndex, int endIndex)
    {
        IEditableBuffer editableBuffer = new EditableBuffer();
        for (int index = startIndex; index < endIndex; index++)
        {
            char character = value[index];
            if (!character.IsWhitespace())
            {
                throw new ArgumentException(
                    $"Cannot create a whitespace sequence because a non whitespace character was found at position {index} ('{character}' (U+{(int)character:2X})) " +
                    $"in \"\n{new string(value.ToArray())}\"", nameof(value));
            }

            editableBuffer.Insert(index, value[index].ToString());
        }

        return editableBuffer;
    }

    private static void CheckNewUserValueIndexes(int targetLength, int startIndex)
    {
        if (startIndex < 0 || startIndex >= targetLength)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }
    }

    private static void CheckNewUserValueIndexes(int targetLength, int startIndex, int endIndex)
    {
        if (startIndex < 0 || startIndex >= targetLength)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        if (endIndex < 0 || endIndex >= targetLength)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndex));
        }

        if (startIndex > endIndex)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }
    }

    private void CheckNewUserValueIndexInclusive(int index)
    {
        if (index < 0 || index > EditableBuffer.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }
    }

    private void CheckNewUserValueIndexExclusive(int index)
    {
        if (index < 0 || index >= EditableBuffer.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }
    }

    private static void CheckTabWidth(int tabWidth)
    {
        if (tabWidth <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(tabWidth));
        }
    }

    public void SetValue(IBuffer value)
    {
        CheckNewUserValue(value);
        ClearBuffer();
        AppendValue(value);
    }

    public void SetValue(IBuffer value, int startIndex)
    {
        CheckNewUserValue(value, startIndex);
        ClearBuffer();
        AppendValue(value, startIndex);
    }

    public void SetValue(IBuffer value, int startIndex, int endIndex)
    {
        CheckNewUserValue(value, startIndex, endIndex);
        ClearBuffer();
        AppendValue(value, startIndex, endIndex);
    }

    internal void SetValue(IEditableBuffer value, bool setWithoutCopyIfIsolatedChild = false)
    {
        CheckNewUserValue(value);
        ClearBuffer();

        if (setWithoutCopyIfIsolatedChild && !HasParent())
        {
            EditableBuffer = value;
            return;
        }

        AppendValue(value);
    }

    internal void SetValue(IEditableBuffer value, int startIndex, bool setWithoutCopyIfIsolatedChild = false)
    {
        CheckNewUserValue(value, startIndex);
        ClearBuffer();

        if (setWithoutCopyIfIsolatedChild && !HasParent())
        {
            EditableBuffer = value;
            return;
        }

        AppendValue(value, startIndex);
    }

    internal void SetValue(IEditableBuffer value, int startIndex, int endIndex,
        bool setWithoutCopyIfIsolatedChild = false)
    {
        CheckNewUserValue(value, startIndex, endIndex);
        ClearBuffer();

        if (setWithoutCopyIfIsolatedChild && !HasParent())
        {
            EditableBuffer = value;
            return;
        }

        AppendValue(value, startIndex, endIndex);
    }

    public void SetValue(StringBuilder value)
    {
        CheckNewUserValue(value);
        ClearValue();
        AppendValue(value);
    }

    public void SetValue(StringBuilder value, int startIndex)
    {
        CheckNewUserValue(value, startIndex);
        ClearValue();
        AppendValue(value, startIndex);
    }

    public void SetValue(StringBuilder value, int startIndex, int endIndex)
    {
        CheckNewUserValue(value, startIndex, endIndex);
        ClearValue();
        AppendValue(value, startIndex, endIndex);
    }

    public void SetValue(string value)
    {
        CheckNewUserValue(value);
        ClearValue();
        AppendValue(value);
    }

    public void SetValue(string value, int startIndex)
    {
        CheckNewUserValue(value, startIndex);
        ClearValue();
        AppendValue(value, startIndex);
    }

    public void SetValue(string value, int startIndex, int endIndex)
    {
        CheckNewUserValue(value, startIndex, endIndex);
        ClearValue();
        AppendValue(value, startIndex, endIndex);
    }

    public void SetValue(ReadOnlySpan<char> value)
    {
        CheckNewUserValue(value);
        ClearValue();
        AppendValue(value);
    }

    public void SetValue(ReadOnlySpan<char> value, int startIndex)
    {
        CheckNewUserValue(value, startIndex);
        ClearValue();
        AppendValue(value, startIndex);
    }

    public void SetValue(ReadOnlySpan<char> value, int startIndex, int endIndex)
    {
        CheckNewUserValue(value, startIndex, endIndex);
        ClearValue();
        AppendValue(value, startIndex, endIndex);
    }

    public void InsertInValue(int offset, IBuffer buffer)
    {
        CheckNewUserValue(buffer);
        CheckNewUserValueIndexInclusive(offset);
        InsertValue(offset, buffer);
    }

    public void InsertInValue(int offset, IBuffer buffer, int startIndex)
    {
        CheckNewUserValue(buffer, startIndex);
        CheckNewUserValueIndexInclusive(offset);
        InsertValue(offset, buffer, startIndex);
    }

    public void InsertInValue(int offset, IBuffer buffer, int startIndex, int endIndex)
    {
        CheckNewUserValue(buffer, startIndex, endIndex);
        CheckNewUserValueIndexInclusive(offset);
        InsertValue(offset, buffer, startIndex, endIndex);
    }

    public void InsertInValue(int offset, IEditableBuffer buffer)
    {
        CheckNewUserValue(buffer);
        CheckNewUserValueIndexInclusive(offset);
        InsertValue(offset, buffer);
    }

    public void InsertInValue(int offset, IEditableBuffer buffer, int startIndex)
    {
        CheckNewUserValue(buffer, startIndex);
        CheckNewUserValueIndexInclusive(offset);
        InsertValue(offset, buffer, startIndex);
    }

    public void InsertInValue(int offset, IEditableBuffer buffer, int startIndex, int endIndex)
    {
        CheckNewUserValue(buffer, startIndex, endIndex);
        CheckNewUserValueIndexInclusive(offset);
        InsertValue(offset, buffer, startIndex, endIndex);
    }

    public void InsertInValue(int offset, StringBuilder buffer)
    {
        CheckNewUserValue(buffer);
        CheckNewUserValueIndexInclusive(offset);
        InsertValue(offset, buffer);
    }

    public void InsertInValue(int offset, StringBuilder buffer, int startIndex)
    {
        CheckNewUserValue(buffer, startIndex);
        CheckNewUserValueIndexInclusive(offset);
        InsertValue(offset, buffer, startIndex);
    }

    public void InsertInValue(int offset, StringBuilder buffer, int startIndex, int endIndex)
    {
        CheckNewUserValue(buffer, startIndex, endIndex);
        CheckNewUserValueIndexInclusive(offset);
        InsertValue(offset, buffer, startIndex, endIndex);
    }

    public void InsertInValue(int offset, string buffer)
    {
        CheckNewUserValue(buffer);
        CheckNewUserValueIndexInclusive(offset);
        InsertValue(offset, buffer);
    }

    public void InsertInValue(int offset, string buffer, int startIndex)
    {
        CheckNewUserValue(buffer, startIndex);
        CheckNewUserValueIndexInclusive(offset);
        InsertValue(offset, buffer, startIndex);
    }

    public void InsertInValue(int offset, string buffer, int startIndex, int endIndex)
    {
        CheckNewUserValue(buffer, startIndex, endIndex);
        CheckNewUserValueIndexInclusive(offset);
        InsertValue(offset, buffer, startIndex, endIndex);
    }

    public void InsertInValue(int offset, ReadOnlySpan<char> buffer)
    {
        CheckNewUserValue(buffer);
        CheckNewUserValueIndexInclusive(offset);
        InsertValue(offset, buffer);
    }

    public void InsertInValue(int offset, ReadOnlySpan<char> buffer, int startIndex)
    {
        CheckNewUserValue(buffer, startIndex);
        CheckNewUserValueIndexInclusive(offset);
        InsertValue(offset, buffer, startIndex);
    }

    public void InsertInValue(int offset, ReadOnlySpan<char> buffer, int startIndex, int endIndex)
    {
        CheckNewUserValue(buffer, startIndex, endIndex);
        CheckNewUserValueIndexInclusive(offset);
        InsertValue(offset, buffer, startIndex, endIndex);
    }

    public void PrependToValue(IBuffer buffer)
    {
        CheckNewUserValue(buffer);
        InsertValue(0, buffer, 0, buffer.Length);
    }

    public void PrependToValue(IBuffer buffer, int startIndex)
    {
        CheckNewUserValue(buffer, startIndex);
        InsertValue(0, buffer, startIndex, buffer.Length);
    }

    public void PrependToValue(IBuffer buffer, int startIndex, int endIndex)
    {
        CheckNewUserValue(buffer, startIndex, endIndex);
        InsertValue(0, buffer, startIndex, endIndex);
    }

    public void PrependToValue(IEditableBuffer buffer)
    {
        CheckNewUserValue(buffer);
        InsertValue(0, buffer, 0, buffer.Length);
    }

    public void PrependToValue(IEditableBuffer buffer, int startIndex)
    {
        CheckNewUserValue(buffer, startIndex);
        InsertValue(0, buffer, startIndex, buffer.Length);
    }

    public void PrependToValue(IEditableBuffer buffer, int startIndex, int endIndex)
    {
        CheckNewUserValue(buffer, startIndex, endIndex);
        InsertValue(0, buffer, startIndex, endIndex);
    }

    public void PrependToValue(StringBuilder buffer)
    {
        CheckNewUserValue(buffer);
        InsertValue(0, buffer, 0, buffer.Length);
    }

    public void PrependToValue(StringBuilder buffer, int startIndex)
    {
        CheckNewUserValue(buffer, startIndex);
        InsertValue(0, buffer, startIndex, buffer.Length);
    }

    public void PrependToValue(StringBuilder buffer, int startIndex, int endIndex)
    {
        CheckNewUserValue(buffer, startIndex, endIndex);
        InsertValue(0, buffer, startIndex, endIndex);
    }

    public void PrependToValue(string buffer)
    {
        CheckNewUserValue(buffer);
        InsertValue(0, buffer, 0, buffer.Length);
    }

    public void PrependToValue(string buffer, int startIndex)
    {
        CheckNewUserValue(buffer, startIndex);
        InsertValue(0, buffer, startIndex, buffer.Length);
    }

    public void PrependToValue(string buffer, int startIndex, int endIndex)
    {
        CheckNewUserValue(buffer, startIndex, endIndex);
        InsertValue(0, buffer, startIndex, endIndex);
    }

    public void PrependToValue(ReadOnlySpan<char> buffer)
    {
        CheckNewUserValue(buffer);
        InsertValue(0, buffer, 0, buffer.Length);
    }

    public void PrependToValue(ReadOnlySpan<char> buffer, int startIndex)
    {
        CheckNewUserValue(buffer, startIndex);
        InsertValue(0, buffer, startIndex, buffer.Length);
    }

    public void PrependToValue(ReadOnlySpan<char> buffer, int startIndex, int endIndex)
    {
        CheckNewUserValue(buffer, startIndex, endIndex);
        InsertValue(0, buffer, startIndex, endIndex);
    }

    public void AppendToValue(IBuffer buffer)
    {
        CheckNewUserValue(buffer);
        AppendValue(buffer, 0, buffer.Length);
    }

    public void AppendToValue(IBuffer buffer, int startIndex)
    {
        CheckNewUserValue(buffer, startIndex);
        AppendValue(buffer, startIndex, buffer.Length);
    }

    public void AppendToValue(IBuffer buffer, int startIndex, int endIndex)
    {
        CheckNewUserValue(buffer, startIndex, endIndex);
        AppendValue(buffer, startIndex, endIndex);
    }

    public void AppendToValue(IEditableBuffer buffer)
    {
        CheckNewUserValue(buffer);
        AppendValue(buffer);
    }

    public void AppendToValue(IEditableBuffer buffer, int startIndex)
    {
        CheckNewUserValue(buffer, startIndex);
        AppendValue(buffer, startIndex);
    }

    public void AppendToValue(IEditableBuffer buffer, int startIndex, int endIndex)
    {
        CheckNewUserValue(buffer, startIndex, endIndex);
        AppendValue(buffer, startIndex, endIndex);
    }

    public void AppendToValue(StringBuilder buffer)
    {
        CheckNewUserValue(buffer);
        AppendValue(buffer, 0, buffer.Length);
    }

    public void AppendToValue(StringBuilder buffer, int startIndex)
    {
        CheckNewUserValue(buffer, startIndex);
        AppendValue(buffer, startIndex, buffer.Length);
    }

    public void AppendToValue(StringBuilder buffer, int startIndex, int endIndex)
    {
        CheckNewUserValue(buffer, startIndex, endIndex);
        AppendValue(buffer, startIndex, endIndex);
    }

    public void AppendToValue(string buffer)
    {
        CheckNewUserValue(buffer);
        AppendValue(buffer, 0, buffer.Length);
    }

    public void AppendToValue(string buffer, int startIndex)
    {
        CheckNewUserValue(buffer, startIndex);
        AppendValue(buffer, startIndex, buffer.Length);
    }

    public void AppendToValue(string buffer, int startIndex, int endIndex)
    {
        CheckNewUserValue(buffer, startIndex, endIndex);
        AppendValue(buffer, startIndex, endIndex);
    }

    public void AppendToValue(ReadOnlySpan<char> buffer)
    {
        CheckNewUserValue(buffer);
        AppendValue(buffer, 0, buffer.Length);
    }

    public void AppendToValue(ReadOnlySpan<char> buffer, int startIndex)
    {
        CheckNewUserValue(buffer, startIndex);
        AppendValue(buffer, startIndex, buffer.Length);
    }

    public void AppendToValue(ReadOnlySpan<char> buffer, int startIndex, int endIndex)
    {
        CheckNewUserValue(buffer, startIndex, endIndex);
        AppendValue(buffer, startIndex, endIndex);
    }

    public void ReplaceInValue(int index, IBuffer buffer, bool extend = false)
    {
        CheckNewUserValue(buffer);
        CheckNewUserValueIndexExclusive(index);
        ReplaceValue(index, buffer, extend: extend);
    }

    public void ReplaceInValue(int index, IBuffer buffer, int startIndex, bool extend = false)
    {
        CheckNewUserValue(buffer, startIndex);
        CheckNewUserValueIndexExclusive(index);
        ReplaceValue(index, buffer, startIndex, extend);
    }

    public void ReplaceInValue(int index, IBuffer buffer, int startIndex, int endIndex, bool extend = false)
    {
        CheckNewUserValue(buffer, startIndex, endIndex);
        CheckNewUserValueIndexExclusive(index);
        ReplaceValue(index, buffer, startIndex, endIndex, extend);
    }

    public void ReplaceInValue(int index, IEditableBuffer buffer, bool extend = false)
    {
        CheckNewUserValue(buffer);
        CheckNewUserValueIndexExclusive(index);
        ReplaceValue(index, buffer, extend: extend);
    }

    public void ReplaceInValue(int index, IEditableBuffer buffer, int startIndex, bool extend = false)
    {
        CheckNewUserValue(buffer, startIndex);
        CheckNewUserValueIndexExclusive(index);
        ReplaceValue(index, buffer, startIndex, extend);
    }

    public void ReplaceInValue(int index, IEditableBuffer buffer, int startIndex, int endIndex, bool extend = false)
    {
        CheckNewUserValue(buffer, startIndex, endIndex);
        CheckNewUserValueIndexExclusive(index);
        ReplaceValue(index, buffer, startIndex, endIndex, extend);
    }

    public void ReplaceInValue(int index, StringBuilder buffer, bool extend = false)
    {
        CheckNewUserValue(buffer);
        CheckNewUserValueIndexExclusive(index);
        ReplaceValue(index, buffer, extend: extend);
    }

    public void ReplaceInValue(int index, StringBuilder buffer, int startIndex, bool extend = false)
    {
        CheckNewUserValue(buffer, startIndex);
        CheckNewUserValueIndexExclusive(index);
        ReplaceValue(index, buffer, startIndex, extend);
    }

    public void ReplaceInValue(int index, StringBuilder buffer, int startIndex, int endIndex, bool extend = false)
    {
        CheckNewUserValue(buffer, startIndex, endIndex);
        CheckNewUserValueIndexExclusive(index);
        ReplaceValue(index, buffer, startIndex, endIndex, extend);
    }

    public void ReplaceInValue(int index, string buffer, bool extend = false)
    {
        CheckNewUserValue(buffer);
        CheckNewUserValueIndexExclusive(index);
        ReplaceValue(index, buffer, extend: extend);
    }

    public void ReplaceInValue(int index, string buffer, int startIndex, bool extend = false)
    {
        CheckNewUserValue(buffer, startIndex);
        CheckNewUserValueIndexExclusive(index);
        ReplaceValue(index, buffer, startIndex, extend);
    }

    public void ReplaceInValue(int index, string buffer, int startIndex, int endIndex, bool extend = false)
    {
        CheckNewUserValue(buffer, startIndex, endIndex);
        CheckNewUserValueIndexExclusive(index);
        ReplaceValue(index, buffer, startIndex, endIndex, extend);
    }

    public void ReplaceInValue(int index, ReadOnlySpan<char> buffer, bool extend = false)
    {
        CheckNewUserValue(buffer);
        CheckNewUserValueIndexExclusive(index);
        ReplaceValue(index, buffer, extend: extend);
    }

    public void ReplaceInValue(int index, ReadOnlySpan<char> buffer, int startIndex, bool extend = false)
    {
        CheckNewUserValue(buffer, startIndex);
        CheckNewUserValueIndexExclusive(index);
        ReplaceValue(index, buffer, startIndex, extend);
    }

    public void ReplaceInValue(int index, ReadOnlySpan<char> buffer, int startIndex, int endIndex, bool extend = false)
    {
        CheckNewUserValue(buffer, startIndex, endIndex);
        CheckNewUserValueIndexExclusive(index);
        ReplaceValue(index, buffer, startIndex, endIndex, extend);
    }

    public void RemoveFromValue(int index)
    {
        CheckNewUserValueIndexExclusive(index);
        

        if (EditableBuffer[index] == Space)
        {
            _spaces.Remove(index);
        }
        else
        {
            _tabs.Remove(index);
        }
        
        EditableBuffer.Remove(index, 1);
    }

    public void RemoveFromValue(int startIndex, int endIndex)
    {
        CheckNewUserValueIndexes(EditableBuffer.Length, startIndex, endIndex);
        
        
        _spaces.GetViewBetween(startIndex, endIndex).Clear();
        _tabs.GetViewBetween(startIndex, endIndex).Clear();
        
        EditableBuffer.Remove(startIndex, endIndex - startIndex);
    }

    public List<(int index, char character)> RemoveWhere(Func<int, bool> predicate)
    {
        return RemoveWhereCore(predicate, 0, EditableBuffer.Length);
    }

    public List<(int index, char character)> RemoveWhere(Func<int, bool> predicate, int startIndex)
    {
        CheckNewUserValueIndexExclusive(startIndex);
        return RemoveWhereCore(predicate, startIndex, EditableBuffer.Length);
    }

    public List<(int index, char character)> RemoveWhere(Func<int, bool> predicate, int startIndex, int endIndex)
    {
        CheckNewUserValueIndexes(EditableBuffer.Length, startIndex, endIndex);
        return RemoveWhereCore(predicate, startIndex, endIndex);
    }
    
    private List<(int index, char character)> RemoveWhereCore(Func<int, bool> predicate, int startIndex, int endIndex)
    {
        List<(int index, char character)> removedIndexes = [];

        int index = startIndex;
        while (index < endIndex)
        {
            if (!predicate(index))
            {
                index++;
                continue;
            }

            if (EditableBuffer[index] == Space)
            {
                _spaces.Remove(index);
            }
            else
            {
                _tabs.Remove(index);
            }

            removedIndexes.Add((index, EditableBuffer[index]));
            EditableBuffer.Remove(index, 1);
        }
        
        return removedIndexes;
    }

    public List<(int index, char character)> RemoveWhere(Func<char, bool> predicate)
    {
        return RemoveWhereCore(predicate, 0, EditableBuffer.Length);
    }

    public List<(int index, char character)> RemoveWhere(Func<char, bool> predicate, int startIndex)
    {
        CheckNewUserValueIndexExclusive(startIndex);
        return RemoveWhereCore(predicate, startIndex, EditableBuffer.Length);
    }

    public List<(int index, char character)> RemoveWhere(Func<char, bool> predicate, int startIndex, int endIndex)
    {
        CheckNewUserValueIndexes(EditableBuffer.Length, startIndex, endIndex);
        return RemoveWhereCore(predicate, startIndex, endIndex);
    }
    
    private List<(int index, char character)> RemoveWhereCore(Func<char, bool> predicate, int startIndex, int endIndex)
    {
        List<(int index, char character)> removedIndexes = [];

        int index = startIndex;
        while (index < endIndex)
        {
            if (!predicate(EditableBuffer[index]))
            {
                index++;
                continue;
            }

            if (EditableBuffer[index] == Space)
            {
                _spaces.Remove(index);
            }
            else
            {
                _tabs.Remove(index);
            }

            removedIndexes.Add((index, EditableBuffer[index]));
            EditableBuffer.Remove(index, 1);
        }
        
        return removedIndexes;
    }

    public List<(int index, char character)> RemoveWhere(Func<int, char, bool> predicate)
    {
        return RemoveWhereCore(predicate, 0, EditableBuffer.Length);
    }

    public List<(int index, char character)> RemoveWhere(Func<int, char, bool> predicate, int startIndex)
    {
        CheckNewUserValueIndexExclusive(startIndex);
        return RemoveWhereCore(predicate, startIndex, EditableBuffer.Length);
    }

    public List<(int index, char character)> RemoveWhere(Func<int, char, bool> predicate, int startIndex, int endIndex)
    {
        CheckNewUserValueIndexes(EditableBuffer.Length, startIndex, endIndex);
        return RemoveWhereCore(predicate, startIndex, endIndex);
    }
    
    private List<(int index, char character)> RemoveWhereCore(Func<int, char, bool> predicate, int startIndex, int endIndex)
    {
        List<(int index, char character)> removedIndexes = [];

        int index = startIndex;
        while (index < endIndex)
        {
            if (!predicate(index, EditableBuffer[index]))
            {
                index++;
                continue;
            }

            if (EditableBuffer[index] == Space)
            {
                _spaces.Remove(index);
            }
            else
            {
                _tabs.Remove(index);
            }

            removedIndexes.Add((index, EditableBuffer[index]));
            EditableBuffer.Remove(index, 1);
        }
        
        return removedIndexes;
    }

    public void ClearValue()
    {
        _spaces.Clear();
        _tabs.Clear();
        
        EditableBuffer.Remove(0, EditableBuffer.Length);
    }

    public bool Contains(char character)
    {
        return ContainsCore(character, 0, EditableBuffer.Length);
    }

    public bool Contains(char character, int startIndex)
    {
        CheckNewUserValueIndexExclusive(startIndex);
        return ContainsCore(character, startIndex, EditableBuffer.Length);
    }

    public bool Contains(char character, int startIndex, int endIndex)
    {
        CheckNewUserValueIndexes(EditableBuffer.Length, startIndex, endIndex);
        return ContainsCore(character, startIndex, endIndex);
    }
    
    private bool ContainsCore(char character, int startIndex, int endIndex)
    {
        int index = startIndex;
        while (index < endIndex)
        {
            if (EditableBuffer[index] == character)
            {
                return true;
            }
            
            index++;
        }
        
        return false;
    }

    public bool Contains(Func<char, bool> predicate)
    {
        return ContainsCore(predicate, 0, EditableBuffer.Length);
    }

    public bool Contains(Func<char, bool> predicate, int startIndex)
    {
        CheckNewUserValueIndexExclusive(startIndex);
        return ContainsCore(predicate, startIndex, EditableBuffer.Length);
    }

    public bool Contains(Func<char, bool> predicate, int startIndex, int endIndex)
    {
        CheckNewUserValueIndexes(EditableBuffer.Length, startIndex, endIndex);
        return ContainsCore(predicate, startIndex, endIndex);
    }
    
    private bool ContainsCore(Func<char, bool> predicate, int startIndex, int endIndex)
    {
        int index = startIndex;
        while (index < endIndex)
        {
            if (predicate(EditableBuffer[index]))
            {
                return true;
            }
            
            index++;
        }
        
        return false;
    }

    public bool Contains(Func<int, bool> predicate)
    {
        return ContainsCore(predicate, 0, EditableBuffer.Length);
    }

    public bool Contains(Func<int, bool> predicate, int startIndex)
    {
        CheckNewUserValueIndexExclusive(startIndex);
        return ContainsCore(predicate, startIndex, EditableBuffer.Length);
    }

    public bool Contains(Func<int, bool> predicate, int startIndex, int endIndex)
    {
        CheckNewUserValueIndexes(EditableBuffer.Length, startIndex, endIndex);
        return ContainsCore(predicate, startIndex, endIndex);
    }
    
    private static bool ContainsCore(Func<int, bool> predicate, int startIndex, int endIndex)
    {
        int index = startIndex;
        while (index < endIndex)
        {
            if (predicate(index))
            {
                return true;
            }
            
            index++;
        }
        
        return false;
    }

    public bool Contains(Func<int, char, bool> predicate)
    {
        return ContainsCore(predicate, 0, EditableBuffer.Length);
    }

    public bool Contains(Func<int, char, bool> predicate, int startIndex)
    {
        CheckNewUserValueIndexExclusive(startIndex);
        return ContainsCore(predicate, startIndex, EditableBuffer.Length);
    }

    public bool Contains(Func<int, char, bool> predicate, int startIndex, int endIndex)
    {
        CheckNewUserValueIndexes(EditableBuffer.Length, startIndex, endIndex);
        return ContainsCore(predicate, startIndex, endIndex);
    }
    
    private bool ContainsCore(Func<int, char, bool> predicate, int startIndex, int endIndex)
    {
        int index = startIndex;
        while (index < endIndex)
        {
            if (predicate(index, EditableBuffer[index]))
            {
                return true;
            }
            
            index++;
        }
        
        return false;
    }

    private void AppendValue(IBuffer buffer, int startIndex = 0)
    {
        AppendValue(buffer, startIndex, buffer.Length);
    }

    private void AppendValue(IBuffer buffer, int startIndex, int endIndex)
    {
        InsertValue(EditableBuffer.Length, buffer, startIndex, endIndex);
    }

    private void AppendValue(StringBuilder buffer, int startIndex = 0)
    {
        AppendValue(buffer, startIndex, buffer.Length);
    }

    private void AppendValue(StringBuilder buffer, int startIndex, int endIndex)
    {
        InsertValue(EditableBuffer.Length, buffer, startIndex, endIndex);
    }

    private void AppendValue(string buffer, int startIndex = 0)
    {
        AppendValue(buffer, startIndex, buffer.Length);
    }

    private void AppendValue(string buffer, int startIndex, int endIndex)
    {
        InsertValue(EditableBuffer.Length, buffer, startIndex, endIndex);
    }

    private void AppendValue(ReadOnlySpan<char> buffer, int startIndex = 0)
    {
        AppendValue(buffer, startIndex, buffer.Length);
    }

    private void AppendValue(ReadOnlySpan<char> buffer, int startIndex, int endIndex)
    {
        InsertValue(EditableBuffer.Length, buffer, startIndex, endIndex);
    }

    private void InsertValue(int index, IBuffer buffer, int startIndex = 0)
    {
        InsertValue(index, buffer, startIndex, buffer.Length);
    }

    private void InsertValue(int index, IBuffer buffer, int startIndex, int endIndex)
    {
        for (int i = startIndex; i < endIndex; i++)
        {
            EditableBuffer.Insert(index, buffer[i].ToString());
            UpdateCount(index++, buffer[startIndex]);
        }
    }

    private void InsertValue(int index, StringBuilder buffer, int startIndex = 0)
    {
        InsertValue(index, buffer, startIndex, buffer.Length);
    }

    private void InsertValue(int index, StringBuilder buffer, int startIndex, int endIndex)
    {
        for (int i = startIndex; i < endIndex; i++)
        {
            EditableBuffer.Insert(index, buffer[i].ToString());
            UpdateCount(index++, buffer[startIndex]);
        }
    }

    private void InsertValue(int index, string buffer, int startIndex = 0)
    {
        InsertValue(index, buffer, startIndex, buffer.Length);
    }

    private void InsertValue(int index, string buffer, int startIndex, int endIndex)
    {
        for (int i = startIndex; i < endIndex; i++)
        {
            EditableBuffer.Insert(index, buffer[i].ToString());
            UpdateCount(index++, buffer[i]);
        }
    }

    private void InsertValue(int index, ReadOnlySpan<char> buffer, int startIndex = 0)
    {
        InsertValue(index, buffer, startIndex, buffer.Length);
    }

    private void InsertValue(int index, ReadOnlySpan<char> buffer, int startIndex, int endIndex)
    {
        for (int i = startIndex; i < endIndex; i++)
        {
            EditableBuffer.Insert(index, buffer[i].ToString());
            UpdateCount(index++, buffer[i]);
        }
    }

    private void ReplaceValue(int index, IBuffer buffer, int startIndex = 0, bool extend = false)
    {
        ReplaceValue(index, buffer, startIndex, buffer.Length, extend);
    }

    private void ReplaceValue(int index, IBuffer buffer, int startIndex, int endIndex, bool extend = false)
    {
        int target = Math.Min(index + endIndex - startIndex, EditableBuffer.Length);
        int bufferIndex = startIndex;
        for (int i = index; i < target; i++)
        {
            EditableBuffer.Replace(i, 1, buffer[bufferIndex++].ToString());
        }

        if (!extend || bufferIndex == endIndex)
        {
            return;
        }

        AppendValue(buffer, bufferIndex, endIndex);
    }

    private void ReplaceValue(int index, IEditableBuffer buffer, int startIndex = 0, bool extend = false)
    {
        ReplaceValue(index, buffer, startIndex, buffer.Length, extend);
    }

    private void ReplaceValue(int index, IEditableBuffer buffer, int startIndex, int endIndex, bool extend = false)
    {
        int target = Math.Min(index + endIndex - startIndex, EditableBuffer.Length);
        int bufferIndex = startIndex;
        for (int i = index; i < target; i++)
        {
            EditableBuffer.Replace(i, 1, buffer[bufferIndex++].ToString());
        }

        if (!extend || bufferIndex == endIndex)
        {
            return;
        }

        AppendValue(buffer, bufferIndex, endIndex);
    }

    private void ReplaceValue(int index, StringBuilder buffer, int startIndex = 0, bool extend = false)
    {
        ReplaceValue(index, buffer, startIndex, buffer.Length, extend);
    }

    private void ReplaceValue(int index, StringBuilder buffer, int startIndex, int endIndex, bool extend = false)
    {
        int target = Math.Min(index + endIndex - startIndex, EditableBuffer.Length);
        int bufferIndex = startIndex;
        for (int i = index; i < target; i++)
        {
            EditableBuffer.Replace(i, 1, buffer[bufferIndex++].ToString());
        }

        if (!extend || bufferIndex == endIndex)
        {
            return;
        }

        AppendValue(buffer, bufferIndex, endIndex);
    }

    private void ReplaceValue(int index, string buffer, int startIndex = 0, bool extend = false)
    {
        ReplaceValue(index, buffer, startIndex, buffer.Length, extend);
    }

    private void ReplaceValue(int index, string buffer, int startIndex, int endIndex, bool extend = false)
    {
        int target = Math.Min(index + endIndex - startIndex, EditableBuffer.Length);
        int bufferIndex = startIndex;
        for (int i = index; i < target; i++)
        {
            EditableBuffer.Replace(i, 1, buffer[bufferIndex++].ToString());
        }

        if (!extend || bufferIndex == endIndex)
        {
            return;
        }

        AppendValue(buffer, bufferIndex, endIndex);
    }

    private void ReplaceValue(int index, ReadOnlySpan<char> buffer, int startIndex = 0, bool extend = false)
    {
        ReplaceValue(index, buffer, startIndex, buffer.Length, extend);
    }

    private void ReplaceValue(int index, ReadOnlySpan<char> buffer, int startIndex, int endIndex, bool extend = false)
    {
        int target = Math.Min(index + endIndex - startIndex, EditableBuffer.Length);
        int bufferIndex = startIndex;
        for (int i = index; i < target; i++)
        {
            EditableBuffer.Replace(i, 1, buffer[bufferIndex++].ToString());
        }

        if (!extend || bufferIndex == endIndex)
        {
            return;
        }

        AppendValue(buffer, bufferIndex, endIndex);
    }

    private void UpdateCount(int index, char character)
    {
        switch (character)
        {
            case Space:
                _spaces.Add(index);
                break;
            case Tab:
                _tabs.Add(index);
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(character));
        }
    }
}