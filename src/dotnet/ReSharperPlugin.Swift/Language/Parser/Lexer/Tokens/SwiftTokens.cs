using DefaultNamespace;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.ContextSensitive;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Declarations;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Errors;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.ExpressionsAndTypes;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Literals;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Markers;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Operators.BuiltinOperators;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Operators.UserDefinedOperators;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Patterns;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Punctuators;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Reserved;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Statements;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.WhitespaceAndComments;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens;

public static class SwiftTokens
{
    #region Markers

    public static readonly StartOfFileToken StartOfFileToken = new();
    public const string StartOfFileId = "START_OF_FILE";
    public const int StartOfFileIndex = 101;

    public static readonly EndOfFileToken EndOfFileToken = new();
    public const string EndOfFileId = "END_OF_FILE";
    public const int EndOfFileIndex = 102;

    public static readonly EmptyToken EmptyToken = new();
    public const string EmptyId = "EMPTY";
    public const int EmptyTokenIndex = 103;

    #endregion

    #region WhitespaceAndComments

    public static readonly WhitespaceToken WhitespaceToken = new();
    public const string WhitespaceId = "WHITESPACE";
    public const int WhitespaceIndex = 201;

    public static readonly NewLineToken NewlineToken = new();
    public const string NewlineId = "NEWLINE";
    public const int NewlineIndex = 202;

    public static readonly LineCommentToken LineCommentToken = new();
    public const string LineCommentId = "COMMENT_LINE";
    public const int LineCommentIndex = 203;

    public static readonly BlockCommentStartToken BlockCommentStartToken = new();
    public const string BlockCommentStartId = "COMMENT_BLOCK_START";
    public const int BlockCommentStartIndex = 204;

    public static readonly BlockCommentEndToken BlockCommentEndToken = new();
    public const string BlockCommentEndId = "COMMENT_BLOCK_END";
    public const int BlockCommentEndIndex = 205;

    public static readonly BlockCommentContentToken BlockCommentContentToken = new();
    public const string BlockCommentContentId = "COMMENT_BLOCK_CONTENT";
    public const int BlockCommentContentIndex = 206;

    #endregion

    #region Identifiers

    public static readonly IdentifierToken IdentifierToken = new();
    public const string IdentifierId = "IDENTIFIER";
    public const int IdentifierIndex = 701;

    #endregion

    #region Literals

    public static readonly IntegerLiteralToken IntegerLiteralToken = new();
    public const string IntegerLiteralId = "LITERAL_INTEGER";
    public const int IntegerLiteralIndex = 801;

    public static readonly FloatingPointLiteral FloatingPointLiteralToken = new();
    public const string FloatingPointLiteralId = "LITERAL_FLOAT";
    public const int FloatingPointLiteralIndex = 802;

    public static readonly StringInterpolationStartToken StringInterpolationStartToken = new();
    public const string StringInterpolationStartId = "LITERAL_STRING_INTERPOLATION";
    public const int StringInterpolationStartIndex = 803;
    
    public static readonly StringInterpolationEndToken StringInterpolationEndToken = new();
    public const string StringInterpolationEndId = "LITERAL_STRING_INTERPOLATION";
    public const int StringInterpolationEndIndex = 803;

    public static readonly StringEscapeSequenceToken StringEscapeSequenceToken = new();
    public const string StringEscapeSequenceId = "LITERAL_STRING_ESCAPE";
    public const int StringEscapeSequenceIndex = 804;

    public static readonly StringLiteralStartToken StringLiteralStartToken = new();
    public const string StringLiteralStartId = "LITERAL_STRING_START";
    public const int StringLiteralStartIndex = 806;

    public static readonly StringLiteralEndToken StringLiteralEndToken = new();
    public const string StringLiteralEndId = "LITERAL_STRING_END";
    public const int StringLiteralEndIndex = 807;

    public static readonly StringLiteralContentToken StringLiteralContentToken = new();
    public const string StringLiteralContentId = "LITERAL_STRING_CONTENT";
    public const int StringLiteralContentIndex = 808;

    public static readonly SurroundedStringLiteralStartToken SurroundedStringLiteralStartToken = new();
    public const string SurroundedStringLiteralStartId = "LITERAL_STRING_SURROUNDED_START";
    public const int SurroundedStringLiteralStartIndex = 809;

    public static readonly SurroundedStringLiteralEndToken SurroundedStringLiteralEndToken = new();
    public const string SurroundedStringLiteralEndId = "LITERAL_STRING_SURROUNDED_END";
    public const int SurroundedStringLiteralEndIndex = 810;

