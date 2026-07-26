using JetBrains.Application.UI.Icons.CompiledIcons;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Enumerations.Members.RawValueStyle;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Enumerations.Members.UnionStyle;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations;

public interface IReadOnlyDeclaration : ISwiftInternalNode<SwiftCompositeNode>,
    IReadOnlyUnionStyleMember, IReadOnlyRawValueStyleMember
{

    public AnyCompiledIconClass Icon { get; }
}
