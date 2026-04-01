using System;
using System.Diagnostics;
using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Whitespace;

[DebuggerDisplay("NEW_LINE_LEAF_NODE ({Type})")]
public class NewLine : SwiftLeafNode<SwiftCompositeNode>, IWhitespaceNode
{
    private const string LineFeed = "\n";

    private const string CarriageReturn = "\r";

    private const string CarriageReturnLineFeed = "\r\n";

    internal NewLine(IEditableBuffer buffer)
        : base(buffer)
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

    internal NewLine(SwiftCompositeNode parent, int parentIndex, int parentTextIndex, IEditableBuffer buffer)
        : base(buffer, parent, parentIndex, parentTextIndex)
    {
        SetupInternals(buffer);
    }

    private NewLine(IEditableBuffer buffer, Kind type)
        : base(buffer)
    {
        Type = type;
    }

    internal NewLine(SwiftCompositeNode parent, int parentIndex, int parentTextIndex, IEditableBuffer buffer, Kind type)
        : base(buffer, parent, parentIndex, parentTextIndex)
    {
        Type = type;
    }

    public override NodeType NodeType => SwiftNodeTypes.NewLine;

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
            UnderlyingBuffer.Remove(1, 1);
            CascadeTextOffsetChange(-1);
        }

        UnderlyingBuffer.Replace(0, 1, LineFeed);
    }

    public void MakeLf()
    {
        MakeLineFeed();
    }

    public void MakeCarriageReturn()
    {
        if (Buffer.Length == 2)
        {
            UnderlyingBuffer.Remove(1, 1);
            CascadeTextOffsetChange(-1);
        }

        UnderlyingBuffer.Replace(0, 1, CarriageReturn);
    }

    public void MakeCr()
    {
        MakeCarriageReturn();
    }

    public void MakeLineFeedCarriageReturn()
    {
        if (Buffer.Length == 2)
        {
            UnderlyingBuffer.Replace(0, 2, CarriageReturnLineFeed);
            return;
        }

        UnderlyingBuffer.Replace(0, 1, CarriageReturnLineFeed);
        CascadeTextOffsetChange(1);
    }

    public static NewLine CreateLineFeed()
    {
        return new NewLine(new EditableBuffer(LineFeed), Kind.LineFeed);
    }

    public static NewLine CreateLineFeed(SwiftCompositeNode parent, int parentIndex)
    {
        NewLine node = CreateLineFeed();
        node.AttachToParent(parent, parentIndex);
        
        return node;
    }

    public static NewLine CreateLf()
    {
        return CreateLineFeed();
    }

    public static NewLine CreateLf(SwiftCompositeNode parent, int parentIndex)
    {
        return CreateLineFeed(parent, parentIndex);
    }

    public static NewLine CreateCarriageReturn()
    {
        return new NewLine(new EditableBuffer(CarriageReturn), Kind.CarriageReturn);
    }
    
    public static NewLine CreateCarriageReturn(SwiftCompositeNode parent, int parentIndex)
    {
        NewLine node = CreateCarriageReturn();
        node.AttachToParent(parent, parentIndex);
        
        return node;
    }

    public static NewLine CreateCr()
    {
        return CreateCarriageReturn();
    }
    
    public static NewLine CreateCr(SwiftCompositeNode parent, int parentIndex)
    {
        return CreateCarriageReturn(parent, parentIndex);
    }

    public static NewLine CreateCarriageReturnLineFeed()
    {
        return new NewLine(new EditableBuffer(CarriageReturnLineFeed), Kind.CarriageReturnLineFeed);
    }

    public static NewLine CreateCarriageReturnLineFeed(SwiftCompositeNode parent, int parentIndex)
    {
        NewLine node = CreateCarriageReturnLineFeed();
        node.AttachToParent(parent, parentIndex);
        
        return node;
    }

    public static NewLine CreateCrLf()
    {
        return CreateCarriageReturnLineFeed();
    }
    
    public static NewLine CreateCrLf(SwiftCompositeNode parent, int parentIndex)
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

    public new SwiftCompositeNode CloneAsDetached()
    {
        throw new NotImplementedException();
    }

    public new SwiftCompositeNode CloneAsAttachedTo(SwiftCompositeNode newParent, int index)
    {
        throw new NotImplementedException();
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