using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.StringLiterals.Formatting;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.StringLiterals;

public interface IStringLiteral : IReadOnlyStringLiteral, ILiteral<string>
{
    void SetRawCharAt(int index, char newCharacter);
    
    void SetCharAt(int index, char newCharacter);

    void ChangeFormatting(IStringFormatting formatting);

    void IncrementSurroundingHashtags();

    void DecrementSurroundingHashtags();

    void SetSurroundingHashtagsTo(int value);
}
