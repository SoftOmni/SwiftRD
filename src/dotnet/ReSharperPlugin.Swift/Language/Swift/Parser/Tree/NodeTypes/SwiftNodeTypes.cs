using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Declarations;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Errors;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ExpressionsAndTypes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Literals;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Markers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Operators.BuiltinOperators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Operators.UserDefinedOperators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Patterns;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Reserved;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Statements;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.WhitespaceAndComments;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

public static class SwiftNodeTypes
{
    #region LeafNodes
    
    #region Markers
    
    public const string InternalNodeId = "INTERNAL_NODE";
    public const int InternalNodeIndex = 110;
    public static readonly InternalKeywordToken InternalNode = SwiftTokens.InternalKeywordToken;
    
    public static readonly StartOfFileToken StartOfFile = new();
    public static readonly EndOfFileToken EndOfFile = new();
    public static readonly EmptyToken Empty = new();
    
    #endregion // Markers

    #region WhitespaceAndComments

    public static readonly NewLineToken NewLine = new();
    public static readonly WhitespaceToken Whitespace = new();
    public static readonly LineCommentToken LineComment = new();
    public static readonly BlockCommentStartToken BlockCommentStart = new();
    public static readonly BlockCommentEndToken BlockCommentEnd = new();
    public static readonly BlockCommentContentToken BlockCommentContent = new();

    #endregion // WhitespaceAndComments

    #region Identifiers
    
    public static readonly IdentifierToken Identifier = new();
    
    #endregion // Identifiers

    #region Literals
    
    public static readonly IntegerLiteralToken IntegerLiteral = new();
    public static readonly FloatingPointLiteralToken FloatingPointLiteral = new();

    #region StringLiterals

    public static readonly StringInterpolationStartToken StringInterpolationStart = SwiftTokens.StringInterpolationStartToken;
    public static readonly StringInterpolationEndToken StringInterpolationEnd = SwiftTokens.StringInterpolationEndToken;
    public static readonly StringEscapeSequenceToken StringEscapeSequence = SwiftTokens.StringEscapeSequenceToken;
    public static readonly StringLiteralStartToken StringLiteralStart = SwiftTokens.StringLiteralStartToken;
    public static readonly StringLiteralEndToken StringLiteralEnd = SwiftTokens.StringLiteralEndToken;
    public static readonly StringLiteralContentToken StringLiteralContent = SwiftTokens.StringLiteralContentToken;
    public static readonly SurroundedStringLiteralStartToken RawValueStringLiteralStart = SwiftTokens.SurroundedStringLiteralStartToken;
    public static readonly SurroundedStringLiteralEndToken SurroundedStringLiteralEnd = SwiftTokens.SurroundedStringLiteralEndToken;
    public static readonly SurroundedStringLiteralContentToken RawValueStringLiteralContent = SwiftTokens.SurroundedStringLiteralContentToken;
    public static readonly MultiLineStringLiteralStartToken MultiLineStringLiteralStart = SwiftTokens.MultiLineStringLiteralStartToken;
    public static readonly MultiLineStringLiteralEndToken MultiLineStringLiteralEnd = SwiftTokens.MultiLineStringLiteralEndToken;
    public static readonly MultiLineStringLiteralContentToken MultiLineStringLiteralContent = SwiftTokens.MultiLineStringLiteralContentToken;
    public static readonly SurroundedMultiLineStringLiteralStartToken SurroundedMultiLineStringLiteralStart = SwiftTokens.SurroundedMultiLineStringLiteralStartToken;
    public static readonly SurroundedMultiLineStringLiteralEndToken RawValueMultiLineStringLiteralEnd = SwiftTokens.SurroundedMultiLineStringLiteralEndToken;
    public static readonly SurroundedMultiLineStringLiteralContentToken SurroundedMultiLineStringLiteralContent = SwiftTokens.SurroundedMultiLineStringLiteralContentToken;
    
    #endregion //StringLiterals
    
    public static readonly RegularExpressionLiteralToken RegularExpressionLiteral = new();
    
    #endregion // Literals

    #region Punctuators

