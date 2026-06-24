using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions.CaptureLists;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions.ClosureSignatures;

public class SimpleClosureSignature : SwiftCompositeNode, ISimpleClosureSignature
{
    public ICaptureList CaptureList { get; }

    public In In { get; }

    internal SimpleClosureSignature(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children, 
        ICaptureList captureList, In @in)
        : base(buffer, children)
    {
        CaptureList = captureList;
        In = @in;
    }

    IReadOnlyCaptureList IReadOnlySimpleClosureSignature.CaptureList => CaptureList;

    public void ChangeCaptureList(ICaptureList newCaptureList)
    {
        throw new System.NotImplementedException();
    }
}
