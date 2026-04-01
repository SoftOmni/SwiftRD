namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer;

public class SwiftLexerSettings
{
    public static ThreeQuotesSetting ThreeQuotesSettings { get; }
    
    public static FourQuotesSetting FourQuotesSettings { get; }

    public static FiveQuotesSetting FiveQuotesSettings { get; }
    
    public static UnicodeSequenceInterruption UnicodeSequenceInterruptionSettings { get; }
    
    public enum ThreeQuotesSetting
    {
        SimpleStringAndStartOfOtherSimpleStringImmediateIfNoPair,
        SimpleStringAndStartOfOtherSimpleStringLineIfNoPair,
        MultilineStringLiteralStartToEndImmediateIfNoPair,
        MultilineStringLiteralStartToEndLineIfNoPair,
        MultilineStringLiteralStart
    }

    public enum FourQuotesSetting
    {
        MultilineStringLiteralStartAndStartOfOtherSimpleStringImmediateIfNoPair,
        MultilineStringLiteralStartToLineIfNoPair,
        MultilineStringLiteralStartToEndIfNoPair,
        DoubleSimpleStringLiteral
    }

    public enum FiveQuotesSetting
    {
        MultilineStringLiteralStartAndSimpleStringImmediateIfNoPair,
        MultilineStringLiteralStartLineIfNoPair,
        MultilineStringLiteralStartToEndIfNoPair,
        SimpleStringMultilineStringLiteralStartImmediateIfNoPair,
        SimpleStringMultilineStringLiteralStartLineIfNoPair,
        SimpleStringMultilineStringLiteralStartToEndIfNoPair,
        DoubleSimpleStringLiteralAndStringLiteralStart
    }

    public enum UnicodeSequenceInterruption
    {
        Abort,
        Continue
    }
}

public static class SwiftLexerSettingsExtensions
{
    public static bool IsMultiLineStart(this SwiftLexerSettings.ThreeQuotesSetting threeQuotesSetting)
    {
        return threeQuotesSetting is SwiftLexerSettings.ThreeQuotesSetting.MultilineStringLiteralStart
            or SwiftLexerSettings.ThreeQuotesSetting.MultilineStringLiteralStartToEndImmediateIfNoPair
            or SwiftLexerSettings.ThreeQuotesSetting.MultilineStringLiteralStartToEndLineIfNoPair;
    }
    
    public static bool IsSimpleLiteralStart(this SwiftLexerSettings.FiveQuotesSetting fiveQuotesSetting)
    {
        return fiveQuotesSetting is SwiftLexerSettings.FiveQuotesSetting
                .SimpleStringMultilineStringLiteralStartImmediateIfNoPair
            or SwiftLexerSettings.FiveQuotesSetting.SimpleStringMultilineStringLiteralStartLineIfNoPair
            or SwiftLexerSettings.FiveQuotesSetting.SimpleStringMultilineStringLiteralStartToEndIfNoPair
            or SwiftLexerSettings.FiveQuotesSetting.DoubleSimpleStringLiteralAndStringLiteralStart;
    }

    public static bool IsMultiLineStart(this SwiftLexerSettings.FiveQuotesSetting fiveQuotesSetting)
    {
        return fiveQuotesSetting is SwiftLexerSettings.FiveQuotesSetting
                .MultilineStringLiteralStartAndSimpleStringImmediateIfNoPair
            or SwiftLexerSettings.FiveQuotesSetting.MultilineStringLiteralStartLineIfNoPair
            or SwiftLexerSettings.FiveQuotesSetting.MultilineStringLiteralStartToEndIfNoPair;
    }
}