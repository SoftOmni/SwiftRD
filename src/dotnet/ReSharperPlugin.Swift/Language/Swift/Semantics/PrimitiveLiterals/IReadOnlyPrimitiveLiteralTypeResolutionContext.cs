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
    
    (IReadOnlyProtocolDeclaration type, bool isFallback) IntegerPointLiteralTypeProtocol { get; }
    
    (IReadOnlyProtocolDeclaration type, bool isFallback) FloatingPointLiteralTypeProtocol { get; }
    
    (IReadOnlyProtocolDeclaration type, bool isFallback) StringLiteralTypeProtocol { get; }

    (IReadOnlyProtocolDeclaration type, bool isFallback) RegularExpressionLiteralTypeProtocol { get; }
    
    (IReadOnlyProtocolDeclaration type, bool isFallback) BooleanLiteralTypeProtocol { get; }
    
    (IReadOnlyProtocolDeclaration type, bool isFallback) NilLiteralTypeProtocol { get; }
    
    (IReadOnlyProtocolDeclaration type, bool isFallback) UnicodeScalarLiteralTypeProtocol { get; }
    
    (IReadOnlyProtocolDeclaration type, bool isFallback) GraphemeClusterLiteralTypeProtocol { get; }

    IProtocolDeclaration GenerateDefaultIntegerLiteralTypeProtocol(IReadOnlySwiftVersion swiftVersion);

    IProtocolDeclaration GenerateDefaultFloatingPointLiteralTypeProtocol(IReadOnlySwiftVersion swiftVersion);

    IProtocolDeclaration GenerateDefaultStringLiteralTypeProtocol(IReadOnlySwiftVersion swiftVersion);

    IProtocolDeclaration GenerateDefaultRegularExpressionLiteralTypeProtocol(IReadOnlySwiftVersion swiftVersion);

    IProtocolDeclaration GenerateDefaultBooleanLiteralTypeProtocol(IReadOnlySwiftVersion swiftVersion);

    IProtocolDeclaration GenerateDefaultNilLiteralTypeProtocol(IReadOnlySwiftVersion swiftVersion);
    
    IProtocolDeclaration GenerateDefaultUnicodeScalarLiteralTypeProtocol(IReadOnlySwiftVersion swiftVersion);
    
    IProtocolDeclaration GenerateDefaultGraphemeClusterLiteralTypeProtocol(IReadOnlySwiftVersion swiftVersion);

    bool ConformsToDefaultIntegerLiteralTypeProtocol(IReadOnlyProtocolDeclaration integerLiteralProtocol);

    bool ConformsToDefaultFloatingPointLiteralTypeProtocol(IReadOnlyProtocolDeclaration floatingPointLiteralProtocol);

    bool ConformsToDefaultStringLiteralTypeProtocol(IReadOnlyProtocolDeclaration stringLiteralProtocol);

    bool ConformsToDefaultRegularExpressionLiteralTypeProtocol(IReadOnlyProtocolDeclaration regularExpressionLiteralProtocol);

    bool ConformsToDefaultBooleanLiteralTypeProtocol(IReadOnlyProtocolDeclaration booleanLiteralProtocol);

    bool ConformsToDefaultNilLiteralTypeProtocol(IReadOnlyProtocolDeclaration nilLiteralProtocol);

    bool ConformsToDefaultUnicodeScalarLiteralTypeProtocol(IReadOnlyProtocolDeclaration unicodeScalarLiteralProtocol);

    bool ConformsToDefaultGraphemeClusterLiteralTypeProtocol(IReadOnlyProtocolDeclaration graphemeClusterLiteralProtocol);
}
