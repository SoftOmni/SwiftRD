using System;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

public interface IType : IReadOnlyType;

internal static class TypeExtensions
{
    internal static bool CanBeReasonablyInterpretedAsType(SwiftLexer lexer)
    {
        throw new NotImplementedException();
    }
}
