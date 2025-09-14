using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.ContextSensitive;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Declarations;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.ExpressionsAndTypes;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Markers;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Patterns;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Reserved;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Statements;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens;

public static class SwiftTokens
{
    #region Markers

    public static readonly StartOfFileToken StartOfFileToken = new();
    public const int StartOfFileIndex = 101;

    public static readonly EndOfFileToken EndOfFileToken = new();
    public const int EndOfFileIndex = 102;
    
    public static readonly EmptyToken EmptyToken = new();
    public const int EmptyTokenIndex = 103;

    #endregion
    
    #region WhitespaceAndComments
    
    public const int WhitespaceIndex = 201;
    
    public const int NewlineIndex = 202;
    
    public const int LineCommentIndex = 203;
    
    public const int BlockCommentStartIndex = 204;
    
    public const int BlockCommentEndIndex = 205;
    
    public const int BlockCommentContentIndex = 206;

    #endregion
    
    #region Identifiers
    
    public const int IdentifierIndex = 701;
    
    #endregion
    
    #region Literals

    public const int IntegerLiteralIndex = 801;
    
    public const int FloatingPointLiteralIndex = 802;
    
    public const int StringInterpolationIndex = 803;

    public const int StringEscapeSequenceIndex = 804;

    public const int StringLiteralStartIndex = 805;
    
    public const int StringLiteralEndIndex = 806;
    
    public const int StringLiteralContentIndex = 807;
    
    public const int SurroundedStringLiteralStartIndex = 808;

    public const int SurroundedStringLiteralEndIndex = 809;
    
    public const int SurroundedStringLiteralContentIndex = 810;
    
    public const int MultiLineStringLiteralStartIndex = 811;

    public const int MultiLineStringLiteralIndexEnd = 812;
    
    public const int MultiLineStringLiteralContentIndex = 813;
    
    public const int MultiLineSurroundedStringLiteralStartIndex = 814;

    public const int MultiLineSurroundedStringLiteralIndexEnd = 815;
    
    public const int MultiLineSurroundedStringLiteralContentIndex = 816;

    public const int RegularExpressionLiteralIndex = 817;

    #endregion
    
    #region Punctuators

    public const int LeftParenthesisIndex = 901;
    
    public const int RightParenthesisIndex = 902;
    
    public const int LeftCurlyBracedIndex = 903;
    
    public const int RightCurlyBracedIndex = 904;
    
    public const int LeftSquareBracketIndex = 905;
    
    public const int RightSquareBracketIndex = 906;
    
    public const int PeriodIndex = 907;
    
    public const int CommaIndex = 908;
    
    public const int ColonIndex = 909;
    
    public const int SemicolonIndex = 910;
    
    public const int EqualsIndex = 911;
    
    public const int AtIndex = 912;
    
    public const int HashIndex = 913;
    
    public const int AmpersandIndex = 914;
    
    public const int ArrowIndex = 915;
    
    public const int BacktickIndex = 916;
    
    public const int QuestionMarkIndex = 917;
    
    public const int ExclamationMarkIndex = 918;
    
    #endregion
    
    #region Keywords

    #region UsableInDeclarations
    
    public static readonly AssociatedTypeKeywordToken AssociatedTypeKeywordToken = new();
    public const int AssociatedTypeIndex = 1001;

    public static readonly BorrowingKeywordToken BorrowingKeywordToken = new();
    public const int BorrowingIndex = 1002;

    public static readonly ClassKeywordToken ClassKeywordToken = new();
    public const int ClassIndex = 1003;

    public static readonly ConsumingKeywordToken ConsumingKeywordToken = new();
    public const int ConsumingIndex = 1004;

    public static readonly DeinitKeywordToken DeinitKeywordToken = new();
    public const int DeinitIndex = 1005;

    public static readonly EnumKeywordToken EnumKeywordToken = new();
    public const int EnumIndex = 1006;

    public static readonly ExtensionKeywordToken ExtensionKeywordToken = new();
    public const int ExtensionIndex = 1007;

    public static readonly FilePrivateKeywordToken FilePrivateKeywordToken = new();
    public const int FilePrivateIndex = 1008;

    public static readonly FuncKeywordToken FuncKeywordToken = new();
    public const int FuncIndex = 1009;

    public static readonly ImportKeywordToken ImportKeywordToken = new();
    public const int ImportIndex = 1010;

    public static readonly InitKeywordToken InitKeywordToken = new();
    public const int InitIndex = 1011;

    public static readonly InoutKeywordToken InoutKeywordToken = new();
    public const int InoutIndex = 1012;

    public static readonly InternalKeywordToken InternalKeywordToken = new();
    public const int InternalIndex = 1013;

