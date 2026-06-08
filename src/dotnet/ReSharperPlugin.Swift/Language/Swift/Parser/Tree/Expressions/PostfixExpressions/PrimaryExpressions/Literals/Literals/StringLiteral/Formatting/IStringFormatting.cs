namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.StringLiterals.Formatting;

public interface IStringFormatting
{
    enum Casing
    {
        Uppercase,
        Lowercase
    }

    enum CharacterInsertion
    {
        Raw,
        UnicodeEscape
    }

    enum SimpleEscapeSupportedCharacterInsertion
    {
        SimpleEscape,
        UnicodeEscape
    }
    
    Casing UnicodeEscapeHexadecimalCharacterCasing { get; }
    
    CharacterInsertion PreferredInsertionWay { get; }
    
    SimpleEscapeSupportedCharacterInsertion PreferredInsertionSimpleEscapeSupportedCharacters { get; } 
}