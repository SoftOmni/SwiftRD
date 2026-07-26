using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Enumerations.Members.RawValueStyle;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Enumerations.Members.UnionStyle;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements;

public interface IReadOnlyCompilerControlStatement : IReadOnlyStatement, IReadOnlyUnionStyleMember,
    IReadOnlyRawValueStyleMember;