    public static readonly LetKeywordToken LetKeywordToken = new();
    public const int LetIndex = 1014;

    public static readonly NonIsolatedKeywordToken NonIsolatedKeywordToken = new();
    public const int NonIsolatedIndex = 1015;

    public static readonly OpenKeywordToken OpenKeywordToken = new();
    public const int OpenIndex = 1016;

    public static readonly OperatorKeywordToken OperatorKeywordToken = new();
    public const int OperatorIndex = 1017;

    public static readonly PrecedenceGroupKeywordToken PrecedenceGroupKeywordToken = new();
    public const int PrecedenceGroupIndex = 1018;

    public static readonly PrivateKeywordToken PrivateKeywordToken = new();
    public const int PrivateIndex = 1019;

    public static readonly ProtocolLowercaseKeywordToken ProtocolLowercaseKeywordToken = new();
    public const int ProtocolLowercaseIndex = 1020;

    public static readonly PublicKeywordToken PublicKeywordToken = new();
    public const int PublicIndex = 1021;

    public static readonly RethrowsKeywordToken RethrowsKeywordToken = new();
    public const int RethrowsIndex = 1022;

    public static readonly StaticKeywordToken StaticKeywordToken = new();
    public const int StaticIndex = 1023;

    public static readonly StructKeywordToken StructKeywordToken = new();
    public const int StructIndex = 1024;

    public static readonly SubscriptKeywordToken SubscriptKeywordToken = new();
    public const int SubscriptIndex = 1025;

    public static readonly TypealiasKeywordToken TypealiasKeywordToken = new();
    public const int TypealiasIndex = 1026;

    public static readonly VarKeywordToken VarKeywordToken = new();
    public const int VarIndex = 1027;

    #endregion

    #region UsableInStatements


    public static readonly BreakKeywordToken BreakKeywordToken = new();
    public const int BreakIndex = 2001;

    public static readonly CaseKeywordToken CaseKeywordToken = new();
    public const int CaseIndex = 2002;

    public static readonly CatchKeywordToken CatchKeywordToken = new();
    public const int CatchIndex = 2003;

    public static readonly ContinueKeywordToken ContinueKeywordToken = new();
    public const int ContinueIndex = 2004;

    public static readonly DefaultKeywordToken DefaultKeywordToken = new();
    public const int DefaultIndex = 2005;

    public static readonly DeferKeywordToken DeferKeywordToken = new();
    public const int DeferIndex = 2006;

    public static readonly DoKeywordToken DoKeywordToken = new();
    public const int DoIndex = 2007;

    public static readonly ElseKeywordToken ElseKeywordToken = new();
    public const int ElseIndex = 2008;

    public static readonly FallthroughKeywordToken FallthroughKeywordToken = new();
    public const int FallthroughIndex = 2009;

    public static readonly ForKeywordToken ForKeywordToken = new();
    public const int ForIndex = 2010;

    public static readonly GuardKeywordToken GuardKeywordToken = new();
    public const int GuardIndex = 2011;

    public static readonly IfKeywordToken IfKeywordToken = new();
    public const int IfIndex = 2012;

    public static readonly InKeywordToken InKeywordToken = new();
    public const int InIndex = 2013;

    public static readonly RepeatKeywordToken RepeatKeywordToken = new();
    public const int RepeatIndex = 2014;

    public static readonly ReturnKeywordToken ReturnKeywordToken = new();
    public const int ReturnIndex = 2015;

    public static readonly SwitchKeywordToken SwitchKeywordToken = new();
    public const int SwitchIndex = 2016;

    public static readonly ThrowKeywordToken ThrowKeywordToken = new();
    public const int ThrowIndex = 2017;

    public static readonly WhereKeywordToken WhereKeywordToken = new();
    public const int WhereIndex = 2018;

    public static readonly WhileKeywordToken WhileKeywordToken = new();
    public const int WhileIndex = 2019;

    #endregion

    #region UsableInExpressionsAndTypes

    public static readonly AnyKeywordToken AnyKeywordToken = new();
    public const int AnyIndex = 3001;

    public static readonly AsKeywordToken AsKeywordToken = new();
    public const int AsIndex = 3002;

    public static readonly AwaitKeywordToken AwaitKeywordToken = new();
    public const int AwaitIndex = 3003;

    public static readonly FalseLiteralToken FalseLiteralToken = new();
    public const int FalseIndex = 3004;

    public static readonly IsKeywordToken IsKeywordToken = new();
    public const int IsIndex = 3005;

    public static readonly NilLiteralToken NilLiteralToken = new();
    public const int NilIndex = 3006;

