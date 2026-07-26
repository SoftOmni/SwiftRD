using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.MutationModifiers;

public class MutatingMutationModifier : SwiftCompositeNode, IMutatingMutationModifier
{
    public Mutating Mutating { get; }

    internal MutatingMutationModifier(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        Mutating mutating)
        : base(buffer, children)
    {
        Mutating = mutating;
    }
}