    public static readonly SurroundedStringLiteralContentToken SurroundedStringLiteralContentToken = new();
    public const string SurroundedStringLiteralContentId = "LITERAL_STRING_SURROUNDED_CONTENT";
    public const int SurroundedStringLiteralContentIndex = 811;

    public static readonly MultiLineStringLiteralStartToken MultiLineStringLiteralStartToken = new();
    public const string MultiLineStringLiteralStartId = "LITERAL_STRING_MULTILINE_START";
    public const int MultiLineStringLiteralStartIndex = 812;

    public static readonly MultiLineStringLiteralEndToken MultiLineStringLiteralEndToken = new();
    public const string MultiLineStringLiteralEndId = "LITERAL_STRING_MULTILINE_END";
    public const int MultiLineStringLiteralEndIndex = 813;

    public static readonly MultiLineStringLiteralContentToken MultiLineStringLiteralContentToken = new();
    public const string MultiLineStringLiteralContentId = "LITERAL_STRING_MULTILINE_CONTENT";
    public const int MultiLineStringLiteralContentIndex = 814;

    public static readonly SurroundedMultiLineStringLiteralStartToken SurroundedMultiLineStringLiteralStartToken = new();
    public const string SurroundedMultiLineStringLiteralStartId = "LITERAL_STRING_MULTILINE_SURROUNDED_START";
    public const int SurroundedMultiLineStringLiteralStartIndex = 815;

    public static readonly SurroundedMultiLineStringLiteralEndToken SurroundedMultiLineStringLiteralEndToken = new();
    public const string SurroundedMultiLineStringLiteralEndId = "LITERAL_STRING_MULTILINE_SURROUNDED_END";
    public const int SurroundedMultiLineStringLiteralEndIndex = 816;

    public static readonly SurroundedMultiLineStringLiteralContentToken SurroundedMultiLineStringLiteralContentToken = new();
    public const string MultiLineSurroundedStringLiteralContentId = "LITERAL_STRING_MULTILINE_SURROUNDED_CONTENT";
    public const int MultiLineSurroundedStringLiteralContentIndex = 817;

    public static readonly RegularExpressionLiteralToken RegularExpressionLiteralToken = new();
    public const string RegularExpressionLiteralId = "LITERAL_REGEX";
    public const int RegularExpressionLiteralIndex = 818;

    #endregion
    
    #region Punctuators

    public static readonly LeftParenthesisToken LeftParenthesisToken = new();
    public const string LeftParenthesisId = "PUNCTUATOR_LEFT_PARENTHESIS";
    public const int LeftParenthesisIndex = 901;

    public static readonly RightParenthesisToken RightParenthesisToken = new();
    public const string RightParenthesisId = "PUNCTUATOR_RIGHT_PARENTHESIS";
    public const int RightParenthesisIndex = 902;

    public static readonly LeftCurlyBraceToken LeftCurlyBraceToken = new();
    public const string LeftCurlyBraceId = "PUNCTUATOR_LEFT_CURLY_BRACE";
    public const int LeftCurlyBracedIndex = 903;

    public static readonly RightCurlyBraceToken RightCurlyBraceToken = new();
    public const string RightCurlyBraceId = "PUNCTUATOR_RIGHT_CURLY_BRACE";
    public const int RightCurlyBracedIndex = 904;

    public static readonly LeftSquareBracketToken LeftSquareBracketToken = new();
    public const string LeftSquareBracketId = "PUNCTUATOR_LEFT_SQUARE_BRACKET";
    public const int LeftSquareBracketIndex = 905;

    public static readonly RightSquareBracketToken RightSquareBracketToken = new();
    public const string RightSquareBracketId = "PUNCTUATOR_RIGHT_SQUARE_BRACKET";
    public const int RightSquareBracketIndex = 906;

    public static readonly PeriodToken PeriodToken = new();
    public const string PeriodId = "PUNCTUATOR_PERIOD";
    public const int PeriodIndex = 907;

    public static readonly CommaToken CommaToken = new();
    public const string CommaId = "PUNCTUATOR_COMMA";
    public const int CommaIndex = 908;

    public static readonly ColonToken ColonToken = new();
    public const string ColonId = "PUNCTUATOR_COLON";
    public const int ColonIndex = 909;

    public static readonly SemicolonToken SemicolonToken = new();
    public const string SemicolonId = "PUNCTUATOR_SEMICOLON";
    public const int SemicolonIndex = 910;

    public static readonly EqualsToken EqualsToken = new();
    public const string EqualsId = "PUNCTUATOR_EQUALS";
    public const int EqualsIndex = 911;

