using System;
using System.Collections.Generic;
using System.Text;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Comments;

public interface ICommentNode : ISwiftNode<SwiftCompositeNode>, IEnumerable<char>
{
    int CommentValueLength { get; }
    
    bool IsEmpty { get; }
    
    char GetCharAt(int index);
    
    void SetCharAt(int index, char value);

    string GetCommentValue();

    string GetCommentSubstring(int start, int length);

    ReadOnlySpan<char> AsCommentValue();

    ReadOnlySpan<char> AsCommentValue(int start, int length);

    bool SetCommentValue(StringBuilder value);

    bool SetCommentValue(StringBuilder value, int start);

    bool SetCommentValue(StringBuilder value, int start, int count);

    bool SetCommentValue(string value);

    bool SetCommentValue(string value, int start);

    bool SetCommentValue(string value, int start, int count);

    bool SetCommentValue(IBuffer value);

    bool SetCommentValue(IBuffer value, int start);

    bool SetCommentValue(IBuffer value, int start, int count);

    bool SetCommentValue(ReadOnlySpan<char> value);

    bool SetCommentValue(ReadOnlySpan<char> value, int start);

    bool SetCommentValue(ReadOnlySpan<char> value, int start, int count);

    bool AppendToCommentValue(StringBuilder value);

    bool AppendToCommentValue(StringBuilder value, int start);

    bool AppendToCommentValue(StringBuilder value, int start, int count);

    bool AppendToCommentValue(string value);

    bool AppendToCommentValue(string value, int start);

    bool AppendToCommentValue(string value, int start, int count);

    bool AppendToCommentValue(IBuffer value);

    bool AppendToCommentValue(IBuffer value, int start);

    bool AppendToCommentValue(IBuffer value, int start, int count);

    bool AppendToCommentValue(ReadOnlySpan<char> value);

    bool AppendToCommentValue(ReadOnlySpan<char> value, int start);

    bool AppendToCommentValue(ReadOnlySpan<char> value, int start, int count);

    bool PrependToCommentValue(StringBuilder value);

    bool PrependToCommentValue(StringBuilder value, int start);

    bool PrependToCommentValue(StringBuilder value, int start, int count);

    bool PrependToCommentValue(string value);

    bool PrependToCommentValue(string value, int start);

    bool PrependToCommentValue(string value, int start, int count);

    bool PrependToCommentValue(IBuffer value);

    bool PrependToCommentValue(IBuffer value, int start);

    bool PrependToCommentValue(IBuffer value, int start, int count);

    bool PrependToCommentValue(ReadOnlySpan<char> value);

    bool PrependToCommentValue(ReadOnlySpan<char> value, int start);

    bool PrependToCommentValue(ReadOnlySpan<char> value, int start, int count);

    bool InsertInCommentValue(int index, StringBuilder insertion);

    bool InsertInCommentValue(int index, StringBuilder insertion, int start);

    bool InsertInCommentValue(int index, StringBuilder insertion, int start, int count);

    bool InsertInCommentValue(int index, string insertion);

    bool InsertInCommentValue(int index, string insertion, int start);

    bool InsertInCommentValue(int index, string insertion, int start, int count);

    bool InsertInCommentValue(int index, IBuffer insertion);

    bool InsertInCommentValue(int index, IBuffer insertion, int start);

    bool InsertInCommentValue(int index, IBuffer insertion, int start, int count);

    bool InsertInCommentValue(int index, ReadOnlySpan<char> insertion);

    bool InsertInCommentValue(int index, ReadOnlySpan<char> insertion, int start);

    bool InsertInCommentValue(int index, ReadOnlySpan<char> insertion, int start, int count);

    bool ReplaceInCommentValue(int index, StringBuilder replacement, bool extend = false);

    bool ReplaceInCommentValue(int index, StringBuilder replacement, int replacementStart, bool extend = false);

    bool ReplaceInCommentValue(int index, StringBuilder replacement, int replacementStart, int replacementLength,
        bool extend = false);

    bool ReplaceInCommentValue(int index, string replacement, bool extend = false);

    bool ReplaceInCommentValue(int index, string replacement, int replacementStart, bool extend = false);

    bool ReplaceInCommentValue(int index, string replacement, int replacementStart,
        int replacementLength, bool extend = false);

    bool ReplaceInCommentValue(int index, IBuffer replacement, bool extend = false);

    bool ReplaceInCommentValue(int index, IBuffer replacement, int replacementStart, bool extend = false);

    bool ReplaceInCommentValue(int index, IBuffer replacement, int replacementStart,
        int replacementLength, bool extend = false);


    bool ReplaceInCommentValue(int index, ReadOnlySpan<char> replacement, bool extend = false);

    bool ReplaceInCommentValue(int index, ReadOnlySpan<char> replacement, int replacementStart,
        bool extend = false);

    bool ReplaceInCommentValue(int index, ReadOnlySpan<char> replacement, int replacementStart,
        int replacementLength, bool extend = false);

    bool RemoveInCommentValue(int index, int length = 1);

    List<int> RemoveInCommentValueWhere(Func<int, char, bool> predicate);

    void ClearCommentValue();

    bool Contains(char character);

    bool Contains(Func<char, bool> predicate);

    bool Contains(Func<int, char, bool> predicate);
}