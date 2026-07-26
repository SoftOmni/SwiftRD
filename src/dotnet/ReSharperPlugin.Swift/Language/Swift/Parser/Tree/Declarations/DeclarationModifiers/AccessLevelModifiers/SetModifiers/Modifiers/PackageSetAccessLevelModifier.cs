using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers.Modifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.GetterSetterBlocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers.
    SetModifiers.Modifiers;

public class PackageSetAccessLevelModifier :
    SwiftCompositeNode, IPackageSetAccessLevelModifier
{
    public IPackageAccessLevelModifier AccessLevelModifier { get; }

    public LeftParenthesis SetStart { get; }

    public Set Set { get; }

    public RightParenthesis SetEnd { get; }

    internal PackageSetAccessLevelModifier(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IPackageAccessLevelModifier accessLevelModifier, LeftParenthesis setStart, Set set, RightParenthesis setEnd)
        : base(buffer, children)
    {
        AccessLevelModifier = accessLevelModifier;
        SetStart = setStart;
        Set = set;
        SetEnd = setEnd;
    }

    IReadOnlyAccessLevelModifier IReadOnlySetAccessLevelModifier.AccessLevelModifier => AccessLevelModifier;

    IReadOnlyPackageAccessLevelModifier IReadOnlyPackageSetAccessLevelModifier.AccessLevelModifier => AccessLevelModifier;

    IAccessLevelModifier ISetAccessLevelModifier.AccessLevelModifier => AccessLevelModifier;
}