    public static readonly AtToken AtToken = new();
    public const string AtId = "PUNCTUATOR_AT";
    public const int AtIndex = 912;

    public static readonly HashToken HashToken = new();
    public const string HashId = "PUNCTUATOR_HASH";
    public const int HashIndex = 913;

    public static readonly AmpersandToken AmpersandToken = new();
    public const string AmpersandId = "PUNCTUATOR_AMPERSAND";
    public const int AmpersandIndex = 914;

    public static readonly ArrowToken ArrowToken = new();
    public const string ArrowId = "PUNCTUATOR_ARROW";
    public const int ArrowIndex = 915;

    public static readonly BacktickToken BacktickToken = new();
    public const string BacktickId = "PUNCTUATOR_BACKTICK";
    public const int BacktickIndex = 916;

    public static readonly QuestionMarkToken QuestionMarkToken = new();
    public const string QuestionMarkId = "PUNCTUATOR_QUESTION_MARK";
    public const int QuestionMarkIndex = 917;

    public static readonly ExclamationMarkToken ExclamationMarkToken = new();
    public const string ExclamationMarkId = "PUNCTUATOR_EXCLAMATION_MARK";
    public const int ExclamationMarkIndex = 918;
    
    #endregion
    
    #region Keywords

    #region UsableInDeclarations
    
    public static readonly AssociatedTypeKeywordToken AssociatedTypeKeywordToken = new();
    public const string AssociatedTypeId = "KEYWORD_ASSOCIATED_TYPE";
    public const int AssociatedTypeIndex = 1001;

    public static readonly BorrowingKeywordToken BorrowingKeywordToken = new();
    public const string BorrowingId = "KEYWORD_BORROWING";
    public const int BorrowingIndex = 1002;

    public static readonly ClassKeywordToken ClassKeywordToken = new();
    public const string ClassId = "KEYWORD_CLASS";
    public const int ClassIndex = 1003;

    public static readonly ConsumingKeywordToken ConsumingKeywordToken = new();
    public const string ConsumingId = "KEYWORD_CONSUMING";
    public const int ConsumingIndex = 1004;

    public static readonly DeinitKeywordToken DeinitKeywordToken = new();
    public const string DeinitId = "KEYWORD_DEINIT";
    public const int DeinitIndex = 1005;

    public static readonly EnumKeywordToken EnumKeywordToken = new();
    public const string EnumId = "KEYWORD_ENUM";
    public const int EnumIndex = 1006;

    public static readonly ExtensionKeywordToken ExtensionKeywordToken = new();
    public const string ExtensionId = "KEYWORD_EXTENSION";
    public const int ExtensionIndex = 1007;

    public static readonly FilePrivateKeywordToken FilePrivateKeywordToken = new();
    public const string FilePrivateId = "KEYWORD_FILEPRIVATE";
    public const int FilePrivateIndex = 1008;

    public static readonly FuncKeywordToken FuncKeywordToken = new();
    public const string FuncId = "KEYWORD_FUNC";
    public const int FuncIndex = 1009;

    public static readonly ImportKeywordToken ImportKeywordToken = new();
    public const string ImportId = "KEYWORD_IMPORT";
    public const int ImportIndex = 1010;

    public static readonly InitKeywordToken InitKeywordToken = new();
    public const string InitId = "KEYWORD_INIT";
    public const int InitIndex = 1011;

    public static readonly InoutKeywordToken InoutKeywordToken = new();
    public const string InoutId = "KEYWORD_INOUT";
    public const int InoutIndex = 1012;

    public static readonly InternalKeywordToken InternalKeywordToken = new();
    public const string InternalId = "KEYWORD_INTERNAL";
    public const int InternalIndex = 1013;

    public static readonly LetKeywordToken LetKeywordToken = new();
    public const string LetId = "KEYWORD_LET";
    public const int LetIndex = 1014;

    public static readonly NonIsolatedKeywordToken NonIsolatedKeywordToken = new();
    public const string NonIsolatedId = "KEYWORD_NONISOLATED";
    public const int NonIsolatedIndex = 1015;

    public static readonly OpenKeywordToken OpenKeywordToken = new();
    public const string OpenId = "KEYWORD_OPEN";
    public const int OpenIndex = 1016;

    public static readonly OperatorKeywordToken OperatorKeywordToken = new();
    public const string OperatorId = "KEYWORD_OPERATOR";
    public const int OperatorIndex = 1017;