    public static readonly LeftParenthesisToken LeftParenthesis = SwiftTokens.LeftParenthesisToken;
    public static readonly RightParenthesisToken RightParenthesis = SwiftTokens.RightParenthesisToken;
    public static readonly LeftCurlyBraceToken LeftCurlyBrace = SwiftTokens.LeftCurlyBraceToken;
    public static readonly RightCurlyBraceToken RightCurlyBrace = SwiftTokens.RightCurlyBraceToken;
    public static readonly LeftSquareBracketToken LeftSquareBracket = SwiftTokens.LeftSquareBracketToken;
    public static readonly RightSquareBracketToken RightSquareBracket = SwiftTokens.RightSquareBracketToken;
    public static readonly LeftAngleBracketToken LeftAngleBracket = SwiftTokens.LeftAngleBracketToken;
    public static readonly RightAngleBracketToken RightAngleBracket = SwiftTokens.RightAngleBracketToken;
    public static readonly PeriodToken Period = SwiftTokens.PeriodToken;
    public static readonly CommaToken Comma = SwiftTokens.CommaToken;
    public static readonly ColonToken Colon = SwiftTokens.ColonToken;
    public static readonly SemicolonToken Semicolon = SwiftTokens.SemicolonToken;
    public static readonly EqualsToken Equal = SwiftTokens.EqualsToken;
    public static readonly AtToken At = SwiftTokens.AtToken;
    public static readonly HashToken Hash = SwiftTokens.HashToken;
    public static readonly AmpersandToken Ampersand = SwiftTokens.AmpersandToken;
    public static readonly ArrowToken Arrow = SwiftTokens.ArrowToken;
    public static readonly BacktickToken Backtick = SwiftTokens.BacktickToken;
    public static readonly QuestionMarkToken QuestionMark = SwiftTokens.QuestionMarkToken;
    public static readonly ExclamationMarkToken ExclamationMark = SwiftTokens.ExclamationMarkToken;

    #endregion // Punctuators
    

    // Keywords - UsableInDeclarations
    public static readonly AssociatedTypeKeywordToken AssociatedType = SwiftTokens.AssociatedTypeKeywordToken;
    public static readonly ActorKeywordToken Actor = SwiftTokens.ActorKeywordToken;
    public static readonly BorrowingKeywordToken Borrowing = SwiftTokens.BorrowingKeywordToken;
    public static readonly ClassKeywordToken Class = SwiftTokens.ClassKeywordToken;
    public static readonly ConsumingKeywordToken Consuming = SwiftTokens.ConsumingKeywordToken;
    public static readonly DeinitKeywordToken Deinit = SwiftTokens.DeinitKeywordToken;
    public static readonly EnumKeywordToken Enum = SwiftTokens.EnumKeywordToken;
    public static readonly ExtensionKeywordToken Extension = SwiftTokens.ExtensionKeywordToken;
    public static readonly FilePrivateKeywordToken FilePrivate = SwiftTokens.FilePrivateKeywordToken;
    public static readonly FuncKeywordToken Func = SwiftTokens.FuncKeywordToken;
    public static readonly ImportKeywordToken Import = SwiftTokens.ImportKeywordToken;
    public static readonly InitKeywordToken Init = SwiftTokens.InitKeywordToken;
    public static readonly InoutKeywordToken Inout = SwiftTokens.InoutKeywordToken;
    public static readonly InternalKeywordToken Internal = SwiftTokens.InternalKeywordToken;
    public static readonly LetKeywordToken Let = SwiftTokens.LetKeywordToken;
    public static readonly NonIsolatedKeywordToken NonIsolated = SwiftTokens.NonIsolatedKeywordToken;
    public static readonly OpenKeywordToken Open = SwiftTokens.OpenKeywordToken;
    public static readonly OperatorKeywordToken Operator = SwiftTokens.OperatorKeywordToken;
    public static readonly PrecedenceGroupKeywordToken PrecedenceGroup = SwiftTokens.PrecedenceGroupKeywordToken;
    public static readonly PrivateKeywordToken Private = SwiftTokens.PrivateKeywordToken;
    public static readonly ProtocolLowercaseKeywordToken ProtocolLowercase = SwiftTokens.ProtocolLowercaseKeywordToken;
    public static readonly PublicKeywordToken Public = SwiftTokens.PublicKeywordToken;
    public static readonly RethrowsKeywordToken Rethrows = SwiftTokens.RethrowsKeywordToken;
    public static readonly StaticKeywordToken Static = SwiftTokens.StaticKeywordToken;
    public static readonly StructKeywordToken Struct = SwiftTokens.StructKeywordToken;
    public static readonly SubscriptKeywordToken Subscript = SwiftTokens.SubscriptKeywordToken;
    public static readonly TypealiasKeywordToken Typealias = SwiftTokens.TypealiasKeywordToken;
    public static readonly VarKeywordToken Var = SwiftTokens.VarKeywordToken;
    public static readonly SafeKeywordToken Safe = SwiftTokens.SafeKeywordToken;
    public static readonly UnsafeKeywordToken Unsafe = SwiftTokens.UnsafeKeywordToken;
    public static readonly MacroKeywordToken Macro = SwiftTokens.MacroKeywordToken;/*
    public static readonly LowerThanKeywordToken LowerThan = SwiftTokens.LowerThanKeywordToken;
    public static readonly HigherThanKeywordToken HigherThan = SwiftTokens.HigherThanKeywordToken;
    public static readonly AssignmentKeywordToken Assignment = SwiftTokens.AssignmentKeywordToken;*/
    
    

