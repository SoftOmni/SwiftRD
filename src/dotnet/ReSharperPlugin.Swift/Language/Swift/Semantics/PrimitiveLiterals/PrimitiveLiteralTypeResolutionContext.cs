using System;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Protocols;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.CompilationConditions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.CompilationConditions.PlatformConditions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Semantics.PrimitiveLiterals;

public class PrimitiveLiteralTypeResolutionContext : IPrimitiveLiteralTypeResolutionContext
{

    public (IType Type, bool IsFallback) DefaultIntegerLiteralType { get; }
    
    public (IType Type, bool IsFallback) DefaultFloatingPointLiteralType { get; }
    
    public (IType Type, bool IsFallback) DefaultStringLiteralType { get; }
    
    public (IType Type, bool IsFallback) DefaultRegularExpressionLiteralType { get; }
    
    public (IType Type, bool IsFallback) DefaultBooleanLiteralType { get; }
    
    public (IType Type, bool IsFallback) DefaultNilLiteralType { get; }
    
    public (IType Type, bool IsFallback) DefaultUnicodeScalarLiteralType { get; }
    
    public (IType Type, bool IsFallback) DefaultGraphemeClusterLiteralType { get; }
    
    public (IProtocolDeclaration Type, bool IsFallback) IntegerPointLiteralTypeProtocol { get; }
    
    public (IProtocolDeclaration Type, bool IsFallback) FloatingPointLiteralTypeProtocol { get; }
    
    public (IProtocolDeclaration Type, bool IsFallback) StringLiteralTypeProtocol { get; }
    
    public (IProtocolDeclaration Type, bool IsFallback) RegularExpressionLiteralTypeProtocol { get; }

    public (IProtocolDeclaration Type, bool IsFallback) BooleanLiteralTypeProtocol { get; }
    
    public (IProtocolDeclaration Type, bool IsFallback) NilLiteralTypeProtocol { get; }
    
    public (IProtocolDeclaration Type, bool IsFallback) UnicodeScalarLiteralTypeProtocol { get; }
    
    public (IProtocolDeclaration Type, bool IsFallback) GraphemeClusterLiteralTypeProtocol { get; }

    
    
    public PrimitiveLiteralTypeResolutionContext()
    {
        SwiftVersion placeholderVersion = SwiftVersion.FromVersion(new Version(1, 0));
        IntegerPointLiteralTypeProtocol = (GenerateDefaultIntegerLiteralTypeProtocol(placeholderVersion), true);
        FloatingPointLiteralTypeProtocol = (GenerateDefaultFloatingPointLiteralTypeProtocol(placeholderVersion), true);
        StringLiteralTypeProtocol = (GenerateDefaultStringLiteralTypeProtocol(placeholderVersion), true);
        RegularExpressionLiteralTypeProtocol = (GenerateDefaultRegularExpressionLiteralTypeProtocol(placeholderVersion), true);
        BooleanLiteralTypeProtocol = (GenerateDefaultBooleanLiteralTypeProtocol(placeholderVersion), true);
        NilLiteralTypeProtocol = (GenerateDefaultNilLiteralTypeProtocol(placeholderVersion), true);
        UnicodeScalarLiteralTypeProtocol = (GenerateDefaultUnicodeScalarLiteralTypeProtocol(placeholderVersion), true);
        GraphemeClusterLiteralTypeProtocol = (GenerateDefaultGraphemeClusterLiteralTypeProtocol(placeholderVersion), true);
    }
    
    public void SetDefaultIntegerLiteralType(IReadOnlyType type)
    {
        throw new NotImplementedException();
    }

    public void SetDefaultFloatingPointLiteralType(IReadOnlyType type)
    {
        throw new NotImplementedException();
    }

    public void SetDefaultStringLiteralType(IReadOnlyType type)
    {
        throw new NotImplementedException();
    }

    public void SetDefaultRegularExpressionLiteralType(IReadOnlyType type)
    {
        throw new NotImplementedException();
    }

    public void SetDefaultBooleanLiteralType(IReadOnlyType type)
    {
        throw new NotImplementedException();
    }

    public void SetDefaultNilLiteralType(IReadOnlyType type)
    {
        throw new NotImplementedException();
    }