    public static readonly PrecedenceGroupKeywordToken PrecedenceGroupKeywordToken = new();
    public const string PrecedenceGroupId = "KEYWORD_PRECEDENCE_GROUP";
    public const int PrecedenceGroupIndex = 1018;

    public static readonly PrivateKeywordToken PrivateKeywordToken = new();
    public const string PrivateId = "KEYWORD_PRIVATE";
    public const int PrivateIndex = 1019;

    public static readonly ProtocolLowercaseKeywordToken ProtocolLowercaseKeywordToken = new();
    public const string ProtocolLowercaseId = "KEYWORD_PROTOCOL_LOWERCASE";
    public const int ProtocolLowercaseIndex = 1020;

    public static readonly PublicKeywordToken PublicKeywordToken = new();
    public const string PublicId = "KEYWORD_PUBLIC";
    public const int PublicIndex = 1021;

    public static readonly RethrowsKeywordToken RethrowsKeywordToken = new();
    public const string RethrowsId = "KEYWORD_RETHROWS";
    public const int RethrowsIndex = 1022;

    public static readonly StaticKeywordToken StaticKeywordToken = new();
    public const string StaticId = "KEYWORD_STATIC";
    public const int StaticIndex = 1023;

    public static readonly StructKeywordToken StructKeywordToken = new();
    public const string StructId = "KEYWORD_STRUCT";
    public const int StructIndex = 1024;

    public static readonly SubscriptKeywordToken SubscriptKeywordToken = new();
    public const string SubscriptId = "KEYWORD_SUBSCRIPT";
    public const int SubscriptIndex = 1025;

    public static readonly TypealiasKeywordToken TypealiasKeywordToken = new();
    public const string TypealiasId = "KEYWORD_TYPEALIAS";
    public const int TypealiasIndex = 1026;

    public static readonly VarKeywordToken VarKeywordToken = new();
    public const string VarId = "KEYWORD_VAR";
    public const int VarIndex = 1027;

    #endregion

    #region UsableInStatements

    public static readonly BreakKeywordToken BreakKeywordToken = new();
    public const string BreakId = "KEYWORD_BREAK";
    public const int BreakIndex = 2001;

    public static readonly CaseKeywordToken CaseKeywordToken = new();
    public const string CaseId = "KEYWORD_CASE";
    public const int CaseIndex = 2002;

    public static readonly CatchKeywordToken CatchKeywordToken = new();
    public const string CatchId = "KEYWORD_CATCH";
    public const int CatchIndex = 2003;

    public static readonly ContinueKeywordToken ContinueKeywordToken = new();
    public const string ContinueId = "KEYWORD_CONTINUE";
    public const int ContinueIndex = 2004;

    public static readonly DefaultKeywordToken DefaultKeywordToken = new();
    public const string DefaultId = "KEYWORD_DEFAULT";
    public const int DefaultIndex = 2005;

    public static readonly DeferKeywordToken DeferKeywordToken = new();
    public const string DeferId = "KEYWORD_DEFER";
    public const int DeferIndex = 2006;

    public static readonly DoKeywordToken DoKeywordToken = new();
    public const string DoId = "KEYWORD_DO";
    public const int DoIndex = 2007;

    public static readonly ElseKeywordToken ElseKeywordToken = new();
    public const string ElseId = "KEYWORD_ELSE";
    public const int ElseIndex = 2008;

    public static readonly FallthroughKeywordToken FallthroughKeywordToken = new();
    public const string FallthroughId = "KEYWORD_FALLTHROUGH";
    public const int FallthroughIndex = 2009;

    public static readonly ForKeywordToken ForKeywordToken = new();
    public const string ForId = "KEYWORD_FOR";
    public const int ForIndex = 2010;

    public static readonly GuardKeywordToken GuardKeywordToken = new();
    public const string GuardId = "KEYWORD_GUARD";
    public const int GuardIndex = 2011;

    public static readonly IfKeywordToken IfKeywordToken = new();
    public const string IfId = "KEYWORD_IF";
    public const int IfIndex = 2012;

    public static readonly InKeywordToken InKeywordToken = new();
    public const string InId = "KEYWORD_IN";
    public const int InIndex = 2013;

    public static readonly RepeatKeywordToken RepeatKeywordToken = new();
    public const string RepeatId = "KEYWORD_REPEAT";
    public const int RepeatIndex = 2014;

    public static readonly ReturnKeywordToken ReturnKeywordToken = new();
    public const string ReturnId = "KEYWORD_RETURN";
    public const int ReturnIndex = 2015;