    // Keywords - UsableInStatements
    public static readonly BreakKeywordToken Break = SwiftTokens.BreakKeywordToken;
    public static readonly CaseKeywordToken Case = SwiftTokens.CaseKeywordToken;
    public static readonly CatchKeywordToken Catch = SwiftTokens.CatchKeywordToken;
    public static readonly ContinueKeywordToken Continue = SwiftTokens.ContinueKeywordToken;
    public static readonly DefaultKeywordToken Default = SwiftTokens.DefaultKeywordToken;
    public static readonly DeferKeywordToken Defer = SwiftTokens.DeferKeywordToken;
    public static readonly DoKeywordToken Do = SwiftTokens.DoKeywordToken;
    public static readonly ElseKeywordToken Else = SwiftTokens.ElseKeywordToken;
    public static readonly FallthroughKeywordToken Fallthrough = SwiftTokens.FallthroughKeywordToken;
    public static readonly ForKeywordToken For = SwiftTokens.ForKeywordToken;
    public static readonly GuardKeywordToken Guard = SwiftTokens.GuardKeywordToken;
    public static readonly IfKeywordToken If = SwiftTokens.IfKeywordToken;
    public static readonly InKeywordToken In = SwiftTokens.InKeywordToken;
    public static readonly RepeatKeywordToken Repeat = SwiftTokens.RepeatKeywordToken;
    public static readonly ReturnKeywordToken Return = SwiftTokens.ReturnKeywordToken;
    public static readonly SwitchKeywordToken Switch = SwiftTokens.SwitchKeywordToken;
    public static readonly ThrowKeywordToken Throw = SwiftTokens.ThrowKeywordToken;
    public static readonly WhereKeywordToken Where = SwiftTokens.WhereKeywordToken;
    public static readonly WhileKeywordToken While = SwiftTokens.WhileKeywordToken;

    // Keywords - UsableInExpressionsAndTypes
    public static readonly AnyLowercaseKeywordToken AnyLowercase = SwiftTokens.AnyLowercaseKeywordToken;
    public static readonly AnyUppercaseKeywordToken AnyUppercase = SwiftTokens.AnyUppercaseKeywordToken;
    public static readonly AsKeywordToken As = SwiftTokens.AsKeywordToken;
    public static readonly AwaitKeywordToken Await = SwiftTokens.AwaitKeywordToken;
    public static readonly FalseLiteralToken False = SwiftTokens.FalseLiteralToken;
    public static readonly IsKeywordToken Is = SwiftTokens.IsKeywordToken;
    public static readonly NilLiteralToken Nil = SwiftTokens.NilLiteralToken;
    public static readonly SelfLowercaseKeywordToken SelfLowercase = SwiftTokens.SelfLowercaseKeywordToken;
    public static readonly SelfUppercaseKeywordToken SelfUppercase = SwiftTokens.SelfUppercaseKeywordToken;
    public static readonly SuperKeywordToken Super = SwiftTokens.SuperKeywordToken;
    public static readonly ThrowsKeywordToken Throws = SwiftTokens.ThrowsKeywordToken;
    public static readonly TrueLiteralToken True = SwiftTokens.TrueLiteralToken;
    public static readonly TryKeywordToken Try = SwiftTokens.TryKeywordToken;

