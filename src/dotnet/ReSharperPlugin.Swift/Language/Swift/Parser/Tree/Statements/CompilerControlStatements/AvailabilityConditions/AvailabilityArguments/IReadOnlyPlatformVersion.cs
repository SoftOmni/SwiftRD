using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.IntegerLiterals;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.AvailabilityConditions.AvailabilityArguments;

public interface IReadOnlyPlatformVersion : ISwiftNode<SwiftCompositeNode>
{
    IReadOnlyIntegerLiteral MajorVersion { get; }
    
    Period? MajorMinorVersionSeparator { get; }
    
    IReadOnlyIntegerLiteral? MinorVersion { get; }
    
    Period? MinorPatchVersionSeparator { get; }
    
    IReadOnlyIntegerLiteral? PatchVersion { get; }
}
