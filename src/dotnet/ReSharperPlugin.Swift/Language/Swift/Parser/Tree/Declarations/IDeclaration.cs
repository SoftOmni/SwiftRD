using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Enumerations.Members.RawValueStyle;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Enumerations.Members.UnionStyle;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations;

public interface IDeclaration : IReadOnlyDeclaration, IUnionStyleMember, IRawValueStyleMember;
