using System;
using System.Diagnostics;
using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Whitespace;

[DebuggerDisplay("NEW_LINE_LEAF_NODE ({Type})")]
public class NewLine : SwiftLeafNode<SwiftCompositeNode>, INewLine
{
    private const string LineFeed = "\n";

    private const string CarriageReturn = "\r";

    private const string CarriageReturnLineFeed = "\r\n";

    internal NewLine(IEditableBuffer buffer)
        : base(buffer)
    {
        if (buffer.Length == 2)
        {
            Type = IReadOnlyNewLine.Kind.CarriageReturnLineFeed;
            return;
        }

        Type = buffer[0] == '\n'
            ? IReadOnlyNewLine.Kind.LineFeed
            : IReadOnlyNewLine.Kind.CarriageReturn;
    }

    internal NewLine(SwiftCompositeNode parent, int parentIndex, int parentTextIndex, IEditableBuffer buffer)
        : base(buffer, parent, parentIndex, parentTextIndex)
    {
        SetupInternals(buffer);
    }

    private NewLine(IEditableBuffer buffer, IReadOnlyNewLine.Kind type)
        : base(buffer)
    {
        Type = type;
    }

    internal NewLine(SwiftCompositeNode parent, int parentIndex, int parentTextIndex, IEditableBuffer buffer, IReadOnlyNewLine.Kind type)
        : base(buffer, parent, parentIndex, parentTextIndex)
    {
        Type = type;
    }

    public override NodeType NodeType => SwiftNodeTypes.NewLine;

    private void SetupInternals(IEditableBuffer buffer)
    {
        if (buffer.Length == 2)
        {
            Type = IReadOnlyNewLine.Kind.CarriageReturnLineFeed;
            return;
        }

        Type = buffer[0] == '\n'
            ? IReadOnlyNewLine.Kind.LineFeed
            : IReadOnlyNewLine.Kind.CarriageReturn;
    }

    public IReadOnlyNewLine.Kind Type { get; private set; }

    public bool IsLineFeed => Type is IReadOnlyNewLine.Kind.LineFeed;

    public bool IsLf => IsLineFeed;

    public bool IsCarriageReturn => Type is IReadOnlyNewLine.Kind.CarriageReturn;

    public bool IsCr => IsCarriageReturn;

    public bool IsCarriageReturnLineFeed => Type is IReadOnlyNewLine.Kind.CarriageReturnLineFeed;

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
        return new NewLine(new EditableBuffer(LineFeed), IReadOnlyNewLine.Kind.LineFeed);
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
        return new NewLine(new EditableBuffer(CarriageReturn), IReadOnlyNewLine.Kind.CarriageReturn);
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
        return new NewLine(new EditableBuffer(CarriageReturnLineFeed), IReadOnlyNewLine.Kind.CarriageReturnLineFeed);
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

