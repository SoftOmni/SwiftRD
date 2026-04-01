using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes.Keywords.Declarations;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes.Keywords.Statements.LoopStatements;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes.Literals;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes.Markers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes.WhitespaceAndComments;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

public static class SwiftNodeTypes
{
    #region Markers
    
    public const string InternalNodeId = "INTERNAL_NODE";
    public const int InternalNodeIndex = 110;
    public static readonly InternalNodeType InternalNode = new();
    
    public static readonly StartOfFileNodeType StartOfFile = new();
    public static readonly EndOfFileNodeType EndOfFile = new();
    public static readonly EmptyNodeType Empty = new();
    
    #endregion // Markers

    #region WhitespaceAndComments

    public static readonly NewLineNodeType NewLine = new();
    public static readonly WhitespaceNodeType Whitespace = new();
    public static readonly LineCommentNodeType LineComment = new();
    public static readonly BlockCommentStartNodeType BlockCommentStart = new();
    public static readonly BlockCommentEndNodeType BlockCommentEnd = new();
    public static readonly BlockCommentContentNodeType BlockCommentContent = new();

    #endregion // WhitespaceAndComments

    #region Identifiers
    
    public static readonly IdentifierNodeType Identifier = new();
    
    #endregion // Identifiers

    #region Literals
    
    public static readonly IntegerLiteralNodeType IntegerLiteral = new();
    public static readonly FloatingPointLiteralNodeType FloatingPointLiteral = new();

    #region StringLiterals

    public static readonly PlaceholderNodeType StringInterpolationStart = new(SwiftTokens.StringInterpolationStartId, SwiftTokens.StringInterpolationStartIndex, isStringLiteral: true);
    public static readonly PlaceholderNodeType StringInterpolationEnd = new(SwiftTokens.StringInterpolationEndId, SwiftTokens.StringInterpolationEndIndex, isStringLiteral: true);
    public static readonly PlaceholderNodeType StringEscapeSequence = new(SwiftTokens.StringEscapeSequenceId, SwiftTokens.StringEscapeSequenceIndex, isStringLiteral: true);
    public static readonly PlaceholderNodeType StringLiteralStart = new(SwiftTokens.StringLiteralStartId, SwiftTokens.StringLiteralStartIndex, isStringLiteral: true);
    public static readonly PlaceholderNodeType StringLiteralEnd = new(SwiftTokens.StringLiteralEndId, SwiftTokens.StringLiteralEndIndex, isStringLiteral: true);
    public static readonly PlaceholderNodeType StringLiteralContent = new(SwiftTokens.StringLiteralContentId, SwiftTokens.StringLiteralContentIndex, isStringLiteral: true);
    public static readonly PlaceholderNodeType SurroundedStringLiteralStart = new(SwiftTokens.SurroundedStringLiteralStartId, SwiftTokens.SurroundedStringLiteralStartIndex, isStringLiteral: true);
    public static readonly PlaceholderNodeType SurroundedStringLiteralEnd = new(SwiftTokens.SurroundedStringLiteralEndId, SwiftTokens.SurroundedStringLiteralEndIndex, isStringLiteral: true);
    public static readonly PlaceholderNodeType SurroundedStringLiteralContent = new(SwiftTokens.SurroundedStringLiteralContentId, SwiftTokens.SurroundedStringLiteralContentIndex, isStringLiteral: true);
    public static readonly PlaceholderNodeType MultiLineStringLiteralStart = new(SwiftTokens.MultiLineStringLiteralStartId, SwiftTokens.MultiLineStringLiteralStartIndex, isStringLiteral: true);
    public static readonly PlaceholderNodeType MultiLineStringLiteralEnd = new(SwiftTokens.MultiLineStringLiteralEndId, SwiftTokens.MultiLineStringLiteralEndIndex, isStringLiteral: true);
    public static readonly PlaceholderNodeType MultiLineStringLiteralContent = new(SwiftTokens.MultiLineStringLiteralContentId, SwiftTokens.MultiLineStringLiteralContentIndex, isStringLiteral: true);
    public static readonly PlaceholderNodeType SurroundedMultiLineStringLiteralStart = new(SwiftTokens.SurroundedMultiLineStringLiteralStartId, SwiftTokens.SurroundedMultiLineStringLiteralStartIndex, isStringLiteral: true);
    public static readonly PlaceholderNodeType SurroundedMultiLineStringLiteralEnd = new(SwiftTokens.SurroundedMultiLineStringLiteralEndId, SwiftTokens.SurroundedMultiLineStringLiteralEndIndex, isStringLiteral: true);
    public static readonly PlaceholderNodeType SurroundedMultiLineStringLiteralContent = new(SwiftTokens.MultiLineSurroundedStringLiteralContentId, SwiftTokens.MultiLineSurroundedStringLiteralContentIndex, isStringLiteral: true);
    
