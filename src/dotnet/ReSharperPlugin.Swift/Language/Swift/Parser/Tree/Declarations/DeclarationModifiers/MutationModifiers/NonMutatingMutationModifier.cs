using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.MutationModifiers;

public class NonMutatingMutationModifier : SwiftCompositeNode, INonMutatingMutationModifier
{
    public NonMutating NonMutating { get; }

    internal NonMutatingMutationModifier(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        NonMutating nonMutating)
        : base(buffer, children)
    {
        NonMutating = nonMutating;
    }
}
