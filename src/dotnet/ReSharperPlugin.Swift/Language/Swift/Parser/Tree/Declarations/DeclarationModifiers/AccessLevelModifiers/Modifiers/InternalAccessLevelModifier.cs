using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using Internal = SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers.Keywords.Internal;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers.Modifiers;

public class InternalAccessLevelModifier : SwiftCompositeNode, IInternalAccessLevelModifier
{
    public Internal Internal { get; }

    internal InternalAccessLevelModifier(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        Internal @internal)
        : base(buffer, children)
    {
        Internal = @internal;
    }
}
