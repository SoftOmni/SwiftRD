using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Semantics.Type.BuiltinTypes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.StringLiterals.Formatting;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.StringLiterals;

public interface IReadOnlyStringLiteral : IReadOnlyLiteral<String, string>
{
    int Length { get; }
    
    int LeadingHashtags { get; }

    IStringFormatting Formatting { get; }

    char GetRawCharAt(int index);

    char GetCharAt(int index);

    IEnumerator<char> GetRawEnumerator();
    
    IEnumerator<char> GetValueEnumerator();

    IReadOnlyList<int> GetEscapeLocations();

    bool SupportsEscapes { get; }
    
    IReadOnlyList<int> GetInterpolationLocations();

    bool SupportsInterpolations { get; }
}