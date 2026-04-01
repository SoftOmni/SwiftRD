using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TupleTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

public interface IType : IRenamableUsage, ITupleTypeElement
{
    public IType? DeclaredType { get; }

    public IType? ActualType { get; }

    public string TypeSignature { get; }

    public IType? SuperType { get; }

    public IReadOnlyList<IReadOnlyList<IType>> SubTypeChains { get; }

    public IReadOnlySet<IType> SubTypes { get; }

    public IReadOnlySet<string> SubTypeNames { get; }

    public bool IsFromStandardLibrary { get; }
}

internal static class TypeExtensions
{
    internal static bool CanBeReasonablyInterpretedAsType(SwiftLexer lexer)
    {
        
    }
}