    public static readonly SwitchKeywordToken SwitchKeywordToken = new();
    public const string SwitchId = "KEYWORD_SWITCH";
    public const int SwitchIndex = 2016;

    public static readonly ThrowKeywordToken ThrowKeywordToken = new();
    public const string ThrowId = "KEYWORD_THROW";
    public const int ThrowIndex = 2017;

    public static readonly WhereKeywordToken WhereKeywordToken = new();
    public const string WhereId = "KEYWORD_WHERE";
    public const int WhereIndex = 2018;

    public static readonly WhileKeywordToken WhileKeywordToken = new();
    public const string WhileId = "KEYWORD_WHILE";
    public const int WhileIndex = 2019;

    #endregion

    #region UsableInExpressionsAndTypes

    public static readonly AnyKeywordToken AnyKeywordToken = new();
    public const string AnyId = "KEYWORD_ANY";
    public const int AnyIndex = 3001;

    public static readonly AsKeywordToken AsKeywordToken = new();
    public const string AsId = "KEYWORD_AS";
    public const int AsIndex = 3002;

    public static readonly AwaitKeywordToken AwaitKeywordToken = new();
    public const string AwaitId = "KEYWORD_AWAIT";
    public const int AwaitIndex = 3003;

    public static readonly FalseLiteralToken FalseLiteralToken = new();
    public const string FalseId = "KEYWORD_FALSE";
    public const int FalseIndex = 3004;

    public static readonly IsKeywordToken IsKeywordToken = new();
    public const string IsId = "KEYWORD_IS";
    public const int IsIndex = 3005;

    public static readonly NilLiteralToken NilLiteralToken = new();
    public const string NilId = "KEYWORD_NIL";
    public const int NilIndex = 3006;

    public static readonly SelfLowercaseKeywordToken SelfLowercaseKeywordToken = new();
    public const string SelfLowercaseId = "KEYWORD_SELF_LOWERCASE";
    public const int SelfLowercaseIndex = 3007;

    public static readonly SelfUppercaseKeywordToken SelfUppercaseKeywordToken = new();
    public const string SelfUppercaseId = "KEYWORD_SELF_UPPERCASE";
    public const int SelfUppercaseIndex = 3008;

    public static readonly SuperKeywordToken SuperKeywordToken = new();
    public const string SuperId = "KEYWORD_SUPER";
    public const int SuperIndex = 3009;

    public static readonly ThrowsKeywordToken ThrowsKeywordToken = new();
    public const string ThrowsId = "KEYWORD_THROWS";
    public const int ThrowsIndex = 3010;

    public static readonly TrueLiteralToken TrueLiteralToken = new();
    public const string TrueId = "KEYWORD_TRUE";
    public const int TrueIndex = 3011;

    public static readonly TryKeywordToken TryKeywordToken = new();
    public const string TryId = "KEYWORD_TRY";
    public const int TryIndex = 3012;
    
    #endregion

    #region UsableInPatterns

    public static readonly UnderscoreTokenKeyword UnderscoreKeywordToken = new();
    public const string UnderscoreId = "KEYWORD_UNDERSCORE";
    public const int UnderscoreIndex = 4001;

    #endregion

    #region ReservedIdentifiers

    public static readonly ReservedAvailableKeywordToken ReservedAvailableKeywordToken = new();
    public const string ReservedAvailableId = "KEYWORD_RESERVED_AVAILABLE";
    public const int ReservedAvailableIndex = 5001;

    public static readonly ReservedColorLiteralKeywordToken ReservedColorLiteralKeywordToken = new();
    public const string ReservedColorLiteralId = "KEYWORD_RESERVED_COLOR_LITERAL";
    public const int ReservedColorLiteralIndex = 5002;

    public static readonly ReservedElseKeywordToken ReservedElseKeywordToken = new();
    public const string ReservedElseId = "KEYWORD_RESERVED_ELSE";
    public const int ReservedElseIndex = 5003;

    public static readonly ReservedElseIfKeywordToken ReservedElseIfKeywordToken = new();
    public const string ReservedElseIfId = "KEYWORD_RESERVED_ELSE_IF";
    public const int ReservedElseIfIndex = 5004;

    public static readonly ReservedEndIfKeywordToken ReservedEndIfKeywordToken = new();
    public const string ReservedEndIfId = "KEYWORD_RESERVED_END_IF";
    public const int ReservedEndIfIndex = 5005;

    public static readonly ReservedFileLiteralKeywordToken ReservedFileLiteralKeywordToken = new();
    public const string ReservedFileLiteralId = "KEYWORD_RESERVED_FILE_LITERAL";
    public const int ReservedFileLiteralIndex = 5006;

