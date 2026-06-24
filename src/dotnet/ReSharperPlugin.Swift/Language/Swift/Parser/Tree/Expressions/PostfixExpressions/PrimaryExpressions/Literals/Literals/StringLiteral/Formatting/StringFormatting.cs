namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.
    Literals.StringLiterals.Formatting;

public readonly struct StringFormatting(
    IStringFormatting.Casing unicodeEscapeHexadecimalCharacterCasing,
    IStringFormatting.CharacterInsertion preferredInsertionWay,
    IStringFormatting.SimpleEscapeSupportedCharacterInsertion preferredInsertionSimpleEscapeSupportedCharacters)
    : IStringFormatting
{
    public IStringFormatting.Casing UnicodeEscapeHexadecimalCharacterCasing { get; } =
        unicodeEscapeHexadecimalCharacterCasing;

    public IStringFormatting.CharacterInsertion PreferredInsertionWay { get; } = preferredInsertionWay;

    public IStringFormatting.SimpleEscapeSupportedCharacterInsertion PreferredInsertionSimpleEscapeSupportedCharacters
    {
        get;
    } = preferredInsertionSimpleEscapeSupportedCharacters;

    public const IStringFormatting.Casing AbsoluteDefaultUnicodeEscapeHexadecimalCharacterCasing =
        IStringFormatting.Casing.Uppercase;

    public const IStringFormatting.CharacterInsertion AbsoluteDefaultPreferredInsertionWay =
        IStringFormatting.CharacterInsertion.UnicodeEscape;

    public const IStringFormatting.SimpleEscapeSupportedCharacterInsertion
        AbsoluteDefaultPreferredSimpleEscapeSupportedCharacters
            = IStringFormatting.SimpleEscapeSupportedCharacterInsertion.SimpleEscape;

    public static IStringFormatting.Casing CurrentlyStoredDefaultUnicodeEscapeHexadecimalCharacterCasing =
        AbsoluteDefaultUnicodeEscapeHexadecimalCharacterCasing;

    public static IStringFormatting.CharacterInsertion CurrentlyStoredDefaultPreferredInsertionWay =
        AbsoluteDefaultPreferredInsertionWay;

    public static IStringFormatting.SimpleEscapeSupportedCharacterInsertion
        CurrentlyStoredDefaultPreferredSimpleEscapeSupportedCharacters
            = AbsoluteDefaultPreferredSimpleEscapeSupportedCharacters;

    public static StringFormatting Default()
    {
        return new StringFormatting(CurrentlyStoredDefaultUnicodeEscapeHexadecimalCharacterCasing,
            CurrentlyStoredDefaultPreferredInsertionWay, CurrentlyStoredDefaultPreferredSimpleEscapeSupportedCharacters);
    }
}