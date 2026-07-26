using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.WillSetDidSetBlocks.Clauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.WillSetDidSetBlocks;

public class WillSetDidSetBlock : SwiftCompositeNode, IWillSetDidSetBlock
{
    public LeftCurlyBrace WillSetDidSetBlockStart { get; }

    public IWillSetClause? WillSetClause { get; }

    public IDidSetClause? DidSetClause { get; }

    public RightCurlyBrace WillSetDidSetBlockEnd { get; }

    internal WillSetDidSetBlock(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        LeftCurlyBrace willSetDidSetBlockStart, IWillSetClause? willSetClause,
        IDidSetClause? didSetClause, RightCurlyBrace willSetDidSetBlockEnd)
        : base(buffer, children)
    {
        WillSetDidSetBlockStart = willSetDidSetBlockStart;
        WillSetClause = willSetClause;
        DidSetClause = didSetClause;
        WillSetDidSetBlockEnd = willSetDidSetBlockEnd;
    }

    IReadOnlyWillSetClause? IReadOnlyWillSetDidSetBlock.WillSetClause => WillSetClause;

    IReadOnlyDidSetClause? IReadOnlyWillSetDidSetBlock.DidSetClause => DidSetClause;

    public bool WillSetIsFirst()
    {
        if (DidSetClause is null)
        {
            return WillSetClause is not null;
        }

        return WillSetClause is not null && WillSetClause.ParentIndex < DidSetClause.ParentIndex;
    }

    public bool DidSetIsFirst()
    {
        if (WillSetClause is null)
        {
            return DidSetClause is not null;
        }

        return DidSetClause is not null && DidSetClause.ParentIndex < WillSetClause.ParentIndex;
    }

    public bool CanInvert()
    {
        return WillSetClause is not null && DidSetClause is not null;
    }

    public void MakeWillSetFirst()
    {
        throw new NotImplementedException();
    }

    public void MakeDidSetFirst()
    {
        throw new NotImplementedException();
    }

    public void Invert()
    {
        throw new NotImplementedException();
    }
}