    public static readonly ReservedIfKeywordToken ReservedIfKeywordToken = new();
    public const string ReservedIfId = "KEYWORD_RESERVED_IF";
    public const int ReservedIfIndex = 5007;

    public static readonly ReservedImageLiteralKeywordToken ReservedImageLiteralKeywordToken = new();
    public const string ReservedImageLiteralId = "KEYWORD_RESERVED_IMAGE_LITERAL";
    public const int ReservedImageLiteralIndex = 5008;

    public static readonly ReservedKeyPathKeywordToken ReservedKeyPathKeywordToken = new();
    public const string ReservedKeyPathId = "KEYWORD_RESERVED_KEY_PATH";
    public const int ReservedKeyPathIndex = 5009;

    public static readonly ReservedSelectorKeywordToken ReservedSelectorKeywordToken = new();
    public const string ReservedSelectorId = "KEYWORD_RESERVED_SELECTOR";
    public const int ReservedSelectorIndex = 5010;

    public static readonly ReservedSourceLocationKeywordToken ReservedSourceLocationKeywordToken = new();
    public const string ReservedSourceLocationId = "KEYWORD_RESERVED_SOURCE_LOCATION";
    public const int ReservedSourceLocationIndex = 5011;

    public static readonly ReservedUnavailableKeywordToken ReservedUnavailableKeywordToken = new();
    public const string ReservedUnavailableId = "KEYWORD_RESERVED_UNAVAILABLE";
    public const int ReservedUnavailableIndex = 5012;

    #endregion

    #region PreviouslyReservedIdentifiers

    public static readonly PreviouslyReservedColumnKeywordToken PreviouslyReservedColumnKeywordToken = new();
    public const string PreviouslyReservedColumnId = "KEYWORD_PREVIOUSLY_RESERVED_COLUMN";
    public const int PreviouslyReservedColumnIndex = 6001;

    public static readonly PreviouslyReservedDsoHandleKeywordToken PreviouslyReservedDsoHandleKeywordToken = new();
    public const string PreviouslyReservedDsoHandleId = "KEYWORD_PREVIOUSLY_RESERVED_DSO_HANDLE";
    public const int PreviouslyReservedDsoHandleIndex = 6002;

    public static readonly PreviouslyReservedErrorKeywordToken PreviouslyReservedErrorKeywordToken = new();
    public const string PreviouslyReservedErrorId = "KEYWORD_PREVIOUSLY_RESERVED_ERROR";
    public const int PreviouslyReservedErrorIndex = 6003;

    public static readonly PreviouslyReservedFileIdKeywordToken PreviouslyReservedFileIdKeywordToken = new();
    public const string PreviouslyReservedFileIdId = "KEYWORD_PREVIOUSLY_RESERVED_FILE_ID";
    public const int PreviouslyReservedFileIdIndex = 6004;
    
    public static readonly PreviouslyReservedFilePathKeywordToken PreviouslyReservedFilePathKeywordToken = new();
    public const string PreviouslyReservedFilePathId = "KEYWORD_PREVIOUSLY_RESERVED_FILE_PATH";
    public const int PreviouslyReservedFilePathIndex = 6005;

    public static readonly PreviouslyReservedFileKeywordToken PreviouslyReservedFileKeywordToken = new();
    public const string PreviouslyReservedFileId = "KEYWORD_PREVIOUSLY_RESERVED_FILE";
    public const int PreviouslyReservedFileIndex = 6006;

    public static readonly PreviouslyReservedFunctionKeywordToken PreviouslyReservedFunctionKeywordToken = new();
    public const string PreviouslyReservedFunctionId = "KEYWORD_PREVIOUSLY_RESERVED_FUNCTION";
    public const int PreviouslyReservedFunctionIndex = 6007;

    public static readonly PreviouslyReservedLineKeywordToken PreviouslyReservedLineKeywordToken = new();
    public const string PreviouslyReservedLineId = "KEYWORD_PREVIOUSLY_RESERVED_LINE";
    public const int PreviouslyReservedLineIndex = 6008;

    public static readonly PreviouslyReservedWarningKeywordToken PreviouslyReservedWarningKeywordToken = new();
    public const string PreviouslyReservedWarningId = "KEYWORD_PREVIOUSLY_RESERVED_WARNING";
    public const int PreviouslyReservedWarningIndex = 6009;

    #endregion

    #region ContextSensitiveKeywords

