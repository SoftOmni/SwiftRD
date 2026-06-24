using JetBrains.Rd;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Protocols;
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
    
    public (IProtocol Type, bool IsFallback) IntegerPointLiteralTypeProtocol { get; }
    
    public (IProtocol Type, bool IsFallback) FloatingPointLiteralTypeProtocol { get; }
    
    public (IProtocol Type, bool IsFallback) StringLiteralTypeProtocol { get; }
    
    public (IProtocol Type, bool IsFallback) RegularExpressionLiteralTypeProtocol { get; }

    public (IProtocol Type, bool IsFallback) BooleanLiteralTypeProtocol { get; }
    
    public (IProtocol Type, bool IsFallback) NilLiteralTypeProtocol { get; }
    
    public (IProtocol Type, bool IsFallback) UnicodeScalarLiteralTypeProtocol { get; }
    
    public (IProtocol Type, bool IsFallback) GraphemeClusterLiteralTypeProtocol { get; }

    
    
    public PrimitiveLiteralTypeResolutionContext()
    {
        IntegerPointLiteralTypeProtocol = (GenerateDefaultIntegerLiteralTypeProtocol(), true);
        FloatingPointLiteralTypeProtocol = (GenerateDefaultFloatingPointLiteralTypeProtocol(), true);
        StringLiteralTypeProtocol = (GenerateDefaultStringLiteralTypeProtocol(), true);
        RegularExpressionLiteralTypeProtocol = (GenerateDefaultRegularExpressionLiteralTypeProtocol(), true);
        BooleanLiteralTypeProtocol = (GenerateDefaultBooleanLiteralTypeProtocol(), true);
        NilLiteralTypeProtocol = (GenerateDefaultNilLiteralTypeProtocol(), true);
        UnicodeScalarLiteralTypeProtocol = (GenerateDefaultUnicodeScalarLiteralTypeProtocol(), true);
        GraphemeClusterLiteralTypeProtocol = (GenerateDefaultGraphemeClusterLiteralTypeProtocol(), true);
        
        
    }
    
    public void SetDefaultIntegerLiteralType(IReadOnlyType type)
    {
        throw new System.NotImplementedException();
    }

    public void SetDefaultFloatingPointLiteralType(IReadOnlyType type)
    {
        throw new System.NotImplementedException();
    }

    public void SetDefaultStringLiteralType(IReadOnlyType type)
    {
        throw new System.NotImplementedException();
    }

    public void SetDefaultRegularExpressionLiteralType(IReadOnlyType type)
    {
        throw new System.NotImplementedException();
    }

    public void SetDefaultBooleanLiteralType(IReadOnlyType type)
    {
        throw new System.NotImplementedException();
    }

    public void SetDefaultNilLiteralType(IReadOnlyType type)
    {
        throw new System.NotImplementedException();
    }

    public void SetDefaultUnicodeEscapeLiteralType(IReadOnlyType type)
    {
        throw new System.NotImplementedException();
    }

    public void SetDefaultGraphemeClusterLiteralType(IReadOnlyType type)
    {
        throw new System.NotImplementedException();
    }

    public void ResetDefaultIntegerLiteralType()
    {
        throw new System.NotImplementedException();
    }

    public void ResetDefaultFloatingPointLiteralType()
    {
        throw new System.NotImplementedException();
    }

    public void ResetDefaultStringLiteralType()
    {
        throw new System.NotImplementedException();
    }

    public void ResetDefaultRegularExpressionLiteralType()
    {
        throw new System.NotImplementedException();
    }

    public void ResetDefaultBooleanLiteralType()
    {
        throw new System.NotImplementedException();
    }

    public void ResetDefaultNilLiteralType()
    {
        throw new System.NotImplementedException();
    }

    public void ResetDefaultUnicodeEscapeLiteralType()
    {
        throw new System.NotImplementedException();
    }

    public void ResetDefaultGraphemeClusterLiteralType()
    {
        throw new System.NotImplementedException();
    }
    
    public IReadOnlyProtocol GenerateDefaultIntegerLiteralTypeProtocol(IReadOnlySwiftVersion swiftVersion)
    {
        throw new System.NotImplementedException();
    }

    public IReadOnlyProtocol GenerateDefaultFloatingPointLiteralTypeProtocol(IReadOnlySwiftVersion swiftVersion)
    {
        throw new System.NotImplementedException();
    }

    public IReadOnlyProtocol GenerateDefaultStringLiteralTypeProtocol(IReadOnlySwiftVersion swiftVersion)
    {
        throw new System.NotImplementedException();
    }

    public IReadOnlyProtocol GenerateDefaultRegularExpressionLiteralTypeProtocol(IReadOnlySwiftVersion swiftVersion)
    {
        throw new System.NotImplementedException();
    }

    public IReadOnlyProtocol GenerateDefaultBooleanLiteralTypeProtocol(IReadOnlySwiftVersion swiftVersion)
    {
        throw new System.NotImplementedException();
    }

    public IReadOnlyProtocol GenerateDefaultNilLiteralTypeProtocol(IReadOnlySwiftVersion swiftVersion)
    {
        throw new System.NotImplementedException();
    }

    public IReadOnlyProtocol GenerateDefaultUnicodeScalarLiteralTypeProtocol(IReadOnlySwiftVersion swiftVersion)
    {
        throw new System.NotImplementedException();
    }

    public IReadOnlyProtocol GenerateDefaultGraphemeClusterLiteralTypeProtocol(IReadOnlySwiftVersion swiftVersion)
    {
        throw new System.NotImplementedException();
    }

    public bool ConformsToDefaultIntegerLiteralTypeProtocol(IReadOnlyProtocol integerLiteralProtocol)
    {
        throw new System.NotImplementedException();
    }

    public bool ConformsToDefaultFloatingPointLiteralTypeProtocol(IReadOnlyProtocol floatingPointLiteralProtocol)
    {
        throw new System.NotImplementedException();
    }

    public bool ConformsToDefaultStringLiteralTypeProtocol(IReadOnlyProtocol stringLiteralProtocol)
    {
        throw new System.NotImplementedException();
    }

    public bool ConformsToDefaultRegularExpressionLiteralTypeProtocol(IReadOnlyProtocol regularExpressionLiteralProtocol)
    {
        throw new System.NotImplementedException();
    }

    public bool ConformsToDefaultBooleanLiteralTypeProtocol(IReadOnlyProtocol booleanLiteralProtocol)
    {
        throw new System.NotImplementedException();
    }

    public bool ConformsToDefaultNilLiteralTypeProtocol(IReadOnlyProtocol nilLiteralProtocol)
    {
        throw new System.NotImplementedException();
    }

    public bool ConformsToDefaultUnicodeScalarLiteralTypeProtocol(IReadOnlyProtocol unicodeScalarLiteralProtocol)
    {
        throw new System.NotImplementedException();
    }

    public bool ConformsToDefaultGraphemeClusterLiteralTypeProtocol(IReadOnlyProtocol graphemeClusterLiteralProtocol)
    {
        throw new System.NotImplementedException();
    }
}