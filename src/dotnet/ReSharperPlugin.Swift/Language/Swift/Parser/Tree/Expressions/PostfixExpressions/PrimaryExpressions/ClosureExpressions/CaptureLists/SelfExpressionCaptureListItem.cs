using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions.
    CaptureLists.CaptureSpecifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.SelfExpressions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.
    ClosureExpressions.CaptureLists;

public class SelfExpressionCaptureListItem : SwiftCompositeNode, ISelfExpressionCaptureListItem
{
    public ICaptureSpecifier? CaptureSpecifier { get; }

    public ISelfExpression SelfExpression { get; }

    internal SelfExpressionCaptureListItem(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        ISelfExpression selfExpression)
        : base(buffer, children)
    {
        CaptureSpecifier = null;
        SelfExpression = selfExpression;
    }

    internal SelfExpressionCaptureListItem(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        ICaptureSpecifier? captureSpecifier, ISelfExpression selfExpression)
        : base(buffer, children)
    {
        CaptureSpecifier = captureSpecifier;
        SelfExpression = selfExpression;
    }

    IReadOnlyCaptureSpecifier? IReadOnlyCaptureListItem.CaptureSpecifier => CaptureSpecifier;

    IReadOnlySelfExpression IReadOnlySelfExpressionCaptureListItem.SelfExpression => SelfExpression;

    public void SetCaptureSpecifier(ICaptureSpecifier? newCaptureSpecifier)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveCaptureSpecifier()
    {
        throw new System.NotImplementedException();
    }

    public void ChangeSelfExpression(ISelfExpression newSelfExpression)
    {
        throw new System.NotImplementedException();
    }

    public void MakeWeak()
    {
        throw new System.NotImplementedException();
    }

    public void MakeUnowned()
    {
        throw new System.NotImplementedException();
    }

    public void MakeUnownedSafe()
    {
        throw new System.NotImplementedException();
    }

    public void MakeUnownedUnsafe()
    {
        throw new System.NotImplementedException();
    }
}