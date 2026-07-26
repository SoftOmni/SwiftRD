using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Protocols;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Semantics.PrimitiveLiterals;

public interface IPrimitiveLiteralTypeResolutionContext : IReadOnlyPrimitiveLiteralTypeResolutionContext
{
    new (IType Type, bool IsFallback) DefaultIntegerLiteralType { get; }

    new (IType Type, bool IsFallback) DefaultFloatingPointLiteralType { get; }

    new (IType Type, bool IsFallback) DefaultStringLiteralType { get; }

    new (IType Type, bool IsFallback) DefaultRegularExpressionLiteralType { get; }

    new (IType Type, bool IsFallback) DefaultBooleanLiteralType { get; }

    new (IType Type, bool IsFallback) DefaultNilLiteralType { get; }

    new (IType Type, bool IsFallback) DefaultUnicodeScalarLiteralType { get; }

    new (IType Type, bool IsFallback) DefaultGraphemeClusterLiteralType { get; }

    new (IProtocolDeclaration Type, bool IsFallback) IntegerPointLiteralTypeProtocol { get; }

    new (IProtocolDeclaration Type, bool IsFallback) FloatingPointLiteralTypeProtocol { get; }

    new (IProtocolDeclaration Type, bool IsFallback) StringLiteralTypeProtocol { get; }

    new (IProtocolDeclaration Type, bool IsFallback) RegularExpressionLiteralTypeProtocol { get; }

    new (IProtocolDeclaration Type, bool IsFallback) BooleanLiteralTypeProtocol { get; }

    new (IProtocolDeclaration Type, bool IsFallback) NilLiteralTypeProtocol { get; }

    new (IProtocolDeclaration Type, bool IsFallback) UnicodeScalarLiteralTypeProtocol { get; }

    new (IProtocolDeclaration Type, bool IsFallback) GraphemeClusterLiteralTypeProtocol { get; }

    void SetDefaultIntegerLiteralType(IType type);

    void SetDefaultFloatingPointLiteralType(IType type);

    void SetDefaultStringLiteralType(IType type);

    void SetDefaultRegularExpressionLiteralType(IType type);

    void SetDefaultBooleanLiteralType(IType type);

    void SetDefaultNilLiteralType(IType type);

    void SetDefaultUnicodeEscapeLiteralType(IType type);
     
    void SetDefaultGraphemeClusterLiteralType(IType type);

    void ResetDefaultIntegerLiteralType();

    void ResetDefaultFloatingPointLiteralType();

    void ResetDefaultStringLiteralType();

    void ResetDefaultRegularExpressionLiteralType();

    void ResetDefaultBooleanLiteralType();

    void ResetDefaultNilLiteralType();

    void ResetDefaultUnicodeEscapeLiteralType();

    void ResetDefaultGraphemeClusterLiteralType();
}