    // Keywords - UsableInPatterns
    public static readonly UnderscoreTokenKeyword Underscore = SwiftTokens.UnderscoreKeywordToken;

    // Reserved identifiers
    public static readonly ReservedAvailableKeywordToken ReservedAvailable = SwiftTokens.ReservedAvailableKeywordToken;
    public static readonly ReservedColorLiteralKeywordToken ReservedColorLiteral = SwiftTokens.ReservedColorLiteralKeywordToken;
    public static readonly ReservedElseKeywordToken ReservedElse = SwiftTokens.ReservedElseKeywordToken;
    public static readonly ReservedElseIfKeywordToken ReservedElseIf = SwiftTokens.ReservedElseIfKeywordToken;
    public static readonly ReservedEndIfKeywordToken ReservedEndIf = SwiftTokens.ReservedEndIfKeywordToken;
    public static readonly ReservedFileLiteralKeywordToken ReservedFileLiteral = SwiftTokens.ReservedFileLiteralKeywordToken;
    public static readonly ReservedIfKeywordToken ReservedIf = SwiftTokens.ReservedIfKeywordToken;
    public static readonly ReservedImageLiteralKeywordToken ReservedImageLiteral = SwiftTokens.ReservedImageLiteralKeywordToken;
    public static readonly ReservedKeyPathKeywordToken ReservedKeyPath = SwiftTokens.ReservedKeyPathKeywordToken;
    public static readonly ReservedSelectorKeywordToken ReservedSelector = SwiftTokens.ReservedSelectorKeywordToken;
    public static readonly ReservedSourceLocationKeywordToken ReservedSourceLocation = SwiftTokens.ReservedSourceLocationKeywordToken;
    public static readonly ReservedUnavailableKeywordToken ReservedUnavailable = SwiftTokens.ReservedUnavailableKeywordToken;

    // Previously reserved identifiers
    public static readonly PreviouslyReservedColumnKeywordToken PreviouslyReservedColumn = SwiftTokens.PreviouslyReservedColumnKeywordToken;
    public static readonly PreviouslyReservedDsoHandleKeywordToken PreviouslyReservedDsoHandle = SwiftTokens.PreviouslyReservedDsoHandleKeywordToken;
    public static readonly PreviouslyReservedErrorKeywordToken PreviouslyReservedError = SwiftTokens.PreviouslyReservedErrorKeywordToken;
    public static readonly PreviouslyReservedFileIdKeywordToken PreviouslyReservedFileId = SwiftTokens.PreviouslyReservedFileIdKeywordToken;
    public static readonly PreviouslyReservedFilePathKeywordToken PreviouslyReservedFilePath = SwiftTokens.PreviouslyReservedFilePathKeywordToken;
    public static readonly PreviouslyReservedFileKeywordToken PreviouslyReservedFile = SwiftTokens.PreviouslyReservedFileKeywordToken;
    public static readonly PreviouslyReservedFunctionKeywordToken PreviouslyReservedFunction = SwiftTokens.PreviouslyReservedFunctionKeywordToken;
    public static readonly PreviouslyReservedLineKeywordToken PreviouslyReservedLine = SwiftTokens.PreviouslyReservedLineKeywordToken;
    public static readonly PreviouslyReservedWarningKeywordToken PreviouslyReservedWarning = SwiftTokens.PreviouslyReservedWarningKeywordToken;

