using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.ActorIsolationModifiers;

public class ActorIsolationModifier : SwiftCompositeNode, INonIsolatedActorIsolationModifier
{
    public NonIsolated NonIsolated { get; }

    internal ActorIsolationModifier(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        NonIsolated nonIsolated)
        : base(buffer, children)
    {
        NonIsolated = nonIsolated;
    }
}