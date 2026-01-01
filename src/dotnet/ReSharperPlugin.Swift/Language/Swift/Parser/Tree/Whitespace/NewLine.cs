using System;
using System.Diagnostics;
using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Whitespace;

[DebuggerDisplay("NEW_LINE_LEAF_NODE ({Type})")]
public class NewLine : SwiftLeafNode, IWhitespaceNode
{
    private const string LineFeed = "\n";

    private const string CarriageReturn = "\r";

    private const string CarriageReturnLineFeed = "\r\n";

    internal NewLine(IEditableBuffer buffer)
        : base(buffer, NodeTypes.NodeTypes.NewLine)
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

    internal NewLine(SwiftInternalNode parent, int parentIndex, int parentTextIndex, IEditableBuffer buffer)
        : base(parent, parentIndex, parentTextIndex, buffer, NodeTypes.NodeTypes.NewLine)
    {
        SetupInternals(buffer);
    }

    private NewLine(IEditableBuffer buffer, Kind type)
        : base(buffer, NodeTypes.NodeTypes.NewLine)
    {
        Type = type;
    }

    internal NewLine(SwiftInternalNode parent, int parentIndex, int parentTextIndex, IEditableBuffer buffer, Kind type)
        : base(parent, parentIndex, parentTextIndex, buffer, NodeTypes.NodeTypes.NewLine)
    {
        Type = type;
    }

    private void SetupInternals(IEditableBuffer buffer)
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

    public Kind Type { get; private set; }

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
            EditableBuffer.Remove(1, 1);
        }

        EditableBuffer.Replace(0, 1, LineFeed);
    }

    public void MakeLf()
    {
        MakeLineFeed();
    }

    public void MakeCarriageReturn()
    {
        if (Buffer.Length == 2)
        {
            EditableBuffer.Remove(1, 1);
        }

        EditableBuffer.Replace(0, 1, CarriageReturn);
    }

    public void MakeCr()
    {
        MakeCarriageReturn();
    }

    public void MakeLineFeedCarriageReturn()
    {
        if (Buffer.Length == 2)
        {
            EditableBuffer.Replace(0, 2, CarriageReturnLineFeed);
            return;
        }

        EditableBuffer.Replace(0, 1, CarriageReturnLineFeed);
    }

    public static NewLine CreateLineFeed()
    {
        return new NewLine(new EditableBuffer(LineFeed), Kind.LineFeed);
    }

    public static NewLine CreateLineFeed(SwiftInternalNode parent, int parentIndex)
    {
        NewLine node = CreateLineFeed();
        node.AttachToParent(parent, parentIndex);
        
        return node;
    }

    public static NewLine CreateLf()
    {
        return CreateLineFeed();
    }

    public static NewLine CreateLf(SwiftInternalNode parent, int parentIndex)
    {
        return CreateLineFeed(parent, parentIndex);
    }

    public static NewLine CreateCarriageReturn()
    {
        return new NewLine(new EditableBuffer(CarriageReturn), Kind.CarriageReturn);
    }
    
    public static NewLine CreateCarriageReturn(SwiftInternalNode parent, int parentIndex)
    {
        NewLine node = CreateCarriageReturn();
        node.AttachToParent(parent, parentIndex);
        
        return node;
    }

    public static NewLine CreateCr()
    {
        return CreateCarriageReturn();
    }
    
    public static NewLine CreateCr(SwiftInternalNode parent, int parentIndex)
    {
        return CreateCarriageReturn(parent, parentIndex);
    }

    public static NewLine CreateCarriageReturnLineFeed()
    {
        return new NewLine(new EditableBuffer(CarriageReturnLineFeed), Kind.CarriageReturnLineFeed);
    }

    public static NewLine CreateCarriageReturnLineFeed(SwiftInternalNode parent, int parentIndex)
    {
        NewLine node = CreateCarriageReturnLineFeed();
        node.AttachToParent(parent, parentIndex);
        
        return node;
    }

    public static NewLine CreateCrLf()
    {
        return CreateCarriageReturnLineFeed();
    }
    
    public static NewLine CreateCrLf(SwiftInternalNode parent, int parentIndex)
    {
        return CreateCarriageReturnLineFeed(parent, parentIndex);
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
    extension(NewLine.Kind kind)
    {
        public bool IsLineFeed() => kind is NewLine.Kind.LineFeed;
        public bool IsCarriageReturn() => kind is NewLine.Kind.CarriageReturn;

        public bool IsCarriageReturnLineFeed() =>
            kind is NewLine.Kind.CarriageReturnLineFeed;

        public int Length()
        {
            return kind switch
            {
                NewLine.Kind.LineFeed => 1,
                NewLine.Kind.CarriageReturn => 1,
                NewLine.Kind.CarriageReturnLineFeed => 2,
                _ => throw new ArgumentOutOfRangeException(nameof(kind), kind, null)
            };
        }

        public string EscapeRepresentation()
        {
            return kind switch
            {
                NewLine.Kind.LineFeed => @"\n",
                NewLine.Kind.CarriageReturn => @"\r",
                NewLine.Kind.CarriageReturnLineFeed => @"\r\n",
                _ => throw new ArgumentOutOfRangeException(nameof(kind), kind, null)
            };
        }

        public string ToString()
        {
            return kind switch
            {
                NewLine.Kind.LineFeed => "\n",
                NewLine.Kind.CarriageReturn => "\r",
                NewLine.Kind.CarriageReturnLineFeed => "\r\n",
                _ => throw new ArgumentOutOfRangeException(nameof(kind), kind, null)
            };
        }

        public string DebuggerRepresentation()
        {
            return kind switch
            {
                NewLine.Kind.LineFeed => "LINE_FEED",
                NewLine.Kind.CarriageReturn => "CARRIAGE_RETURN",
                NewLine.Kind.CarriageReturnLineFeed => "CARRIAGE_RETURN_LINE_FEED",
                _ => throw new ArgumentOutOfRangeException(nameof(kind), kind, null)
            };
        }

        public string AbbreviatedForm()
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
}