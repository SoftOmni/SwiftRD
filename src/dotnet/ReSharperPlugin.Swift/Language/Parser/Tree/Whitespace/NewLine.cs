using System;
using System.Diagnostics;
using JetBrains.DocumentModel.Impl;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Whitespace;

[DebuggerDisplay("NEW_LINE_LEAF_NODE ({Type})")]
public class NewLine : SwiftLeafNode
{
    private const string LineFeed = "\n";

    private const string CarriageReturn = "\r";

    private const string CarriageReturnLineFeed = "\r\n";

    internal NewLine(IEditableBuffer buffer) : base(buffer, NodeTypes.NodeTypes.NewLine)
    {
        if (buffer.Length == 2)
        {
            Type = Kind.CarriageReturnLineFeed;
            return;
        }

        Type = buffer[0] == '\n'
            ? Kind.LineFeed
            : Kind.CarriageReturn;
    }

    private NewLine(IEditableBuffer buffer, Kind type)
        : base(buffer, NodeTypes.NodeTypes.NewLine)
    {
        Type = type;
    }

    public Kind Type { get; }

    public bool IsLineFeed => Type is Kind.LineFeed;

    public bool IsLf => IsLineFeed;

    public bool IsCarriageReturn => Type is Kind.CarriageReturn;

    public bool IsCr => IsCarriageReturn;

    public bool IsCarriageReturnLineFeed => Type is Kind.CarriageReturnLineFeed;

    public bool IsCrLf => IsCarriageReturnLineFeed;

    public void MakeLineFeed()
    {
        if (Buffer.Length == 2)
        {
            Buffer.Remove(1, 1);
        }

        Buffer.Replace(0, 1, LineFeed);
    }

    public void MakeLf()
    {
        MakeLineFeed();
    }

    public void MakeCarriageReturn()
    {
        if (Buffer.Length == 2)
        {
            Buffer.Remove(1, 1);
        }

        Buffer.Replace(0, 1, CarriageReturn);
    }

    public void MakeCr()
    {
        MakeCarriageReturn();
    }

    public void MakeLineFeedCarriageReturn()
    {
        if (Buffer.Length == 2)
        {
            Buffer.Replace(0, 2, CarriageReturnLineFeed);
            return;
        }

        Buffer.Replace(0, 1, CarriageReturnLineFeed);
    }

    public static NewLine CreateLineFeed()
    {
        return new NewLine(new EditableBuffer(LineFeed), Kind.LineFeed);
    }

    public static NewLine CreateLf()
    {
        return CreateLineFeed();
    }

    public static NewLine CreateCarriageReturn()
    {
        return new NewLine(new EditableBuffer(CarriageReturn), Kind.CarriageReturn);
    }

    public static NewLine CreateCr()
    {
        return CreateCarriageReturn();
    }

    public static NewLine CreateCarriageReturnLineFeed()
    {
        return new NewLine(new EditableBuffer(CarriageReturnLineFeed), Kind.CarriageReturnLineFeed);
    }

    public static NewLine CreateCrLf()
    {
        return CreateCarriageReturnLineFeed();
    }
    
    public enum Kind
    {
        LineFeed,
        CarriageReturn,
        CarriageReturnLineFeed
    }

    public override string ToString()
    {
        return Buffer.GetText();
    }

    public string AsString()
    {
        return Type.ToString();
    }

    public string ToAbbreviatedForm()
    {
        return Type.AbbreviatedForm();
    }

    protected override ISwiftNode Clone()
    {
        return new NewLine(EditableBufferExtensions.CloneBuffer(EditableBuffer), Type);
    }
}

public static class NewLineNodeKindExtensions
{
    public static bool IsLineFeed(this NewLine.Kind kind) => kind is NewLine.Kind.LineFeed;

    public static bool IsCarriageReturn(this NewLine.Kind kind) => kind is NewLine.Kind.CarriageReturn;

    public static bool IsCarriageReturnLineFeed(this NewLine.Kind kind) =>
        kind is NewLine.Kind.CarriageReturnLineFeed;

    public static int Length(this NewLine.Kind kind)
    {
        return kind switch
        {
            NewLine.Kind.LineFeed => 1,
            NewLine.Kind.CarriageReturn => 1,
            NewLine.Kind.CarriageReturnLineFeed => 2,
            _ => throw new ArgumentOutOfRangeException(nameof(kind), kind, null)
        };
    }

    public static string EscapeRepresentation(this NewLine.Kind kind)
    {
        return kind switch
        {
            NewLine.Kind.LineFeed => "\\n",
            NewLine.Kind.CarriageReturn => "\\r",
            NewLine.Kind.CarriageReturnLineFeed => "\\r\\n",
            _ => throw new ArgumentOutOfRangeException(nameof(kind), kind, null)
        };
    }

    public static string ToString(this NewLine.Kind kind)
    {
        return kind switch
        {
            NewLine.Kind.LineFeed => "\n",
            NewLine.Kind.CarriageReturn => "\r",
            NewLine.Kind.CarriageReturnLineFeed => "\r\n",
            _ => throw new ArgumentOutOfRangeException(nameof(kind), kind, null)
        };
    }

    public static string DebuggerRepresentation(this NewLine.Kind kind)
    {
        return kind switch
        {
            NewLine.Kind.LineFeed => "LINE_FEED",
            NewLine.Kind.CarriageReturn => "CARRIAGE_RETURN",
            NewLine.Kind.CarriageReturnLineFeed => "CARRIAGE_RETURN_LINE_FEED",
            _ => throw new ArgumentOutOfRangeException(nameof(kind), kind, null)
        };
    }

    public static string AbbreviatedForm(this NewLine.Kind kind)
    {
        return kind switch
        {
            NewLine.Kind.LineFeed => "LF",
            NewLine.Kind.CarriageReturn => "CR",
            NewLine.Kind.CarriageReturnLineFeed => "CRLF",
            _ => throw new ArgumentOutOfRangeException(nameof(kind), kind, null)
        };
    }
}