using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Identifiers;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.C;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.ObjectiveC;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Literals;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Markers;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Whitespace;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens;

public static class ObjectiveCTokens
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

    public static readonly BlockCommentToken BlockCommentToken = new();
    public const string BlockCommentId = "COMMENT_BLOCK";
    public const int BlockCommentIndex = 204;

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
    
    public static readonly FloatingPointLiteralToken FloatingPointLiteralToken = new();
    public const string FloatingPointLiteralId = "LITERAL_FLOAT";
    public const int FloatingPointLiteralIndex = 802;
    
    public static readonly CharacterLiteralToken CharacterLiteralToken = new();
    public const string CharacterLiteralId = "LITERAL_CHARACTER";
    public const int CharacterLiteralIndex = 803;
    
    public static readonly StringLiteralToken StringLiteralToken = new();
    public const string StringLiteralId = "LITERAL_STRING";
    public const int StringLiteralIndex = 804;

    #endregion

    #region Punctuators
    
    #region C

    public static readonly OpeningSquareBracketToken OpeningSquareBracketToken = new();
    public const string OpeningSquareBracketId = "[";
    public const int OpeningSquareBracketIndex = 901;

    public static readonly ClosingSquareBracketToken ClosingSquareBracketToken = new();
    public const string ClosingSquareBracketId = "]";
    public const int ClosingSquareBracketIndex = 902;
    
    public static readonly OpeningParenthesisToken OpeningParenthesisToken = new();
    public const string OpeningParenthesisId = "(";
    public const int OpeningParenthesisIndex = 903;

    public static readonly ClosingParenthesisToken ClosingParenthesisToken = new();
    public const string ClosingParenthesisId = ")";
    public const int ClosingParenthesisIndex = 904;

    public static readonly OpeningCurlyBraceToken OpeningCurlyBraceToken = new();
    public const string OpeningCurlyBraceId = "{";
    public const int OpeningCurlyBraceIndex = 905;

    public static readonly ClosingCurlyBraceToken ClosingCurlyBraceToken = new();
    public const string ClosingCurlyBraceId = "}";
    public const int ClosingCurlyBraceIndex = 906;

    public static readonly PeriodToken PeriodToken = new();
    public const string PeriodId = ".";
    public const int PeriodIndex = 907;

    public static readonly ArrowToken ArrowToken = new();
    public const string ArrowId = "->";
    public const int ArrowIndex = 908;

    public static readonly PlusPlusToken PlusPlusToken = new();
    public const string PlusPlusId = "++";
    public const int PlusPlusIndex = 909;

    public static readonly MinusMinusToken MinusMinusToken = new();
    public const string MinusMinusId = "--";
    public const int MinusMinusIndex = 910;

    public static readonly AmpersandToken AmpersandToken = new();
    public const string AmpersandId = "&";
    public const int AmpersandIndex = 911;

    public static readonly AsteriskToken AsteriskToken = new();
    public const string AsteriskId = "*";
    public const int AsteriskIndex = 912;

    public static readonly PlusToken PlusToken = new();
    public const string PlusId = "+";
    public const int PlusIndex = 913;

    public static readonly MinusToken MinusToken = new();
    public const string MinusId = "-";
    public const int MinusIndex = 914;

    public static readonly TildeToken TildeToken = new();
    public const string TildeId = "~";
    public const int TildeIndex = 915;

    public static readonly ExclamationMarkToken ExclamationMarkToken = new();
    public const string ExclamationMarkId = "!";
    public const int ExclamationMarkIndex = 916;

    public static readonly SlashToken SlashToken = new();
    public const string SlashId = "/";
    public const int SlashIndex = 917;

    public static readonly PercentageSignToken PercentageSignToken = new();
    public const string PercentageSignId = "%";
    public const int PercentageSignIndex = 918;

    public static readonly DoubleOpeningAngleBracketToken DoubleOpeningAngleBracketToken = new();
    public const string DoubleOpeningAngleBracketId = "<<";
    public const int DoubleOpeningAngleBracketIndex = 919;

    public static readonly DoubleClosingAngleBracketToken DoubleClosingAngleBracketToken = new();
    public const string DoubleClosingAngleBracketId = ">>";
    public const int DoubleClosingAngleBracketIndex = 920;

    public static readonly OpeningAngleBracketToken OpeningAngleBracketToken = new();
    public const string OpeningAngleBracketId = "<";
    public const int OpeningAngleBracketIndex = 921;

    public static readonly ClosingAngleBracketToken ClosingAngleBracketToken = new();
    public const string ClosingAngleBracketId = ">";
    public const int ClosingAngleBracketIndex = 922;

    public static readonly OpeningAngleBracketEqualsSignToken OpeningAngleBracketEqualsSignToken = new();
    public const string OpeningAngleBracketEqualsSignId = "<=";
    public const int OpeningAngleBracketEqualsSignIndex = 923;

    public static readonly ClosingAngleBracketEqualsSignToken ClosingAngleBracketEqualsSignToken = new();
    public const string ClosingAngleBracketEqualsSignId = ">=";
    public const int ClosingAngleBracketEqualsSignIndex = 924;

    public static readonly DoubleEqualsSignToken DoubleEqualsSignToken = new();
    public const string DoubleEqualsSignId = "==";
    public const int DoubleEqualsSignIndex = 925;

    public static readonly ExclamationMarkEqualsSignToken ExclamationMarkEqualsSignToken = new();
    public const string ExclamationMarkEqualsSignId = "!=";
    public const int ExclamationMarkEqualsSignIndex = 926;

    public static readonly CaretToken CaretToken = new();
    public const string CaretId = "^";
    public const int CaretIndex = 927;

    public static readonly VerticalSlashToken VerticalSlashToken = new();
    public const string VerticalSlashId = "|";
    public const int VerticalSlashIndex = 928;

    public static readonly DoubleAmpersandToken DoubleAmpersandToken = new();
    public const string DoubleAmpersandId = "&&";
    public const int DoubleAmpersandIndex = 929;

    public static readonly DoubleVerticalSlashToken DoubleVerticalSlashToken = new();
    public const string DoubleVerticalSlashId = "||";
    public const int DoubleVerticalSlashIndex = 930;

    public static readonly QuestionMarkToken QuestionMarkToken = new();
    public const string QuestionMarkId = "?";
    public const int QuestionMarkIndex = 931;

    public static readonly ColonToken ColonToken = new();
    public const string ColonId = ":";
    public const int ColonIndex = 932;

    public static readonly SemicolonToken SemicolonToken = new();
    public const string SemicolonId = ";";
    public const int SemicolonIndex = 933;

    public static readonly TriplePeriodToken TriplePeriodToken = new();
    public const string TriplePeriodId = "...";
    public const int TriplePeriodIndex = 934;

    public static readonly EqualsSignToken EqualsSignToken = new();
    public const string EqualsSignId = "=";
    public const int EqualsSignIndex = 935;

    public static readonly AsteriskEqualsSignToken AsteriskEqualsSignToken = new();
    public const string AsteriskEqualsSignId = "*=";
    public const int AsteriskEqualsSignIndex = 936;

    public static readonly SlashEqualsSignToken SlashEqualsSignToken = new();
    public const string SlashEqualsSignId = "/=";
    public const int SlashEqualsSignIndex = 937;

    public static readonly PercentageSignEqualsSignToken PercentageSignEqualsSignToken = new();
    public const string PercentageSignEqualsSignId = "%=";
    public const int PercentageSignEqualsSignIndex = 938;

    public static readonly PlusEqualsSignToken PlusEqualsSignToken = new();
    public const string PlusEqualsSignId = "+=";
    public const int PlusEqualsSignIndex = 939;

    public static readonly MinusEqualsSignToken MinusEqualsSignToken = new();
    public const string MinusEqualsSignId = "-=";
    public const int MinusEqualsSignIndex = 940;

    public static readonly DoubleOpeningAngleBracketEqualsSignToken DoubleOpeningAngleBracketEqualsSignToken = new();
    public const string DoubleOpeningAngleBracketEqualsSignId = "<<=";
    public const int DoubleOpeningAngleBracketEqualsSignIndex = 941;

    public static readonly DoubleClosingAngleBracketEqualsSignToken DoubleClosingAngleBracketEqualsSignToken = new();
    public const string DoubleClosingAngleBracketEqualsSignId = ">>=";
    public const int DoubleClosingAngleBracketEqualsSignIndex = 942;

    public static readonly AmpersandEqualsSignToken AmpersandEqualsSignToken = new();
    public const string AmpersandEqualsSignId = "&=";
    public const int AmpersandEqualsSignIndex = 943;

    public static readonly CaretEqualsSignToken CaretEqualsSignToken = new();
    public const string CaretEqualsSignId = "^=";
    public const int CaretEqualsSignIndex = 944;

    public static readonly VerticalSlashEqualsSignToken VerticalSlashEqualsSignToken = new();
    public const string VerticalSlashEqualsSignId = "|=";
    public const int VerticalSlashEqualsSignIndex = 945;

    public static readonly CommaToken CommaToken = new();
    public const string CommaId = ",";
    public const int CommaIndex = 946;

    public static readonly HashtagToken HashtagToken = new();
    public const string HashtagId = "#";
    public const int HashtagIndex = 947;

    public static readonly DoubleHashtagToken DoubleHashtagToken = new();
    public const string DoubleHashtagId = "##";
    public const int DoubleHashtagIndex = 948;

    public static readonly OpeningAngleBracketColonToken OpeningAngleBracketColonToken = new();
    public const string OpeningAngleBracketColonId = "<:";
    public const int OpeningAngleBracketColonIndex = 949;

    public static readonly ColonClosingAngleBracketToken ColonClosingAngleBracketToken = new();
    public const string ColonClosingAngleBracketId = ":>";
    public const int ColonClosingAngleBracketIndex = 950;

    public static readonly OpeningAngleBracketPercentageSignToken OpeningAngleBracketPercentageSignToken = new();
    public const string OpeningAngleBracketPercentageSignId = "<%";
    public const int OpeningAngleBracketPercentageSignIndex = 951;

    public static readonly PercentageSignClosingAngleBracketToken PercentageSignClosingAngleBracketToken = new();
    public const string PercentageSignClosingAngleBracketId = "%>";
    public const int PercentageSignClosingAngleBracketIndex = 952;

    public static readonly PercentageSignColonToken PercentageSignColonToken = new();
    public const string PercentageSignColonId = "%:";
    public const int PercentageSignColonIndex = 953;

    public static readonly PercentageSignColonPercentageSignColonToken PercentageSignColonPercentageSignColonToken = new();
    public const string PercentageSignColonPercentageSignColonId = "%:%:";
    public const int PercentageSignColonPercentageSignColonIndex = 954;
    
    #endregion
    
    #region ObjectiveC
    
    public static readonly AtToken AtToken = new();
    public const string AtId = "@";
    public const int AtIndex = 955;
    
    #endregion
    
    #endregion

    #region Keywords

    #region C

    public static readonly AutoKeywordToken AutoKeywordToken = new();
    public const string AutoKeywordId = "auto";
    public const int AutoKeywordIndex = 1001;

    public static readonly BreakKeywordToken BreakKeywordToken = new();
    public const string BreakKeywordId = "break";
    public const int BreakKeywordIndex = 1002;

    public static readonly CaseKeywordToken CaseKeywordToken = new();
    public const string CaseKeywordId = "case";
    public const int CaseKeywordIndex = 1003;

    public static readonly CharKeywordToken CharKeywordToken = new();
    public const string CharKeywordId = "char";
    public const int CharKeywordIndex = 1004;

    public static readonly ConstKeywordToken ConstKeywordToken = new();
    public const string ConstKeywordId = "const";
    public const int ConstKeywordIndex = 1005;

    public static readonly ContinueKeywordToken ContinueKeywordToken = new();
    public const string ContinueKeywordId = "continue";
    public const int ContinueKeywordIndex = 1006;

    public static readonly DefaultKeywordToken DefaultKeywordToken = new();
    public const string DefaultKeywordId = "default";
    public const int DefaultKeywordIndex = 1007;

    public static readonly DoKeywordToken DoKeywordToken = new();
    public const string DoKeywordId = "do";
    public const int DoKeywordIndex = 1008;

    public static readonly DoubleKeywordToken DoubleKeywordToken = new();
    public const string DoubleKeywordId = "double";
    public const int DoubleKeywordIndex = 1009;

    public static readonly ElseKeywordToken ElseKeywordToken = new();
    public const string ElseKeywordId = "else";
    public const int ElseKeywordIndex = 1010;

    public static readonly EnumKeywordToken EnumKeywordToken = new();
    public const string EnumKeywordId = "enum";
    public const int EnumKeywordIndex = 1011;

    public static readonly ExternKeywordToken ExternKeywordToken = new();
    public const string ExternKeywordId = "extern";
    public const int ExternKeywordIndex = 1012;

    public static readonly FloatKeywordToken FloatKeywordToken = new();
    public const string FloatKeywordId = "float";
    public const int FloatKeywordIndex = 1013;

    public static readonly ForKeywordToken ForKeywordToken = new();
    public const string ForKeywordId = "for";
    public const int ForKeywordIndex = 1014;

    public static readonly GotoKeywordToken GotoKeywordToken = new();
    public const string GotoKeywordId = "goto";
    public const int GotoKeywordIndex = 1015;

    public static readonly IfKeywordToken IfKeywordToken = new();
    public const string IfKeywordId = "if";
    public const int IfKeywordIndex = 1016;

    public static readonly InlineKeywordToken InlineKeywordToken = new();
    public const string InlineKeywordId = "inline";
    public const int InlineKeywordIndex = 1017;

    public static readonly IntKeywordToken IntKeywordToken = new();
    public const string IntKeywordId = "int";
    public const int IntKeywordIndex = 1018;

    public static readonly LongKeywordToken LongKeywordToken = new();
    public const string LongKeywordId = "long";
    public const int LongKeywordIndex = 1019;

    public static readonly RegisterKeywordToken RegisterKeywordToken = new();
    public const string RegisterKeywordId = "register";
    public const int RegisterKeywordIndex = 1020;

    public static readonly RestrictKeywordToken RestrictKeywordToken = new();
    public const string RestrictKeywordId = "restrict";
    public const int RestrictKeywordIndex = 1021;

    public static readonly ReturnKeywordToken ReturnKeywordToken = new();
    public const string ReturnKeywordId = "return";
    public const int ReturnKeywordIndex = 1022;

    public static readonly ShortKeywordToken ShortKeywordToken = new();
    public const string ShortKeywordId = "short";
    public const int ShortKeywordIndex = 1023;

    public static readonly SignedKeywordToken SignedKeywordToken = new();
    public const string SignedKeywordId = "signed";
    public const int SignedKeywordIndex = 1024;

    public static readonly SizeofKeywordToken SizeofKeywordToken = new();
    public const string SizeofKeywordId = "sizeof";
    public const int SizeofKeywordIndex = 1025;

    public static readonly StaticKeywordToken StaticKeywordToken = new();
    public const string StaticKeywordId = "static";
    public const int StaticKeywordIndex = 1026;

    public static readonly StructKeywordToken StructKeywordToken = new();
    public const string StructKeywordId = "struct";
    public const int StructKeywordIndex = 1027;

    public static readonly SwitchKeywordToken SwitchKeywordToken = new();
    public const string SwitchKeywordId = "switch";
    public const int SwitchKeywordIndex = 1028;

    public static readonly TypedefKeywordToken TypedefKeywordToken = new();
    public const string TypedefKeywordId = "typedef";
    public const int TypedefKeywordIndex = 1029;

    public static readonly UnionKeywordToken UnionKeywordToken = new();
    public const string UnionKeywordId = "union";
    public const int UnionKeywordIndex = 1030;

    public static readonly UnsignedKeywordToken UnsignedKeywordToken = new();
    public const string UnsignedKeywordId = "unsigned";
    public const int UnsignedKeywordIndex = 1031;

    public static readonly VoidKeywordToken VoidKeywordToken = new();
    public const string VoidKeywordId = "void";
    public const int VoidKeywordIndex = 1032;

    public static readonly VolatileKeywordToken VolatileKeywordToken = new();
    public const string VolatileKeywordId = "volatile";
    public const int VolatileKeywordIndex = 1033;

    public static readonly WhileKeywordToken WhileKeywordToken = new();
    public const string WhileKeywordId = "while";
    public const int WhileKeywordIndex = 1034;

    public static readonly AlignasC11KeywordToken AlignasC11KeywordToken = new();
    public const string AlignasC11KeywordId = "_Alignas";
    public const int AlignasC11KeywordIndex = 1035;

    public static readonly AlignOfC11KeywordToken AlignOfC11KeywordToken = new();
    public const string AlignOfC11KeywordId = "_Alignof";
    public const int AlignOfC11KeywordIndex = 1036;

    public static readonly AtomicC11KeywordToken AtomicC11KeywordToken = new();
    public const string AtomicC11KeywordId = "_Atomic";
    public const int AtomicC11KeywordIndex = 1037;

    public static readonly BoolC99KeywordToken BoolC99KeywordToken = new();
    public const string BoolC99KeywordId = "_Bool";
    public const int BoolC99KeywordIndex = 1038;

    public static readonly ComplexC99KeywordToken ComplexC99KeywordToken = new();
    public const string ComplexC99KeywordId = "_Complex";
    public const int ComplexC99KeywordIndex = 1039;

    public static readonly GenericC11KeywordToken GenericC11KeywordToken = new();
    public const string GenericC11KeywordId = "_Generic";
    public const int GenericC11KeywordIndex = 1040;

    public static readonly ImaginaryC99KeywordToken ImaginaryC99KeywordToken = new();
    public const string ImaginaryC99KeywordId = "_Imaginary";
    public const int ImaginaryC99KeywordIndex = 1041;

    public static readonly NoreturnC11KeywordToken NoreturnC11KeywordToken = new();
    public const string NoreturnC11KeywordId = "_Noreturn";
    public const int NoreturnC11KeywordIndex = 1042;

    public static readonly StaticAssertC11KeywordToken StaticAssertC11KeywordToken = new();
    public const string StaticAssertC11KeywordId = "_Static_assert";
    public const int StaticAssertC11KeywordIndex = 1043;

    public static readonly ThreadLocalC11KeywordToken ThreadLocalC11KeywordToken = new();
    public const string ThreadLocalC11KeywordId = "_Thread_local";
    public const int ThreadLocalC11KeywordIndex = 1044;

    #endregion

    #region ObjectiveC

    public static readonly BridgeObjCArcKeywordToken BridgeObjCArcKeywordToken = new();
    public const string BridgeObjCArcKeywordId = "__bridge";
    public const int BridgeObjCArcKeywordIndex = 2001;

    public static readonly BridgeTransferObjCArcKeywordToken BridgeTransferObjCArcKeywordToken = new();
    public const string BridgeTransferObjCArcKeywordId = "__bridge_transfer";
    public const int BridgeTransferObjCArcKeywordIndex = 2002;

    public static readonly BridgeRetainedObjCArcKeywordToken BridgeRetainedObjCArcKeywordToken = new();
    public const string BridgeRetainedObjCArcKeywordId = "__bridge_retained";
    public const int BridgeRetainedObjCArcKeywordIndex = 2003;

    public static readonly BridgeRetainObjCArcKeywordToken BridgeRetainObjCArcKeywordToken = new();
    public const string BridgeRetainObjCArcKeywordId = "__bridge_retain";
    public const int BridgeRetainObjCArcKeywordIndex = 2004;

    public static readonly CovariantObjCKeywordToken CovariantObjCKeywordToken = new();
    public const string CovariantObjCKeywordId = "__covariant";
    public const int CovariantObjCKeywordIndex = 2005;

    public static readonly ContravariantObjCKeywordToken ContravariantObjCKeywordToken = new();
    public const string ContravariantObjCKeywordId = "__contravariant";
    public const int ContravariantObjCKeywordIndex = 2006;

    public static readonly KindOfObjCKeywordToken KindOfObjCKeywordToken = new();
    public const string KindOfObjCKeywordId = "__kindof";
    public const int KindOfObjCKeywordIndex = 2007;

    public static readonly NotAKeywordObjCKeywordToken NotAKeywordObjCKeywordToken = new();
    public const string NotAKeywordObjCKeywordId = "@not_keyword";
    public const int NotAKeywordObjCKeywordIndex = 3001;

    public static readonly ClassObjCKeywordToken ClassObjCKeywordToken = new();
    public const string ClassObjCKeywordId = "@class";
    public const int ClassObjCKeywordIndex = 3002;

    public static readonly CompatibilityAliasObjCKeywordToken CompatibilityAliasObjCKeywordToken = new();
    public const string CompatibilityAliasObjCKeywordId = "@compatibility_alias";
    public const int CompatibilityAliasObjCKeywordIndex = 3003;

    public static readonly DefsObjCKeywordToken DefsObjCKeywordToken = new();
    public const string DefsObjCKeywordId = "@defs";
    public const int DefsObjCKeywordIndex = 3004;

    public static readonly EncodeObjCKeywordToken EncodeObjCKeywordToken = new();
    public const string EncodeObjCKeywordId = "@encode";
    public const int EncodeObjCKeywordIndex = 3005;

    public static readonly EndObjCKeywordToken EndObjCKeywordToken = new();
    public const string EndObjCKeywordId = "@end";
    public const int EndObjCKeywordIndex = 3006;

    public static readonly ImplementationObjCKeywordToken ImplementationObjCKeywordToken = new();
    public const string ImplementationObjCKeywordId = "@implementation";
    public const int ImplementationObjCKeywordIndex = 3007;

    public static readonly InterfaceObjCKeywordToken InterfaceObjCKeywordToken = new();
    public const string InterfaceObjCKeywordId = "@interface";
    public const int InterfaceObjCKeywordIndex = 3008;

    public static readonly PrivateObjCKeywordToken PrivateObjCKeywordToken = new();
    public const string PrivateObjCKeywordId = "@private";
    public const int PrivateObjCKeywordIndex = 3009;

    public static readonly ProtectedObjCKeywordToken ProtectedObjCKeywordToken = new();
    public const string ProtectedObjCKeywordId = "@protected";
    public const int ProtectedObjCKeywordIndex = 3010;

    public static readonly ProtocolObjCKeywordToken ProtocolObjCKeywordToken = new();
    public const string ProtocolObjCKeywordId = "@protocol";
    public const int ProtocolObjCKeywordIndex = 3011;

    public static readonly PublicObjCKeywordToken PublicObjCKeywordToken = new();
    public const string PublicObjCKeywordId = "@public";
    public const int PublicObjCKeywordIndex = 3012;

    public static readonly SelectorObjCKeywordToken SelectorObjCKeywordToken = new();
    public const string SelectorObjCKeywordId = "@selector";
    public const int SelectorObjCKeywordIndex = 3013;

    public static readonly ThrowObjCKeywordToken ThrowObjCKeywordToken = new();
    public const string ThrowObjCKeywordId = "@throw";
    public const int ThrowObjCKeywordIndex = 3014;

    public static readonly TryObjCKeywordToken TryObjCKeywordToken = new();
    public const string TryObjCKeywordId = "@try";
    public const int TryObjCKeywordIndex = 3015;

    public static readonly CatchObjCKeywordToken CatchObjCKeywordToken = new();
    public const string CatchObjCKeywordId = "@catch";
    public const int CatchObjCKeywordIndex = 3016;

    public static readonly FinallyObjCKeywordToken FinallyObjCKeywordToken = new();
    public const string FinallyObjCKeywordId = "@finally";
    public const int FinallyObjCKeywordIndex = 3017;

    public static readonly SynchronizedObjCKeywordToken SynchronizedObjCKeywordToken = new();
    public const string SynchronizedObjCKeywordId = "@synchronized";
    public const int SynchronizedObjCKeywordIndex = 3018;

    public static readonly AutoReleasePoolObjCKeywordToken AutoReleasePoolObjCKeywordToken = new();
    public const string AutoReleasePoolObjCKeywordId = "@autoreleasepool";
    public const int AutoReleasePoolObjCKeywordIndex = 3019;

    public static readonly PropertyObjCKeywordToken PropertyObjCKeywordToken = new();
    public const string PropertyObjCKeywordId = "@property";
    public const int PropertyObjCKeywordIndex = 3020;

    public static readonly PackageObjCKeywordToken PackageObjCKeywordToken = new();
    public const string PackageObjCKeywordId = "@package";
    public const int PackageObjCKeywordIndex = 3021;

    public static readonly RequiredObjCKeywordToken RequiredObjCKeywordToken = new();
    public const string RequiredObjCKeywordId = "@required";
    public const int RequiredObjCKeywordIndex = 3022;

    public static readonly OptionalObjCKeywordToken OptionalObjCKeywordToken = new();
    public const string OptionalObjCKeywordId = "@optional";
    public const int OptionalObjCKeywordIndex = 3023;

    public static readonly SynthesizeObjCKeywordToken SynthesizeObjCKeywordToken = new();
    public const string SynthesizeObjCKeywordId = "@synthesize";
    public const int SynthesizeObjCKeywordIndex = 3024;

    public static readonly DynamicObjCKeywordToken DynamicObjCKeywordToken = new();
    public const string DynamicObjCKeywordId = "@dynamic";
    public const int DynamicObjCKeywordIndex = 3025;

    public static readonly ImportObjCKeywordToken ImportObjCKeywordToken = new();
    public const string ImportObjCKeywordId = "@import";
    public const int ImportObjCKeywordIndex = 3026;

    public static readonly AvailableObjCKeywordToken AvailableObjCKeywordToken = new();
    public const string AvailableObjCKeywordId = "@available";
    public const int AvailableObjCKeywordIndex = 3027;

    #endregion

    #endregion
}