    public static readonly SelfLowercaseKeywordToken SelfLowercaseKeywordToken = new();
    public const int SelfLowercaseIndex = 3007;

    public static readonly SelfUppercaseKeywordToken SelfUppercaseKeywordToken = new();
    public const int SelfUppercaseIndex = 3008;

    public static readonly SuperKeywordToken SuperKeywordToken = new();
    public const int SuperIndex = 3009;

    public static readonly ThrowsKeywordToken ThrowsKeywordToken = new();
    public const int ThrowsIndex = 3010;

    public static readonly TrueLiteralToken TrueLiteralToken = new();
    public const int TrueIndex = 3011;

    public static readonly TryKeywordToken TryKeywordToken = new();
    public const int TryIndex = 3012;
    
    #endregion

    #region UsableInPatterns

    public static readonly UnderscoreTokenKeyword UnderscoreKeywordToken = new();
    public const int UnderscoreIndex = 4001;

    #endregion

    #region ReservedIdentifiers

    public static readonly ReservedAvailableKeywordToken ReservedAvailableKeywordToken = new();
    public const int ReservedAvailableIndex = 5001;

    public static readonly ReservedColorLiteralKeywordToken ReservedColorLiteralKeywordToken = new();
    public const int ReservedColorLiteralIndex = 5002;

    public static readonly ReservedElseKeywordToken ReservedElseKeywordToken = new();
    public const int ReservedElseIndex = 5003;

    public static readonly ReservedElseIfKeywordToken ReservedElseIfKeywordToken = new();
    public const int ReservedElseIfIndex = 5004;

    public static readonly ReservedEndIfKeywordToken ReservedEndIfKeywordToken = new();
    public const int ReservedEndIfIndex = 5005;

    public static readonly ReservedFileLiteralKeywordToken ReservedFileLiteralKeywordToken = new();
    public const int ReservedFileLiteralIndex = 5006;

    public static readonly ReservedIfKeywordToken ReservedIfKeywordToken = new();
    public const int ReservedIfIndex = 5007;

    public static readonly ReservedImageLiteralKeywordToken ReservedImageLiteralKeywordToken = new();
    public const int ReservedImageLiteralIndex = 5008;

    public static readonly ReservedKeyPathKeywordToken ReservedKeyPathKeywordToken = new();
    public const int ReservedKeyPathIndex = 5009;

    public static readonly ReservedSelectorKeywordToken ReservedSelectorKeywordToken = new();
    public const int ReservedSelectorIndex = 5010;

    public static readonly ReservedSourceLocationKeywordToken ReservedSourceLocationKeywordToken = new();
    public const int ReservedSourceLocationIndex = 5011;

    public static readonly ReservedUnavailableKeywordToken ReservedUnavailableKeywordToken = new();
    public const int ReservedUnavailableIndex = 5012;

    #endregion

    #region PreviouslyReservedIdentifiers

    public static readonly PreviouslyReservedColumnKeywordToken PreviouslyReservedColumnKeywordToken = new();
    public const int PreviouslyReservedColumnIndex = 6001;

    public static readonly PreviouslyReservedDsoHandleKeywordToken PreviouslyReservedDsoHandleKeywordToken = new();
    public const int PreviouslyReservedDsoHandleIndex = 6002;

    public static readonly PreviouslyReservedErrorKeywordToken PreviouslyReservedErrorKeywordToken = new();
    public const int PreviouslyReservedErrorIndex = 6003;

    public static readonly PreviouslyReservedFileIdKeywordToken PreviouslyReservedFileIdKeywordToken = new();
    public const int PreviouslyReservedFileIdIndex = 6004;
    
    public static readonly PreviouslyReservedFilePathKeywordToken PreviouslyReservedFilePathKeywordToken = new();
    public const int PreviouslyReservedFilePathIndex = 6005;

    public static readonly PreviouslyReservedFileKeywordToken PreviouslyReservedFileKeywordToken = new();
    public const int PreviouslyReservedFileIndex = 6006;

    public static readonly PreviouslyReservedFunctionKeywordToken PreviouslyReservedFunctionKeywordToken = new();
    public const int PreviouslyReservedFunctionIndex = 6007;

    public static readonly PreviouslyReservedLineKeywordToken PreviouslyReservedLineKeywordToken = new();
    public const int PreviouslyReservedLineIndex = 6008;

    public static readonly PreviouslyReservedWarningKeywordToken PreviouslyReservedWarningKeywordToken = new();
    public const int PreviouslyReservedWarningIndex = 6009;

    #endregion

    #region ContextSensitiveKeywords

    public static readonly AssociativityKeywordToken AssociativityKeywordToken = new();
    public const int AssociativityIndex = 7001;

