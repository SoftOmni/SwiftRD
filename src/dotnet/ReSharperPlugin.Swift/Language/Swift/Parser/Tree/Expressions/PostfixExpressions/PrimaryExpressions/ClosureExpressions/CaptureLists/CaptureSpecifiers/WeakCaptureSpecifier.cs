using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions.CaptureLists.CaptureSpecifiers;

public class WeakCaptureSpecifier : SwiftCompositeNode, IWeakCaptureSpecifier
{
    public Weak Weak { get; }

    internal WeakCaptureSpecifier(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children, Weak weak)
        : base(buffer, children)
    {
        Weak = weak;
    }
}