    #endregion //StringLiterals
    
    public static readonly RegularExpressionLiteralNodeType RegularExpressionLiteral = new();
    
    #endregion // Literals

    #region Punctuators

    public static readonly LeftParenthesisNodeType LeftParenthesis = new();
    public static readonly RightParenthesisNodeType RightParenthesis = new();
    public static readonly LeftCurlyBraceNodeType LeftCurlyBrace = new();
    public static readonly RightSquareBracketNodeType RightCurlyBrace = new();
    public static readonly LeftSquareBracketNodeType LeftSquareBracket = new();
    public static readonly RightSquareBracketNodeType RightSquareBracket = new();
    public static readonly LeftAngleNodeType LeftAngleBracket = new();
    public static readonly RightAngleNodeType RightAngleBracket = new();
    public static readonly PeriodNodeType Period = new();
    public static readonly CommaNodeType Comma = new();
    public static readonly ColonNodeType Colon = new();
    public static readonly SemicolonNodeType Semicolon = new();
    public static readonly EqualNodeType Equal = new();
    public static readonly AtNodeType At = new();
    public static readonly HashNodeType Hash = new();
    public static readonly AmpersandNodeType Ampersand = new();
    public static readonly ArrowNodeType Arrow = new();
    public static readonly BacktickNodeType Backtick = new();
    public static readonly QuestionMarkNodeType QuestionMark = new();
    public static readonly ExclamationMarkNodeType ExclamationMark = new();

    #endregion // Punctuators
    