    public static readonly AsyncKeywordToken AsyncKeywordToken = new();
    public const int AsyncIndex = 7002;

    public static readonly ConvenienceKeywordToken ConvenienceKeywordToken = new();
    public const int ConvenienceIndex = 7003;

    public static readonly DidSetKeywordToken DidSetKeywordToken = new();
    public const int DidSetIndex = 7004;

    public static readonly DynamicKeywordToken DynamicKeywordToken = new();
    public const int DynamicIndex = 7005;

    public static readonly FinalKeywordToken FinalKeywordToken = new();
    public const int FinalIndex = 7006;

    public static readonly GetKeywordToken GetKeywordToken = new();
    public const int GetIndex = 7007;

    public static readonly IndirectKeywordToken IndirectKeywordToken = new();
    public const int IndirectIndex = 7008;

    public static readonly InfixKeywordToken InfixKeywordToken = new();
    public const int InfixIndex = 7009;

    public static readonly LazyKeywordToken LazyKeywordToken = new();
    public const int LazyIndex = 7010;

    public static readonly LeftKeywordToken LeftKeywordToken = new();
    public const int LeftIndex = 7011;

    public static readonly MutatingKeywordToken MutatingKeywordToken = new();
    public const int MutatingIndex = 7012;

    public static readonly NoneKeywordToken NoneKeywordToken = new();
    public const int NoneIndex = 7013;

    public static readonly NonMutatingKeywordToken NonMutatingKeywordToken = new();
    public const int NonMutatingIndex = 7014;

    public static readonly OptionalKeywordToken OptionalKeywordToken = new();
    public const int OptionalIndex = 7015;

    public static readonly OverrideKeywordToken OverrideKeywordToken = new();
    public const int OverrideIndex = 7016;

    public static readonly PackageKeywordToken PackageKeywordToken = new();
    public const int PackageIndex = 7017;

    public static readonly PostfixKeywordToken PostfixKeywordToken = new();
    public const int PostfixIndex = 7018;

    public static readonly PrecedenceKeywordToken PrecedenceKeywordToken = new();
    public const int PrecedenceIndex = 7019;

    public static readonly PrefixKeywordToken PrefixKeywordToken = new();
    public const int PrefixIndex = 7020;

    public static readonly ProtocolUppercaseKeywordToken ProtocolUppercaseKeywordToken = new();
    public const int ProtocolUppercaseIndex = 7021;

    public static readonly RequiredKeywordToken RequiredKeywordToken = new();
    public const int RequiredIndex = 7022;

    public static readonly RightKeywordToken RightKeywordToken = new();
    public const int RightIndex = 7023;

    public static readonly SetKeywordToken SetKeywordToken = new();
    public const int SetIndex = 7024;

    public static readonly SomeKeywordToken SomeKeywordToken = new();
    public const int SomeIndex = 7025;

    public static readonly TypeKeywordToken TypeKeywordToken = new();
    public const int TypeIndex = 7026;

    public static readonly UnownedKeywordToken UnownedKeywordToken = new();
    public const int UnownedIndex = 7027;

    public static readonly WeakKeywordToken WeakKeywordToken = new();
    public const int WeakIndex = 7028;

    public static readonly WillSetKeywordToken WillSetKeywordToken = new();
    public const int WillSetIndex = 7029;
    
    #endregion

    #endregion
    
    #region Operators
    
    public const int InfixOperatorIndex = 8001;
    
    public const int PrefixOperatorIndex = 8002;

    public const int PostfixOperatorIndex = 8003;
    
    public const int TernaryOperatorIndex = 8004;
    
    public const int OptionalChainingOperatorIndex = 8005;
    
    public const int QuestionMarkPrefixOperatorIndex = 8006;
    
    public const int QuestionMarkPostfixOperatorIndex = 8007;
    
    public const int ExclamationMarkPrefixOperatorIndex = 8008;
    
    public const int ExclamationMarkPostfixOperatorIndex = 8009;

    #endregion

    #region Errors

    public const int UnmatchedOperatorIndex = 9001;
    
    public const int ErroneousIntegerLiteralIndex = 9002;
    
    public const int ErroneousFloatingPointLiteralIndex = 9003;
    
    public const int UnmatchedHashtagIndex = 9004;
    
    public const int ErroneousStringLiteralIndex = 9005;
    
    public const int ErroneousMultiLineStringLiteralIndex = 9006;
    
    public const int ErroneousMultiLineSurroundedStringLiteralIndex = 9007;
    
    public const int ErroneousRegularExpressionLiteralIndex = 9008;
    
    public const int ErroneousCharacterIndex = 9009;

    #endregion
}