    public void SetDefaultUnicodeEscapeLiteralType(IReadOnlyType type)
    {
        throw new NotImplementedException();
    }

    public void SetDefaultGraphemeClusterLiteralType(IReadOnlyType type)
    {
        throw new NotImplementedException();
    }

    public void ResetDefaultIntegerLiteralType()
    {
        throw new NotImplementedException();
    }

    public void ResetDefaultFloatingPointLiteralType()
    {
        throw new NotImplementedException();
    }

    public void ResetDefaultStringLiteralType()
    {
        throw new NotImplementedException();
    }

    public void ResetDefaultRegularExpressionLiteralType()
    {
        throw new NotImplementedException();
    }

    public void ResetDefaultBooleanLiteralType()
    {
        throw new NotImplementedException();
    }

    public void ResetDefaultNilLiteralType()
    {
        throw new NotImplementedException();
    }

    public void ResetDefaultUnicodeEscapeLiteralType()
    {
        throw new NotImplementedException();
    }

    public void ResetDefaultGraphemeClusterLiteralType()
    {
        throw new NotImplementedException();
    }
    
    public IProtocolDeclaration GenerateDefaultIntegerLiteralTypeProtocol(IReadOnlySwiftVersion swiftVersion)
    {
        throw new NotImplementedException();
    }

    public IProtocolDeclaration GenerateDefaultFloatingPointLiteralTypeProtocol(IReadOnlySwiftVersion swiftVersion)
    {
        throw new NotImplementedException();
    }

    public IProtocolDeclaration GenerateDefaultStringLiteralTypeProtocol(IReadOnlySwiftVersion swiftVersion)
    {
        throw new NotImplementedException();
    }

    public IProtocolDeclaration GenerateDefaultRegularExpressionLiteralTypeProtocol(IReadOnlySwiftVersion swiftVersion)
    {
        throw new NotImplementedException();
    }

    public IProtocolDeclaration GenerateDefaultBooleanLiteralTypeProtocol(IReadOnlySwiftVersion swiftVersion)
    {
        throw new NotImplementedException();
    }

    public IProtocolDeclaration GenerateDefaultNilLiteralTypeProtocol(IReadOnlySwiftVersion swiftVersion)
    {
        throw new NotImplementedException();
    }

    public IProtocolDeclaration GenerateDefaultUnicodeScalarLiteralTypeProtocol(IReadOnlySwiftVersion swiftVersion)
    {
        throw new NotImplementedException();
    }

    public IProtocolDeclaration GenerateDefaultGraphemeClusterLiteralTypeProtocol(IReadOnlySwiftVersion swiftVersion)
    {
        throw new NotImplementedException();
    }

    public bool ConformsToDefaultIntegerLiteralTypeProtocol(IReadOnlyProtocolDeclaration integerLiteralProtocol)
    {
        throw new NotImplementedException();
    }

    public bool ConformsToDefaultFloatingPointLiteralTypeProtocol(IReadOnlyProtocolDeclaration floatingPointLiteralProtocol)
    {
        throw new NotImplementedException();
    }

    public bool ConformsToDefaultStringLiteralTypeProtocol(IReadOnlyProtocolDeclaration stringLiteralProtocol)
    {
        throw new NotImplementedException();
    }

    public bool ConformsToDefaultRegularExpressionLiteralTypeProtocol(IReadOnlyProtocolDeclaration regularExpressionLiteralProtocol)
    {
        throw new NotImplementedException();
    }

    public bool ConformsToDefaultBooleanLiteralTypeProtocol(IReadOnlyProtocolDeclaration booleanLiteralProtocol)
    {
        throw new NotImplementedException();
    }

    public bool ConformsToDefaultNilLiteralTypeProtocol(IReadOnlyProtocolDeclaration nilLiteralProtocol)
    {
        throw new NotImplementedException();
    }

    public bool ConformsToDefaultUnicodeScalarLiteralTypeProtocol(IReadOnlyProtocolDeclaration unicodeScalarLiteralProtocol)
    {
        throw new NotImplementedException();
    }

    public bool ConformsToDefaultGraphemeClusterLiteralTypeProtocol(IReadOnlyProtocolDeclaration graphemeClusterLiteralProtocol)
    {
        throw new NotImplementedException();
    }

