using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions.CaptureLists.CaptureSpecifiers;

public class UnownedCaptureSpecifier : SwiftCompositeNode, IUnownedCaptureSpecifier
{
    public Unowned Unowned { get; }

    internal UnownedCaptureSpecifier(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children, Unowned unowned)
        : base(buffer, children)
    {
        Unowned = unowned;
    }
}