    // Keywords - UsableInDeclarations
    public static readonly AssociatedTypeNodeType AssociatedType = new();
    public static readonly ActorNodeType Actor = new();
    public static readonly BorrowingNodeType Borrowing = new();
    public static readonly ClassNodeType Class = new();
    public static readonly ConsumingNodeType Consuming = new();
    public static readonly DeinitNodeType Deinit = new();
    public static readonly EnumNodeType Enum = new();
    public static readonly ExtensionNodeType Extension = new();
    public static readonly FilePrivateNodeType FilePrivate = new();
    public static readonly FuncNodeType Func = new();
    public static readonly ImportNodeType Import = new();
    public static readonly InitNodeType Init = new();
    public static readonly InoutNodeType Inout = new();
    public static readonly InternalNodeType Internal = new();
    public static readonly PlaceholderNodeType Let = new(SwiftTokens.LetId, SwiftTokens.LetIndex, isKeyword: true);
    public static readonly PlaceholderNodeType NonIsolated = new(SwiftTokens.NonIsolatedId, SwiftTokens.NonIsolatedIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Open = new(SwiftTokens.OpenId, SwiftTokens.OpenIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Operator = new(SwiftTokens.OperatorId, SwiftTokens.OperatorIndex, isKeyword: true);
    public static readonly PlaceholderNodeType PrecedenceGroup = new(SwiftTokens.PrecedenceGroupId, SwiftTokens.PrecedenceGroupIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Private = new(SwiftTokens.PrivateId, SwiftTokens.PrivateIndex, isKeyword: true);
    public static readonly PlaceholderNodeType ProtocolLowercase = new(SwiftTokens.ProtocolLowercaseId, SwiftTokens.ProtocolLowercaseIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Public = new(SwiftTokens.PublicId, SwiftTokens.PublicIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Rethrows = new(SwiftTokens.RethrowsId, SwiftTokens.RethrowsIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Static = new(SwiftTokens.StaticId, SwiftTokens.StaticIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Struct = new(SwiftTokens.StructId, SwiftTokens.StructIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Subscript = new(SwiftTokens.SubscriptId, SwiftTokens.SubscriptIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Typealias = new(SwiftTokens.TypealiasId, SwiftTokens.TypealiasIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Var = new(SwiftTokens.VarId, SwiftTokens.VarIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Safe = new(SwiftTokens.SafeId, SwiftTokens.SafeIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Unsafe = new(SwiftTokens.UnsafeId, SwiftTokens.UnsafeIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Macro = new(SwiftTokens.MacroId, SwiftTokens.MacroIndex, isKeyword: true);
    public static readonly PlaceholderNodeType LowerThan = new(SwiftTokens.MacroId, SwiftTokens.MacroIndex, isKeyword: true);
    public static readonly PlaceholderNodeType HigherThan = new(SwiftTokens.MacroId, SwiftTokens.MacroIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Assignment = new(SwiftTokens.MacroId, SwiftTokens.MacroIndex, isKeyword: true);
    
    

    // Keywords - UsableInStatements
    public static readonly BreakNodeType Break = new();
    public static readonly PlaceholderNodeType Case = new(SwiftTokens.CaseId, SwiftTokens.CaseIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Catch = new(SwiftTokens.CatchId, SwiftTokens.CatchIndex, isKeyword: true);
    public static readonly ContinueNodeType Continue = new();
    public static readonly PlaceholderNodeType Default = new(SwiftTokens.DefaultId, SwiftTokens.DefaultIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Defer = new(SwiftTokens.DeferId, SwiftTokens.DeferIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Do = new(SwiftTokens.DoId, SwiftTokens.DoIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Else = new(SwiftTokens.ElseId, SwiftTokens.ElseIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Fallthrough = new(SwiftTokens.FallthroughId, SwiftTokens.FallthroughIndex, isKeyword: true);
    public static readonly PlaceholderNodeType For = new(SwiftTokens.ForId, SwiftTokens.ForIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Guard = new(SwiftTokens.GuardId, SwiftTokens.GuardIndex, isKeyword: true);
    public static readonly PlaceholderNodeType If = new(SwiftTokens.IfId, SwiftTokens.IfIndex, isKeyword: true);
    public static readonly PlaceholderNodeType In = new(SwiftTokens.InId, SwiftTokens.InIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Repeat = new(SwiftTokens.RepeatId, SwiftTokens.RepeatIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Return = new(SwiftTokens.ReturnId, SwiftTokens.ReturnIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Switch = new(SwiftTokens.SwitchId, SwiftTokens.SwitchIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Throw = new(SwiftTokens.ThrowId, SwiftTokens.ThrowIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Where = new(SwiftTokens.WhereId, SwiftTokens.WhereIndex, isKeyword: true);
    public static readonly PlaceholderNodeType While = new(SwiftTokens.WhileId, SwiftTokens.WhileIndex, isKeyword: true);

    // Keywords - UsableInExpressionsAndTypes
    public static readonly PlaceholderNodeType AnyLowercase = new(SwiftTokens.AnyId, SwiftTokens.AnyIndex, isKeyword: true);
    public static readonly PlaceholderNodeType AnyUppercase = new(SwiftTokens.AnyId, SwiftTokens.AnyIndex, isKeyword: true);
    public static readonly PlaceholderNodeType As = new(SwiftTokens.AsId, SwiftTokens.AsIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Await = new(SwiftTokens.AwaitId, SwiftTokens.AwaitIndex, isKeyword: true);
    public static readonly PlaceholderNodeType False = new(SwiftTokens.FalseId, SwiftTokens.FalseIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Is = new(SwiftTokens.IsId, SwiftTokens.IsIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Nil = new(SwiftTokens.NilId, SwiftTokens.NilIndex, isKeyword: true);
    public static readonly PlaceholderNodeType SelfLowercase = new(SwiftTokens.SelfLowercaseId, SwiftTokens.SelfLowercaseIndex, isKeyword: true);
    public static readonly PlaceholderNodeType SelfUppercase = new(SwiftTokens.SelfUppercaseId, SwiftTokens.SelfUppercaseIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Super = new(SwiftTokens.SuperId, SwiftTokens.SuperIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Throws = new(SwiftTokens.ThrowsId, SwiftTokens.ThrowsIndex, isKeyword: true);
    public static readonly PlaceholderNodeType True = new(SwiftTokens.TrueId, SwiftTokens.TrueIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Try = new(SwiftTokens.TryId, SwiftTokens.TryIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Red = new(SwiftTokens.TryId, SwiftTokens.TryIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Green = new(SwiftTokens.TryId, SwiftTokens.TryIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Blue = new(SwiftTokens.TryId, SwiftTokens.TryIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Alpha = new(SwiftTokens.TryId, SwiftTokens.TryIndex, isKeyword: true);

    // Keywords - UsableInPatterns
    public static readonly PlaceholderNodeType Underscore = new(SwiftTokens.UnderscoreId, SwiftTokens.UnderscoreIndex, isKeyword: true);

    // Reserved identifiers
    public static readonly PlaceholderNodeType ReservedAvailable = new(SwiftTokens.ReservedAvailableId, SwiftTokens.ReservedAvailableIndex, isKeyword: true);
    public static readonly PlaceholderNodeType ReservedColorLiteral = new(SwiftTokens.ReservedColorLiteralId, SwiftTokens.ReservedColorLiteralIndex, isKeyword: true);
    public static readonly PlaceholderNodeType ReservedElse = new(SwiftTokens.ReservedElseId, SwiftTokens.ReservedElseIndex, isKeyword: true);
    public static readonly PlaceholderNodeType ReservedElseIf = new(SwiftTokens.ReservedElseIfId, SwiftTokens.ReservedElseIfIndex, isKeyword: true);
    public static readonly PlaceholderNodeType ReservedEndIf = new(SwiftTokens.ReservedEndIfId, SwiftTokens.ReservedEndIfIndex, isKeyword: true);
    public static readonly PlaceholderNodeType ReservedFileLiteral = new(SwiftTokens.ReservedFileLiteralId, SwiftTokens.ReservedFileLiteralIndex, isKeyword: true);
    public static readonly PlaceholderNodeType ReservedIf = new(SwiftTokens.ReservedIfId, SwiftTokens.ReservedIfIndex, isKeyword: true);
    public static readonly PlaceholderNodeType ReservedImageLiteral = new(SwiftTokens.ReservedImageLiteralId, SwiftTokens.ReservedImageLiteralIndex, isKeyword: true);
    public static readonly PlaceholderNodeType ReservedKeyPath = new(SwiftTokens.ReservedKeyPathId, SwiftTokens.ReservedKeyPathIndex, isKeyword: true);
    public static readonly PlaceholderNodeType ReservedSelector = new(SwiftTokens.ReservedSelectorId, SwiftTokens.ReservedSelectorIndex, isKeyword: true);
    public static readonly PlaceholderNodeType ReservedSourceLocation = new(SwiftTokens.ReservedSourceLocationId, SwiftTokens.ReservedSourceLocationIndex, isKeyword: true);
    public static readonly PlaceholderNodeType ReservedUnavailable = new(SwiftTokens.ReservedUnavailableId, SwiftTokens.ReservedUnavailableIndex, isKeyword: true);

    // Previously reserved identifiers
    public static readonly PlaceholderNodeType PreviouslyReservedColumn = new(SwiftTokens.PreviouslyReservedColumnId, SwiftTokens.PreviouslyReservedColumnIndex, isKeyword: true);
    public static readonly PlaceholderNodeType PreviouslyReservedDsoHandle = new(SwiftTokens.PreviouslyReservedDsoHandleId, SwiftTokens.PreviouslyReservedDsoHandleIndex, isKeyword: true);
    public static readonly PlaceholderNodeType PreviouslyReservedError = new(SwiftTokens.PreviouslyReservedErrorId, SwiftTokens.PreviouslyReservedErrorIndex, isKeyword: true);
    public static readonly PlaceholderNodeType PreviouslyReservedFileId = new(SwiftTokens.PreviouslyReservedFileIdId, SwiftTokens.PreviouslyReservedFileIdIndex, isKeyword: true);
    public static readonly PlaceholderNodeType PreviouslyReservedFilePath = new(SwiftTokens.PreviouslyReservedFilePathId, SwiftTokens.PreviouslyReservedFilePathIndex, isKeyword: true);
    public static readonly PlaceholderNodeType PreviouslyReservedFile = new(SwiftTokens.PreviouslyReservedFileId, SwiftTokens.PreviouslyReservedFileIndex, isKeyword: true);
    public static readonly PlaceholderNodeType PreviouslyReservedFunction = new(SwiftTokens.PreviouslyReservedFunctionId, SwiftTokens.PreviouslyReservedFunctionIndex, isKeyword: true);
    public static readonly PlaceholderNodeType PreviouslyReservedLine = new(SwiftTokens.PreviouslyReservedLineId, SwiftTokens.PreviouslyReservedLineIndex, isKeyword: true);
    public static readonly PlaceholderNodeType PreviouslyReservedWarning = new(SwiftTokens.PreviouslyReservedWarningId, SwiftTokens.PreviouslyReservedWarningIndex, isKeyword: true);

    // Context sensitive keywords
    public static readonly PlaceholderNodeType Associativity = new(SwiftTokens.AssociativityId, SwiftTokens.AssociativityIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Async = new(SwiftTokens.AsyncId, SwiftTokens.AsyncIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Convenience = new(SwiftTokens.ConvenienceId, SwiftTokens.ConvenienceIndex, isKeyword: true);
    public static readonly PlaceholderNodeType DidSet = new(SwiftTokens.DidSetId, SwiftTokens.DidSetIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Dynamic = new(SwiftTokens.DynamicId, SwiftTokens.DynamicIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Final = new(SwiftTokens.FinalId, SwiftTokens.FinalIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Get = new(SwiftTokens.GetId, SwiftTokens.GetIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Indirect = new(SwiftTokens.IndirectId, SwiftTokens.IndirectIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Infix = new(SwiftTokens.InfixId, SwiftTokens.InfixIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Lazy = new(SwiftTokens.LazyId, SwiftTokens.LazyIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Left = new(SwiftTokens.LeftId, SwiftTokens.LeftIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Mutating = new(SwiftTokens.MutatingId, SwiftTokens.MutatingIndex, isKeyword: true);
    public static readonly PlaceholderNodeType None = new(SwiftTokens.NoneId, SwiftTokens.NoneIndex, isKeyword: true);
    public static readonly PlaceholderNodeType NonMutating = new(SwiftTokens.NonMutatingId, SwiftTokens.NonMutatingIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Optional = new(SwiftTokens.OptionalId, SwiftTokens.OptionalIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Override = new(SwiftTokens.OverrideId, SwiftTokens.OverrideIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Package = new(SwiftTokens.PackageId, SwiftTokens.PackageIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Postfix = new(SwiftTokens.PostfixId, SwiftTokens.PostfixIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Precedence = new(SwiftTokens.PrecedenceId, SwiftTokens.PrecedenceIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Prefix = new(SwiftTokens.PrefixId, SwiftTokens.PrefixIndex, isKeyword: true);
    public static readonly PlaceholderNodeType ProtocolUppercase = new(SwiftTokens.ProtocolUppercaseId, SwiftTokens.ProtocolUppercaseIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Required = new(SwiftTokens.RequiredId, SwiftTokens.RequiredIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Right = new(SwiftTokens.RightId, SwiftTokens.RightIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Set = new(SwiftTokens.SetId, SwiftTokens.SetIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Some = new(SwiftTokens.SomeId, SwiftTokens.SomeIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Type = new(SwiftTokens.TypeId, SwiftTokens.TypeIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Unowned = new(SwiftTokens.UnownedId, SwiftTokens.UnownedIndex, isKeyword: true);
    public static readonly PlaceholderNodeType Weak = new(SwiftTokens.WeakId, SwiftTokens.WeakIndex, isKeyword: true);
    public static readonly PlaceholderNodeType WillSet = new(SwiftTokens.WillSetId, SwiftTokens.WillSetIndex, isKeyword: true);

    // Operators
    public static readonly PlaceholderNodeType InfixOperator = new(SwiftTokens.InfixOperatorId, SwiftTokens.InfixOperatorIndex);
    public static readonly PlaceholderNodeType PrefixOperator = new(SwiftTokens.PrefixOperatorId, SwiftTokens.PrefixOperatorIndex);
    public static readonly PlaceholderNodeType PostfixOperator = new(SwiftTokens.PostfixOperatorId, SwiftTokens.PostfixOperatorIndex);
    public static readonly PlaceholderNodeType TernaryOperator = new(SwiftTokens.TernaryOperatorId, SwiftTokens.TernaryOperatorIndex);
    public static readonly PlaceholderNodeType OptionalChainingOperator = new(SwiftTokens.OptionalChainingOperatorId, SwiftTokens.OptionalChainingOperatorIndex);
    public static readonly PlaceholderNodeType QuestionMarkPrefixOperator = new(SwiftTokens.QuestionMarkPrefixOperatorId, SwiftTokens.QuestionMarkPrefixOperatorIndex);
    public static readonly PlaceholderNodeType QuestionMarkPostfixOperator = new(SwiftTokens.QuestionMarkPostfixOperatorId, SwiftTokens.QuestionMarkPostfixOperatorIndex);
    public static readonly PlaceholderNodeType ExclamationMarkPrefixOperator = new(SwiftTokens.ExclamationMarkPrefixOperatorId, SwiftTokens.ExclamationMarkPrefixOperatorIndex);
    public static readonly PlaceholderNodeType ExclamationMarkPostfixOperator = new(SwiftTokens.ExclamationMarkPostfixOperatorId, SwiftTokens.ExclamationMarkPostfixOperatorIndex);

    // Errors
    public static readonly PlaceholderNodeType InvalidToken = new(SwiftTokens.InvalidTokenId, SwiftTokens.InvalidTokenIndex);
    public static readonly PlaceholderNodeType UnmatchedOperator = new(SwiftTokens.UnmatchedOperatorId, SwiftTokens.UnmatchedOperatorIndex);
    public static readonly PlaceholderNodeType ErroneousIntegerLiteral = new(SwiftTokens.ErroneousIntegerLiteralId, SwiftTokens.ErroneousIntegerLiteralIndex);
    public static readonly PlaceholderNodeType ErroneousFloatingPointLiteral = new(SwiftTokens.ErroneousFloatingPointLiteralId, SwiftTokens.ErroneousFloatingPointLiteralIndex);
    public static readonly PlaceholderNodeType UnmatchedHashtag = new(SwiftTokens.UnmatchedHashtagId, SwiftTokens.UnmatchedHashtagIndex);
    public static readonly PlaceholderNodeType ErroneousStringLiteral = new(SwiftTokens.ErroneousStringLiteralId, SwiftTokens.ErroneousStringLiteralIndex);
    public static readonly PlaceholderNodeType UnmatchedEscapeSequence = new(SwiftTokens.UnmatchedEscapeSequenceId, SwiftTokens.UnmatchedEscapeSequenceIndex);
}