    (IReadOnlyType type, bool isFallback) IReadOnlyPrimitiveLiteralTypeResolutionContext.DefaultIntegerLiteralType => DefaultIntegerLiteralType;

    (IReadOnlyType type, bool isFallback) IReadOnlyPrimitiveLiteralTypeResolutionContext.DefaultFloatingPointLiteralType => DefaultFloatingPointLiteralType;

    (IReadOnlyType type, bool isFallback) IReadOnlyPrimitiveLiteralTypeResolutionContext.DefaultStringLiteralType => DefaultStringLiteralType;

    (IReadOnlyType type, bool isFallback) IReadOnlyPrimitiveLiteralTypeResolutionContext.DefaultRegularExpressionLiteralType => DefaultRegularExpressionLiteralType;

    (IReadOnlyType type, bool isFallback) IReadOnlyPrimitiveLiteralTypeResolutionContext.DefaultBooleanLiteralType => DefaultBooleanLiteralType;

    (IReadOnlyType type, bool isFallback) IReadOnlyPrimitiveLiteralTypeResolutionContext.DefaultNilLiteralType => DefaultNilLiteralType;

    (IReadOnlyType type, bool isFallback) IReadOnlyPrimitiveLiteralTypeResolutionContext.DefaultUnicodeScalarLiteralType => DefaultUnicodeScalarLiteralType;

    (IReadOnlyType type, bool isFallback) IReadOnlyPrimitiveLiteralTypeResolutionContext.DefaultGraphemeClusterLiteralType => DefaultGraphemeClusterLiteralType;

    (IReadOnlyProtocolDeclaration type, bool isFallback) IReadOnlyPrimitiveLiteralTypeResolutionContext.IntegerPointLiteralTypeProtocol => IntegerPointLiteralTypeProtocol;

    (IReadOnlyProtocolDeclaration type, bool isFallback) IReadOnlyPrimitiveLiteralTypeResolutionContext.FloatingPointLiteralTypeProtocol => FloatingPointLiteralTypeProtocol;

    (IReadOnlyProtocolDeclaration type, bool isFallback) IReadOnlyPrimitiveLiteralTypeResolutionContext.StringLiteralTypeProtocol => StringLiteralTypeProtocol;

    (IReadOnlyProtocolDeclaration type, bool isFallback) IReadOnlyPrimitiveLiteralTypeResolutionContext.RegularExpressionLiteralTypeProtocol => RegularExpressionLiteralTypeProtocol;

    (IReadOnlyProtocolDeclaration type, bool isFallback) IReadOnlyPrimitiveLiteralTypeResolutionContext.BooleanLiteralTypeProtocol => BooleanLiteralTypeProtocol;

    (IReadOnlyProtocolDeclaration type, bool isFallback) IReadOnlyPrimitiveLiteralTypeResolutionContext.NilLiteralTypeProtocol => NilLiteralTypeProtocol;

    (IReadOnlyProtocolDeclaration type, bool isFallback) IReadOnlyPrimitiveLiteralTypeResolutionContext.UnicodeScalarLiteralTypeProtocol => UnicodeScalarLiteralTypeProtocol;

    (IReadOnlyProtocolDeclaration type, bool isFallback) IReadOnlyPrimitiveLiteralTypeResolutionContext.GraphemeClusterLiteralTypeProtocol => GraphemeClusterLiteralTypeProtocol;

    public void SetDefaultIntegerLiteralType(IType type)
    {
        throw new NotImplementedException();
    }

    public void SetDefaultFloatingPointLiteralType(IType type)
    {
        throw new NotImplementedException();
    }

    public void SetDefaultStringLiteralType(IType type)
    {
        throw new NotImplementedException();
    }

    public void SetDefaultRegularExpressionLiteralType(IType type)
    {
        throw new NotImplementedException();
    }

    public void SetDefaultBooleanLiteralType(IType type)
    {
        throw new NotImplementedException();
    }

    public void SetDefaultNilLiteralType(IType type)
    {
        throw new NotImplementedException();
    }

    public void SetDefaultUnicodeEscapeLiteralType(IType type)
    {
        throw new NotImplementedException();
    }

    public void SetDefaultGraphemeClusterLiteralType(IType type)
    {
        throw new NotImplementedException();
    }
}
