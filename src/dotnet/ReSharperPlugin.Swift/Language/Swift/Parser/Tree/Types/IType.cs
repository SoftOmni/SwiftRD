using System;
using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TupleTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

public interface IType : IReadOnlyType, IRenamableUsage, ITupleTypeElement
{
    IType? DeclaredType { get; }

    IType? ActualType { get; }

    string TypeSignature { get; }

    IType? SuperType { get; }

    IReadOnlyList<IReadOnlyList<IType>> SubTypeChains { get; }

    IReadOnlySet<IType> SubTypes { get; }

    IReadOnlySet<string> SubTypeNames { get; }

    bool IsFromStandardLibrary { get; }
}

internal static class TypeExtensions
{
    internal static bool CanBeReasonablyInterpretedAsType(SwiftLexer lexer)
    {
        throw new NotImplementedException();
    }
}