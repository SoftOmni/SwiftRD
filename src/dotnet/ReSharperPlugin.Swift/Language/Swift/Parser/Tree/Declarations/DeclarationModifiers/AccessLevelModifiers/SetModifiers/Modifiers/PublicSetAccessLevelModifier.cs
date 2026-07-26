using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers.Modifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.GetterSetterBlocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers.
    SetModifiers.Modifiers;

public class PublicSetAccessLevelModifier :
    SwiftCompositeNode, IPublicSetAccessLevelModifier
{
    private IReadOnlyPrivateAccessLevelModifier _accessLevelModifier;
    public IOpenAccessLevelModifier AccessLevelModifier { get; }

    public LeftParenthesis SetStart { get; }

    public Set Set { get; }

    public RightParenthesis SetEnd { get; }

    internal PublicSetAccessLevelModifier(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IOpenAccessLevelModifier accessLevelModifier, LeftParenthesis setStart, Set set, RightParenthesis setEnd)
        : base(buffer, children)
    {
        AccessLevelModifier = accessLevelModifier;
        SetStart = setStart;
        Set = set;
        SetEnd = setEnd;
    }

    IReadOnlyAccessLevelModifier IReadOnlySetAccessLevelModifier.AccessLevelModifier => AccessLevelModifier;

    IReadOnlyPrivateAccessLevelModifier IReadOnlyPrivateSetAccessLevelModifier.AccessLevelModifier => _accessLevelModifier;

    IAccessLevelModifier ISetAccessLevelModifier.AccessLevelModifier => AccessLevelModifier;
}
