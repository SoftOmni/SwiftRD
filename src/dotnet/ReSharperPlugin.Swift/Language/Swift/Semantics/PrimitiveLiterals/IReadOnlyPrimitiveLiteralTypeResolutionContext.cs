using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Protocols;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.CompilationConditions.PlatformConditions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Semantics.PrimitiveLiterals;

public interface IReadOnlyPrimitiveLiteralTypeResolutionContext
{
    (IReadOnlyType type, bool isFallback) DefaultIntegerLiteralType { get; }
    
    (IReadOnlyType type, bool isFallback) DefaultFloatingPointLiteralType { get; }
    
    (IReadOnlyType type, bool isFallback) DefaultStringLiteralType { get; }

    (IReadOnlyType type, bool isFallback) DefaultRegularExpressionLiteralType { get; }
    
    (IReadOnlyType type, bool isFallback) DefaultBooleanLiteralType { get; }
    
    (IReadOnlyType type, bool isFallback) DefaultNilLiteralType { get; }
    
    (IReadOnlyType type, bool isFallback) DefaultUnicodeScalarLiteralType { get; }
    
    (IReadOnlyType type, bool isFallback) DefaultGraphemeClusterLiteralType { get; }
    
    (IReadOnlyProtocol type, bool isFallback) IntegerPointLiteralTypeProtocol { get; }
    
    (IReadOnlyProtocol type, bool isFallback) FloatingPointLiteralTypeProtocol { get; }
    
    (IReadOnlyProtocol type, bool isFallback) StringLiteralTypeProtocol { get; }

    (IReadOnlyProtocol type, bool isFallback) RegularExpressionLiteralTypeProtocol { get; }
    
    (IReadOnlyProtocol type, bool isFallback) BooleanLiteralTypeProtocol { get; }
    
    (IReadOnlyProtocol type, bool isFallback) NilLiteralTypeProtocol { get; }
    
    (IReadOnlyProtocol type, bool isFallback) UnicodeScalarLiteralTypeProtocol { get; }
    
    (IReadOnlyProtocol type, bool isFallback) GraphemeClusterLiteralTypeProtocol { get; }

    IReadOnlyProtocol GenerateDefaultIntegerLiteralTypeProtocol(IReadOnlySwiftVersion swiftVersion);

    IReadOnlyProtocol GenerateDefaultFloatingPointLiteralTypeProtocol(IReadOnlySwiftVersion swiftVersion);

    IReadOnlyProtocol GenerateDefaultStringLiteralTypeProtocol(IReadOnlySwiftVersion swiftVersion);

    IReadOnlyProtocol GenerateDefaultRegularExpressionLiteralTypeProtocol(IReadOnlySwiftVersion swiftVersion);

    IReadOnlyProtocol GenerateDefaultBooleanLiteralTypeProtocol(IReadOnlySwiftVersion swiftVersion);

    IReadOnlyProtocol GenerateDefaultNilLiteralTypeProtocol(IReadOnlySwiftVersion swiftVersion);
    
    IReadOnlyProtocol GenerateDefaultUnicodeScalarLiteralTypeProtocol(IReadOnlySwiftVersion swiftVersion);
    
    IReadOnlyProtocol GenerateDefaultGraphemeClusterLiteralTypeProtocol(IReadOnlySwiftVersion swiftVersion);

    bool ConformsToDefaultIntegerLiteralTypeProtocol(IReadOnlyProtocol integerLiteralProtocol);

    bool ConformsToDefaultFloatingPointLiteralTypeProtocol(IReadOnlyProtocol floatingPointLiteralProtocol);

    bool ConformsToDefaultStringLiteralTypeProtocol(IReadOnlyProtocol stringLiteralProtocol);

    bool ConformsToDefaultRegularExpressionLiteralTypeProtocol(IReadOnlyProtocol regularExpressionLiteralProtocol);

    bool ConformsToDefaultBooleanLiteralTypeProtocol(IReadOnlyProtocol booleanLiteralProtocol);

    bool ConformsToDefaultNilLiteralTypeProtocol(IReadOnlyProtocol nilLiteralProtocol);

    bool ConformsToDefaultUnicodeScalarLiteralTypeProtocol(IReadOnlyProtocol unicodeScalarLiteralProtocol);

    bool ConformsToDefaultGraphemeClusterLiteralTypeProtocol(IReadOnlyProtocol graphemeClusterLiteralProtocol);
}
