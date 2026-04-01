using System;
using System.Collections.Generic;
using System.Text;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Comments;

public interface ICommentNode : ISwiftNode<SwiftCompositeNode>, IEnumerable<char>
{
    public int CommentValueLength { get; }
    
    public bool IsEmpty { get; }
    
    public char GetCharAt(int index);
    
    public void SetCharAt(int index, char value);

    public string GetCommentValue();

    public string GetCommentSubstring(int start, int length);

    public ReadOnlySpan<char> AsCommentValue();

    public ReadOnlySpan<char> AsCommentValue(int start, int length);

    public bool SetCommentValue(StringBuilder value);

    public bool SetCommentValue(StringBuilder value, int start);

    public bool SetCommentValue(StringBuilder value, int start, int count);

    public bool SetCommentValue(string value);

    public bool SetCommentValue(string value, int start);

    public bool SetCommentValue(string value, int start, int count);

    public bool SetCommentValue(IBuffer value);

    public bool SetCommentValue(IBuffer value, int start);

    public bool SetCommentValue(IBuffer value, int start, int count);

    public bool SetCommentValue(ReadOnlySpan<char> value);

    public bool SetCommentValue(ReadOnlySpan<char> value, int start);

    public bool SetCommentValue(ReadOnlySpan<char> value, int start, int count);

    public bool AppendToCommentValue(StringBuilder value);

    public bool AppendToCommentValue(StringBuilder value, int start);

    public bool AppendToCommentValue(StringBuilder value, int start, int count);

    public bool AppendToCommentValue(string value);

    public bool AppendToCommentValue(string value, int start);

    public bool AppendToCommentValue(string value, int start, int count);

    public bool AppendToCommentValue(IBuffer value);

    public bool AppendToCommentValue(IBuffer value, int start);

    public bool AppendToCommentValue(IBuffer value, int start, int count);

    public bool AppendToCommentValue(ReadOnlySpan<char> value);

    public bool AppendToCommentValue(ReadOnlySpan<char> value, int start);

    public bool AppendToCommentValue(ReadOnlySpan<char> value, int start, int count);

    public bool PrependToCommentValue(StringBuilder value);

    public bool PrependToCommentValue(StringBuilder value, int start);

    public bool PrependToCommentValue(StringBuilder value, int start, int count);

    public bool PrependToCommentValue(string value);

    public bool PrependToCommentValue(string value, int start);

    public bool PrependToCommentValue(string value, int start, int count);

    public bool PrependToCommentValue(IBuffer value);

    public bool PrependToCommentValue(IBuffer value, int start);

    public bool PrependToCommentValue(IBuffer value, int start, int count);

    public bool PrependToCommentValue(ReadOnlySpan<char> value);

    public bool PrependToCommentValue(ReadOnlySpan<char> value, int start);

    public bool PrependToCommentValue(ReadOnlySpan<char> value, int start, int count);

    public bool InsertInCommentValue(int index, StringBuilder insertion);

    public bool InsertInCommentValue(int index, StringBuilder insertion, int start);

    public bool InsertInCommentValue(int index, StringBuilder insertion, int start, int count);

    public bool InsertInCommentValue(int index, string insertion);

    public bool InsertInCommentValue(int index, string insertion, int start);

    public bool InsertInCommentValue(int index, string insertion, int start, int count);

    public bool InsertInCommentValue(int index, IBuffer insertion);

    public bool InsertInCommentValue(int index, IBuffer insertion, int start);

    public bool InsertInCommentValue(int index, IBuffer insertion, int start, int count);

    public bool InsertInCommentValue(int index, ReadOnlySpan<char> insertion);

    public bool InsertInCommentValue(int index, ReadOnlySpan<char> insertion, int start);

    public bool InsertInCommentValue(int index, ReadOnlySpan<char> insertion, int start, int count);

    public bool ReplaceInCommentValue(int index, StringBuilder replacement, bool extend = false);

    public bool ReplaceInCommentValue(int index, StringBuilder replacement, int replacementStart, bool extend = false);

    public bool ReplaceInCommentValue(int index, StringBuilder replacement, int replacementStart, int replacementLength,
        bool extend = false);

    public bool ReplaceInCommentValue(int index, string replacement, bool extend = false);

    public bool ReplaceInCommentValue(int index, string replacement, int replacementStart, bool extend = false);

    public bool ReplaceInCommentValue(int index, string replacement, int replacementStart,
        int replacementLength, bool extend = false);

    public bool ReplaceInCommentValue(int index, IBuffer replacement, bool extend = false);

    public bool ReplaceInCommentValue(int index, IBuffer replacement, int replacementStart, bool extend = false);

    public bool ReplaceInCommentValue(int index, IBuffer replacement, int replacementStart,
        int replacementLength, bool extend = false);


    public bool ReplaceInCommentValue(int index, ReadOnlySpan<char> replacement, bool extend = false);

    public bool ReplaceInCommentValue(int index, ReadOnlySpan<char> replacement, int replacementStart,
        bool extend = false);

    public bool ReplaceInCommentValue(int index, ReadOnlySpan<char> replacement, int replacementStart,
        int replacementLength, bool extend = false);

    public bool RemoveInCommentValue(int index, int length = 1);

    public List<int> RemoveInCommentValueWhere(Func<int, char, bool> predicate);

    public void ClearCommentValue();

    public bool Contains(char character);

    public bool Contains(Func<char, bool> predicate);

    public bool Contains(Func<int, char, bool> predicate);
}