    // Context sensitive keywords
    public static readonly AssociativityKeywordToken Associativity = SwiftTokens.AssociativityKeywordToken;
    public static readonly AsyncKeywordToken Async = SwiftTokens.AsyncKeywordToken;
    public static readonly ConvenienceKeywordToken Convenience = SwiftTokens.ConvenienceKeywordToken;
    public static readonly DidSetKeywordToken DidSet = SwiftTokens.DidSetKeywordToken;
    public static readonly DynamicKeywordToken Dynamic = SwiftTokens.DynamicKeywordToken;
    public static readonly FinalKeywordToken Final = SwiftTokens.FinalKeywordToken;
    public static readonly GetKeywordToken Get = SwiftTokens.GetKeywordToken;
    public static readonly IndirectKeywordToken Indirect = SwiftTokens.IndirectKeywordToken;
    public static readonly InfixKeywordToken Infix = SwiftTokens.InfixKeywordToken;
    public static readonly LazyKeywordToken Lazy = SwiftTokens.LazyKeywordToken;
    public static readonly LeftKeywordToken Left = SwiftTokens.LeftKeywordToken;
    public static readonly MutatingKeywordToken Mutating = SwiftTokens.MutatingKeywordToken;
    public static readonly NoneKeywordToken None = SwiftTokens.NoneKeywordToken;
    public static readonly NonMutatingKeywordToken NonMutating = SwiftTokens.NonMutatingKeywordToken;
    public static readonly OptionalKeywordToken Optional = SwiftTokens.OptionalKeywordToken;
    public static readonly OverrideKeywordToken Override = SwiftTokens.OverrideKeywordToken;
    public static readonly PackageKeywordToken Package = SwiftTokens.PackageKeywordToken;
    public static readonly PostfixKeywordToken Postfix = SwiftTokens.PostfixKeywordToken;
    public static readonly PrecedenceKeywordToken Precedence = SwiftTokens.PrecedenceKeywordToken;
    public static readonly PrefixKeywordToken Prefix = SwiftTokens.PrefixKeywordToken;
    public static readonly ProtocolUppercaseKeywordToken ProtocolUppercase = SwiftTokens.ProtocolUppercaseKeywordToken;
    public static readonly RequiredKeywordToken Required = SwiftTokens.RequiredKeywordToken;
    public static readonly RightKeywordToken Right = SwiftTokens.RightKeywordToken;
    public static readonly SetKeywordToken Set = SwiftTokens.SetKeywordToken;
    public static readonly SomeKeywordToken Some = SwiftTokens.SomeKeywordToken;
    public static readonly TypeKeywordToken Type = SwiftTokens.TypeKeywordToken;
    public static readonly UnownedKeywordToken Unowned = SwiftTokens.UnownedKeywordToken;
    public static readonly WeakKeywordToken Weak = SwiftTokens.WeakKeywordToken;
    public static readonly WillSetKeywordToken WillSet = SwiftTokens.WillSetKeywordToken;

    // Operators
    public static readonly InfixOperatorToken InfixOperator = SwiftTokens.InfixOperatorToken;
    public static readonly PrefixOperatorToken PrefixOperator = SwiftTokens.PrefixOperatorToken;
    public static readonly PostfixOperatorToken PostfixOperator = SwiftTokens.PostfixOperatorToken;
    public static readonly TernaryOperatorToken TernaryOperator = SwiftTokens.TernaryOperatorToken;
    public static readonly OptionalChainingOperatorToken OptionalChainingOperator = SwiftTokens.OptionalChainingOperatorToken;
    public static readonly QuestionMarkPrefixOperatorToken QuestionMarkPrefixOperator = SwiftTokens.QuestionMarkPrefixOperatorToken;
    public static readonly QuestionMarkPostfixOperatorToken QuestionMarkPostfixOperator = SwiftTokens.QuestionMarkPostfixOperatorToken;
    public static readonly ExclamationMarkPrefixOperatorToken ExclamationMarkPrefixOperator = SwiftTokens.ExclamationMarkPrefixOperatorToken;
    public static readonly ExclamationMarkPostfixOperatorToken ExclamationMarkPostfixOperator = SwiftTokens.ExclamationMarkPostfixOperatorToken;

    // Errors
    public static readonly InvalidToken InvalidToken = SwiftTokens.InvalidToken;
    public static readonly UnmatchedOperatorToken UnmatchedOperator = SwiftTokens.UnmatchedOperatorToken;
    public static readonly ErroneousIntegerLiteralToken ErroneousIntegerLiteral = SwiftTokens.ErroneousIntegerLiteralToken;
    public static readonly ErroneousFloatingPointLiteralToken ErroneousFloatingPointLiteral = SwiftTokens.ErroneousFloatingPointLiteralToken;
    public static readonly UnmatchedHashtagToken UnmatchedHashtag = SwiftTokens.UnmatchedHashtagToken;
    public static readonly ErroneousStringLiteralToken ErroneousStringLiteral = SwiftTokens.ErroneousStringLiteralToken;
    public static readonly UnmatchedEscapeSequenceToken UnmatchedEscapeSequence = SwiftTokens.UnmatchedEscapeSequenceToken;
    
    #endregion

    #region InternalNodes

    

    #endregion
}