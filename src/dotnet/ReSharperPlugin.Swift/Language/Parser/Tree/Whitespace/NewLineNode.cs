using System;
using System.Diagnostics;
using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Whitespace;

[DebuggerDisplay("NEW_LINE_LEAF_NODE")]
public class NewLineNode : SwiftLeafNode
{
    private const string LineFeed = "\n";

    private const string CarriageReturn = "\r";

    private const string CarriageReturnLineFeed = "\r\n";

    public NewLineNode(IEditableBuffer buffer) : base(buffer, NodeTypes.NodeTypes.NewLine)
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

    internal NewLineNode(IEditableBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
        : this(buffer)
    { }

    private NewLineNode(IEditableBuffer buffer, Kind type)
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

    public static NewLineNode CreateLineFeed()
    {
        return new NewLineNode(new EditableBuffer(LineFeed), Kind.LineFeed);
    }

    public static NewLineNode CreateLf()
    {
        return CreateLineFeed();
    }

    public static NewLineNode CreateCarriageReturn()
    {
        return new NewLineNode(new EditableBuffer(CarriageReturn), Kind.CarriageReturn);
    }

    public static NewLineNode CreateCr()
    {
        return CreateCarriageReturn();
    }

    public static NewLineNode CreateCarriageReturnLineFeed()
    {
        return new NewLineNode(new EditableBuffer(CarriageReturnLineFeed), Kind.CarriageReturnLineFeed);
    }

    public static NewLineNode CreateCrLf()
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
}

public static class NewLineNodeKindExtensions
{
    public static bool IsLineFeed(this NewLineNode.Kind kind) => kind is NewLineNode.Kind.LineFeed;

    public static bool IsCarriageReturn(this NewLineNode.Kind kind) => kind is NewLineNode.Kind.CarriageReturn;

    public static bool IsCarriageReturnLineFeed(this NewLineNode.Kind kind) =>
        kind is NewLineNode.Kind.CarriageReturnLineFeed;

    public static int Length(this NewLineNode.Kind kind)
    {
        return kind switch
        {
            NewLineNode.Kind.LineFeed => 1,
            NewLineNode.Kind.CarriageReturn => 1,
            NewLineNode.Kind.CarriageReturnLineFeed => 2,
            _ => throw new ArgumentOutOfRangeException(nameof(kind), kind, null)
        };
    }

    public static string EscapeRepresentation(this NewLineNode.Kind kind)
    {
        return kind switch
        {
            NewLineNode.Kind.LineFeed => "\\n",
            NewLineNode.Kind.CarriageReturn => "\\r",
            NewLineNode.Kind.CarriageReturnLineFeed => "\\r\\n",
            _ => throw new ArgumentOutOfRangeException(nameof(kind), kind, null)
        };
    }

    public static string ToString(this NewLineNode.Kind kind)
    {
        return kind switch
        {
            NewLineNode.Kind.LineFeed => "\n",
            NewLineNode.Kind.CarriageReturn => "\r",
            NewLineNode.Kind.CarriageReturnLineFeed => "\r\n",
            _ => throw new ArgumentOutOfRangeException(nameof(kind), kind, null)
        };
    }

    public static string DebuggerRepresentation(this NewLineNode.Kind kind)
    {
        return kind switch
        {
            NewLineNode.Kind.LineFeed => "LINE_FEED",
            NewLineNode.Kind.CarriageReturn => "CARRIAGE_RETURN",
            NewLineNode.Kind.CarriageReturnLineFeed => "CARRIAGE_RETURN_LINE_FEED",
            _ => throw new ArgumentOutOfRangeException(nameof(kind), kind, null)
        };
    }

    public static string AbbreviatedForm(this NewLineNode.Kind kind)
    {
        return kind switch
        {
            NewLineNode.Kind.LineFeed => "LF",
            NewLineNode.Kind.CarriageReturn => "CR",
            NewLineNode.Kind.CarriageReturnLineFeed => "CRLF",
            _ => throw new ArgumentOutOfRangeException(nameof(kind), kind, null)
        };
    }
}