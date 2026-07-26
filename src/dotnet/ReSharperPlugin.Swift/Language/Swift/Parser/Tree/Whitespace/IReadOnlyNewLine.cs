using System;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.LeafNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Whitespace;

public interface IReadOnlyNewLine : IReadOnlyWhitespaceNode
{
    public enum Kind
    {
        LineFeed,
        CarriageReturn,
        CarriageReturnLineFeed
    }
    
    public Kind Type { get; }

    public bool IsLineFeed { get; }

    public bool IsLf { get; }

    public bool IsCarriageReturn { get; }

    public bool IsCr { get; }

    public bool IsCarriageReturnLineFeed { get; }

    public bool IsCrLf { get; }

    public string AsString();

    public string ToAbbreviatedForm();
}

public static class NewLineNodeKindExtensions
{
    extension(IReadOnlyNewLine.Kind kind)
    {
        public bool IsLineFeed() => kind is IReadOnlyNewLine.Kind.LineFeed;
        public bool IsCarriageReturn() => kind is IReadOnlyNewLine.Kind.CarriageReturn;

        public bool IsCarriageReturnLineFeed() =>
            kind is IReadOnlyNewLine.Kind.CarriageReturnLineFeed;

        public int Length()
        {
            return kind switch
            {
                IReadOnlyNewLine.Kind.LineFeed => 1,
                IReadOnlyNewLine.Kind.CarriageReturn => 1,
                IReadOnlyNewLine.Kind.CarriageReturnLineFeed => 2,
                _ => throw new ArgumentOutOfRangeException(nameof(kind), kind, null)
            };
        }

        public string EscapeRepresentation()
        {
            return kind switch
            {
                IReadOnlyNewLine.Kind.LineFeed => @"\n",
                IReadOnlyNewLine.Kind.CarriageReturn => @"\r",
                IReadOnlyNewLine.Kind.CarriageReturnLineFeed => @"\r\n",
                _ => throw new ArgumentOutOfRangeException(nameof(kind), kind, null)
            };
        }

        public string ToString()
        {
            return kind switch
            {
                IReadOnlyNewLine.Kind.LineFeed => "\n",
                IReadOnlyNewLine.Kind.CarriageReturn => "\r",
                IReadOnlyNewLine.Kind.CarriageReturnLineFeed => "\r\n",
                _ => throw new ArgumentOutOfRangeException(nameof(kind), kind, null)
            };
        }

        public string DebuggerRepresentation()
        {
            return kind switch
            {
                IReadOnlyNewLine.Kind.LineFeed => "LINE_FEED",
                IReadOnlyNewLine.Kind.CarriageReturn => "CARRIAGE_RETURN",
                IReadOnlyNewLine.Kind.CarriageReturnLineFeed => "CARRIAGE_RETURN_LINE_FEED",
                _ => throw new ArgumentOutOfRangeException(nameof(kind), kind, null)
            };
        }

        public string AbbreviatedForm()
        {
            return kind switch
            {
                IReadOnlyNewLine.Kind.LineFeed => "LF",
                IReadOnlyNewLine.Kind.CarriageReturn => "CR",
                IReadOnlyNewLine.Kind.CarriageReturnLineFeed => "CRLF",
                _ => throw new ArgumentOutOfRangeException(nameof(kind), kind, null)
            };
        }
    }
}