    public static readonly AssociativityKeywordToken AssociativityKeywordToken = new();
    public const string AssociativityId = "KEYWORD_ASSOCIATIVITY";
    public const int AssociativityIndex = 7001;

    public static readonly AsyncKeywordToken AsyncKeywordToken = new();
    public const string AsyncId = "KEYWORD_ASYNC";
    public const int AsyncIndex = 7002;

    public static readonly ConvenienceKeywordToken ConvenienceKeywordToken = new();
    public const string ConvenienceId = "KEYWORD_CONVENIENCE";
    public const int ConvenienceIndex = 7003;

    public static readonly DidSetKeywordToken DidSetKeywordToken = new();
    public const string DidSetId = "KEYWORD_DID_SET";
    public const int DidSetIndex = 7004;

    public static readonly DynamicKeywordToken DynamicKeywordToken = new();
    public const string DynamicId = "KEYWORD_DYNAMIC";
    public const int DynamicIndex = 7005;

    public static readonly FinalKeywordToken FinalKeywordToken = new();
    public const string FinalId = "KEYWORD_FINAL";
    public const int FinalIndex = 7006;

    public static readonly GetKeywordToken GetKeywordToken = new();
    public const string GetId = "KEYWORD_GET";
    public const int GetIndex = 7007;

    public static readonly IndirectKeywordToken IndirectKeywordToken = new();
    public const string IndirectId = "KEYWORD_INDIRECT";
    public const int IndirectIndex = 7008;

    public static readonly InfixKeywordToken InfixKeywordToken = new();
    public const string InfixId = "KEYWORD_INFIX";
    public const int InfixIndex = 7009;

    public static readonly LazyKeywordToken LazyKeywordToken = new();
    public const string LazyId = "KEYWORD_LAZY";
    public const int LazyIndex = 7010;

    public static readonly LeftKeywordToken LeftKeywordToken = new();
    public const string LeftId = "KEYWORD_LEFT";
    public const int LeftIndex = 7011;

    public static readonly MutatingKeywordToken MutatingKeywordToken = new();
    public const string MutatingId = "KEYWORD_MUTATING";
    public const int MutatingIndex = 7012;

    public static readonly NoneKeywordToken NoneKeywordToken = new();
    public const string NoneId = "KEYWORD_NONE";
    public const int NoneIndex = 7013;

    public static readonly NonMutatingKeywordToken NonMutatingKeywordToken = new();
    public const string NonMutatingId = "KEYWORD_NON_MUTATING";
    public const int NonMutatingIndex = 7014;

    public static readonly OptionalKeywordToken OptionalKeywordToken = new();
    public const string OptionalId = "KEYWORD_OPTIONAL";
    public const int OptionalIndex = 7015;

    public static readonly OverrideKeywordToken OverrideKeywordToken = new();
    public const string OverrideId = "KEYWORD_OVERRIDE";
    public const int OverrideIndex = 7016;

    public static readonly PackageKeywordToken PackageKeywordToken = new();
    public const string PackageId = "KEYWORD_PACKAGE";
    public const int PackageIndex = 7017;

    public static readonly PostfixKeywordToken PostfixKeywordToken = new();
    public const string PostfixId = "KEYWORD_POSTFIX";
    public const int PostfixIndex = 7018;

    public static readonly PrecedenceKeywordToken PrecedenceKeywordToken = new();
    public const string PrecedenceId = "KEYWORD_PRECEDENCE";
    public const int PrecedenceIndex = 7019;

    public static readonly PrefixKeywordToken PrefixKeywordToken = new();
    public const string PrefixId = "KEYWORD_PREFIX";
    public const int PrefixIndex = 7020;

    public static readonly ProtocolUppercaseKeywordToken ProtocolUppercaseKeywordToken = new();
    public const string ProtocolUppercaseId = "KEYWORD_PROTOCOL_UPPERCASE";
    public const int ProtocolUppercaseIndex = 7021;

    public static readonly RequiredKeywordToken RequiredKeywordToken = new();
    public const string RequiredId = "KEYWORD_REQUIRED";
    public const int RequiredIndex = 7022;

    public static readonly RightKeywordToken RightKeywordToken = new();
    public const string RightId = "KEYWORD_RIGHT";
    public const int RightIndex = 7023;

    public static readonly SetKeywordToken SetKeywordToken = new();
    public const string SetId = "KEYWORD_SET";
    public const int SetIndex = 7024;

    public static readonly SomeKeywordToken SomeKeywordToken = new();
    public const string SomeId = "KEYWORD_SOME";
    public const int SomeIndex = 7025;

    public static readonly TypeKeywordToken TypeKeywordToken = new();
    public const string TypeId = "KEYWORD_TYPE";
    public const int TypeIndex = 7026;

    public static readonly UnownedKeywordToken UnownedKeywordToken = new();
    public const string UnownedId = "KEYWORD_UNOWNED";
    public const int UnownedIndex = 7027;

    public static readonly WeakKeywordToken WeakKeywordToken = new();
    public const string WeakId = "KEYWORD_WEAK";
    public const int WeakIndex = 7028;

    public static readonly WillSetKeywordToken WillSetKeywordToken = new();
    public const string WillSetId = "KEYWORD_WILL_SET";
    public const int WillSetIndex = 7029;
    
    #endregion

    #endregion
    
    #region Operators

    public static readonly InfixOperatorToken InfixOperatorToken = new();
    public const string InfixOperatorId = "OPERATOR_INFIX";
    public const int InfixOperatorIndex = 8001;
    
    public static readonly PrefixOperatorToken PrefixOperatorToken = new();
    public const string PrefixOperatorId = "OPERATOR_PREFIX";
    public const int PrefixOperatorIndex = 8002;

    public static readonly PostfixOperatorToken PostfixOperatorToken = new();
    public const string PostfixOperatorId = "OPERATOR_POSTFIX";
    public const int PostfixOperatorIndex = 8003;
    
    public static readonly TernaryOperatorToken TernaryOperatorToken = new();
    public const string TernaryOperatorId = "OPERATOR_TERNARY";
    public const int TernaryOperatorIndex = 8004;
    
    public static readonly OptionalChainingOperatorToken OptionalChainingOperatorToken = new();
    public const string OptionalChainingOperatorId = "OPERATOR_OPTIONAL_CHAINING";
    public const int OptionalChainingOperatorIndex = 8005;
    
    public static readonly QuestionMarkPrefixOperatorToken QuestionMarkPrefixOperatorToken = new();
    public const string QuestionMarkPrefixOperatorId = "OPERATOR_QUESTION_MARK_PREFIX";
    public const int QuestionMarkPrefixOperatorIndex = 8006;
    
    public static readonly QuestionMarkPostfixOperatorToken QuestionMarkPostfixOperatorToken = new();
    public const string QuestionMarkPostfixOperatorId = "OPERATOR_QUESTION_MARK_POSTFIX";
    public const int QuestionMarkPostfixOperatorIndex = 8007;
    
    public static readonly ExclamationMarkPrefixOperatorToken ExclamationMarkPrefixOperatorToken = new();
    public const string ExclamationMarkPrefixOperatorId = "OPERATOR_EXCLAMATION_MARK_PREFIX";
    public const int ExclamationMarkPrefixOperatorIndex = 8008;
    
    public static readonly ExclamationMarkPostfixOperatorToken ExclamationMarkPostfixOperatorToken = new();
    public const string ExclamationMarkPostfixOperatorId = "OPERATOR_EXCLAMATION_MARK_POSTFIX";
    public const int ExclamationMarkPostfixOperatorIndex = 8009;

    #endregion

    #region Errors

    public static readonly InvalidToken InvalidToken = new();
    public const string InvalidTokenId = "ERROR_INVALID_TOKEN";
    public const int InvalidTokenIndex = 9001;

    public static readonly UnmatchedOperatorToken UnmatchedOperatorToken = new();
    public const string UnmatchedOperatorId = "ERROR_OPERATOR_UNMATCHED";
    public const int UnmatchedOperatorIndex = 9002;
    
    public static readonly ErroneousIntegerLiteralToken ErroneousIntegerLiteralToken = new();
    public const string ErroneousIntegerLiteralId = "ERROR_LITERAL_INTEGER";
    public const int ErroneousIntegerLiteralIndex = 9003;
    
    public static readonly ErroneousFloatingPointLiteralToken ErroneousFloatingPointLiteralToken = new();
    public const string ErroneousFloatingPointLiteralId = "ERROR_LITERAL_FLOAT";
    public const int ErroneousFloatingPointLiteralIndex = 9004;
    
    public static readonly UnmatchedHashtagToken UnmatchedHashtagToken = new();
    public const string UnmatchedHashtagId = "ERROR_UNMATCHED_HASHTAG";
    public const int UnmatchedHashtagIndex = 9005;
    
    public static readonly ErroneousStringLiteralToken ErroneousStringLiteralToken = new();
    public const string ErroneousStringLiteralId = "ERROR_LITERAL_STRING";
    public const int ErroneousStringLiteralIndex = 9006;

    #endregion
}