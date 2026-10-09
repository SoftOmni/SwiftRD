using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Identifiers;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.C;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.ObjectiveC;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Markers;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Trigraphs;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Whitespace;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.NodeTypes;

public static class ObjectiveCNodeTypes
{
    #region LeafNodes

    #region Markers

    public static readonly StartOfFileToken StartOfFile = ObjectiveCTokens.StartOfFileToken;
    public static readonly EndOfFileToken EndOfFile = ObjectiveCTokens.EndOfFileToken;
    public static readonly EmptyToken EmptyToken = ObjectiveCTokens.EmptyToken;

    #endregion

    #region WhitespaceAndComments

    public static readonly NewLineToken NewLine = ObjectiveCTokens.NewlineToken;
    public static readonly WhitespaceToken Whitespace = ObjectiveCTokens.WhitespaceToken;
    public static readonly LineCommentToken LineComment = ObjectiveCTokens.LineCommentToken;
    public static readonly BlockCommentToken BlockComment = ObjectiveCTokens.BlockCommentToken;

    #endregion

    #region Identifiers

    public static readonly IdentifierToken Identifier = ObjectiveCTokens.IdentifierToken;

    #endregion

    #region Punctuators

    #region C

    public static readonly OpeningSquareBracketToken OpeningSquareBracket = ObjectiveCTokens.OpeningSquareBracketToken;
    public static readonly ClosingSquareBracketToken ClosingSquareBracket = ObjectiveCTokens.ClosingSquareBracketToken;
    public static readonly OpeningParenthesisToken OpeningParenthesis = ObjectiveCTokens.OpeningParenthesisToken;
    public static readonly ClosingParenthesisToken ClosingParenthesis = ObjectiveCTokens.ClosingParenthesisToken;
    public static readonly OpeningCurlyBraceToken OpeningCurlyBrace = ObjectiveCTokens.OpeningCurlyBraceToken;
    public static readonly ClosingCurlyBraceToken ClosingCurlyBrace = ObjectiveCTokens.ClosingCurlyBraceToken;
    public static readonly DotOperatorToken DotOperator = ObjectiveCTokens.DotOperatorToken;
    public static readonly ArrowOperatorToken ArrowOperator = ObjectiveCTokens.ArrowOperatorToken;
    public static readonly IncrementOperatorToken IncrementOperator = ObjectiveCTokens.IncrementOperatorToken;
    public static readonly DecrementOperatorToken DecrementOperator = ObjectiveCTokens.DecrementOperatorToken;
    public static readonly BitwiseAndOperatorToken BitwiseAndOperator = ObjectiveCTokens.BitwiseAndOperatorToken;
    public static readonly MultiplyOrPointerOperatorToken MultiplyOrPointerOperator = ObjectiveCTokens.MultiplyOrPointerOperatorToken;
    public static readonly AddOrIdentityOperatorToken AddOrIdentityOperator = ObjectiveCTokens.AddOrIdentityOperatorToken;
    public static readonly SubtractOrInverseOperatorToken SubtractOrInverseOperator = ObjectiveCTokens.SubtractOrInverseOperatorToken;
    public static readonly BitwiseNotOperatorToken BitwiseNotOperator = ObjectiveCTokens.BitwiseNotOperatorToken;
    public static readonly LogicalNotOperatorToken LogicalNotOperator = ObjectiveCTokens.LogicalNotOperatorToken;
    public static readonly DivideOperatorToken DivideOperator = ObjectiveCTokens.DivideOperatorToken;
    public static readonly ModulusOperatorToken ModulusOperator = ObjectiveCTokens.ModulusOperatorToken;
    public static readonly RightShiftOperatorToken RightShiftOperator = ObjectiveCTokens.RightShiftOperatorToken;
    public static readonly LeftShiftOperatorToken LeftShiftOperator = ObjectiveCTokens.LeftShiftOperatorToken;
    public static readonly LesserThanOperatorToken LesserThanOperator = ObjectiveCTokens.LesserThanOperatorToken;
    public static readonly GreaterThanOperatorToken GreaterThanOperator = ObjectiveCTokens.GreaterThanOperatorToken;
    public static readonly LesserThanOrEqualsOperatorToken LesserThanOrEqualsOperator = ObjectiveCTokens.LesserThanOrEqualsOperatorToken;
    public static readonly GreaterThanOrEqualsOperatorToken GreaterThanOrEqualsOperator = ObjectiveCTokens.GreaterThanOrEqualsOperatorToken;
    public static readonly EqualityOperatorToken EqualityOperator = ObjectiveCTokens.EqualityOperatorToken;
    public static readonly NotEqualsOperatorToken NotEqualsOperator = ObjectiveCTokens.NotEqualsOperatorToken;
    public static readonly BitwiseXorOperatorToken BitwiseXorOperator = ObjectiveCTokens.BitwiseXorOperatorToken;
    public static readonly BitwiseOrOperatorToken BitwiseOrOperator = ObjectiveCTokens.BitwiseOrOperatorToken;
    public static readonly LogicalAndOperatorToken LogicalAndOperator = ObjectiveCTokens.LogicalAndOperatorToken;
    public static readonly LogicalOrOperatorToken LogicalOrOperator = ObjectiveCTokens.LogicalOrOperatorToken;
    public static readonly TernaryOperatorQuestionResponseSeparatorToken TernaryOperatorQuestionResponseSeparator = ObjectiveCTokens.TernaryOperatorQuestionResponseSeparatorToken;
    public static readonly ColonToken Colon = ObjectiveCTokens.ColonToken;
    public static readonly SemicolonToken Semicolon = ObjectiveCTokens.SemicolonToken;
    public static readonly TriplePeriodToken TriplePeriod = ObjectiveCTokens.TriplePeriodToken;
    public static readonly AssignmentOperatorToken AssignmentOperator = ObjectiveCTokens.AssignmentOperatorToken;
    public static readonly CompoundMultiplyOperatorToken CompoundMultiplyOperator = ObjectiveCTokens.CompoundMultiplyOperatorToken;
    public static readonly CompoundDivideOperatorToken CompoundDivideOperator = ObjectiveCTokens.CompoundDivideOperatorToken;
    public static readonly CompoundModulusOperatorToken CompoundModulusOperator = ObjectiveCTokens.CompoundModulusOperatorToken;
    public static readonly CompoundAddOperatorToken CompoundAddOperator = ObjectiveCTokens.CompoundAddOperatorToken;
    public static readonly CompoundSubtractOperatorToken CompoundSubtractOperator = ObjectiveCTokens.CompoundSubtractOperatorToken;
    public static readonly CompoundRightShiftOperatorToken CompoundRightShiftOperator =
        ObjectiveCTokens.CompoundRightShiftOperatorToken;
    public static readonly CompoundLeftShiftOperatorToken CompoundLeftShiftOperator =
        ObjectiveCTokens.CompoundLeftShiftOperatorToken;
    public static readonly CompoundBitwiseAndOperatorToken CompoundBitwiseAndOperator = ObjectiveCTokens.CompoundBitwiseAndOperatorToken;
    public static readonly CompoundBitwiseXorOperatorToken CompoundBitwiseXorOperator = ObjectiveCTokens.CompoundBitwiseXorOperatorToken;
    public static readonly CompoundBitwiseOrOperatorToken CompoundBitwiseOrOperator = ObjectiveCTokens.CompoundBitwiseOrOperatorToken;
    public static readonly CommaToken Comma = ObjectiveCTokens.CommaToken;
    public static readonly HashtagToken Hashtag = ObjectiveCTokens.HashtagToken;
    public static readonly DoubleHashtagToken DoubleHashtag = ObjectiveCTokens.DoubleHashtagToken;
    public static readonly OpeningSquareBracketDigraphToken OpeningSquareBracketDigraph = ObjectiveCTokens.OpeningSquareBracketDigraphToken;
    public static readonly ClosingSquareBracketDigraphToken ClosingSquareBracketDigraph = ObjectiveCTokens.ClosingSquareBracketDigraphToken;
    public static readonly OpeningCurlyBraceDigraphToken OpeningCurlyBraceDigraph =
        ObjectiveCTokens.OpeningCurlyBraceDigraphToken;
    public static readonly ClosingCurlyBraceDigraphToken ClosingCurlyBraceDigraph =
        ObjectiveCTokens.ClosingCurlyBraceDigraphToken;
    public static readonly PreprocessorFunctionArgumentValueDigraphToken PreprocessorFunctionArgumentValueDigraph = ObjectiveCTokens.PreprocessorFunctionArgumentValueDigraphToken;
    public static readonly PreprocessorConcatenateOperatorDigraphToken PreprocessorConcatenateOperatorDigraph =
        ObjectiveCTokens.PreprocessorConcatenateOperatorDigraphToken;

    #endregion

    #region ObjectiveC

    public static readonly AtToken At = ObjectiveCTokens.AtToken;

    #endregion

    #endregion

    #region Keywords

    #region C

    public static readonly AutoKeywordToken AutoKeyword = ObjectiveCTokens.AutoKeywordToken;
    public static readonly BreakKeywordToken BreakKeyword = ObjectiveCTokens.BreakKeywordToken;
    public static readonly CaseKeywordToken CaseKeyword = ObjectiveCTokens.CaseKeywordToken;
    public static readonly CharKeywordToken CharKeyword = ObjectiveCTokens.CharKeywordToken;
    public static readonly ConstKeywordToken ConstKeyword = ObjectiveCTokens.ConstKeywordToken;
    public static readonly ContinueKeywordToken ContinueKeyword = ObjectiveCTokens.ContinueKeywordToken;
    public static readonly DefaultKeywordToken DefaultKeyword = ObjectiveCTokens.DefaultKeywordToken;
    public static readonly DoKeywordToken DoKeyword = ObjectiveCTokens.DoKeywordToken;
    public static readonly DoubleKeywordToken DoubleKeyword = ObjectiveCTokens.DoubleKeywordToken;
    public static readonly ElseKeywordToken ElseKeyword = ObjectiveCTokens.ElseKeywordToken;
    public static readonly EnumKeywordToken EnumKeyword = ObjectiveCTokens.EnumKeywordToken;
    public static readonly ExternKeywordToken ExternKeyword = ObjectiveCTokens.ExternKeywordToken;
    public static readonly FloatKeywordToken FloatKeyword = ObjectiveCTokens.FloatKeywordToken;
    public static readonly ForKeywordToken ForKeyword = ObjectiveCTokens.ForKeywordToken;
    public static readonly GotoKeywordToken GotoKeyword = ObjectiveCTokens.GotoKeywordToken;
    public static readonly IfKeywordToken IfKeyword = ObjectiveCTokens.IfKeywordToken;
    public static readonly InlineKeywordToken InlineKeyword = ObjectiveCTokens.InlineKeywordToken;
    public static readonly IntKeywordToken IntKeyword = ObjectiveCTokens.IntKeywordToken;
    public static readonly LongKeywordToken LongKeyword = ObjectiveCTokens.LongKeywordToken;
    public static readonly RegisterKeywordToken RegisterKeyword = ObjectiveCTokens.RegisterKeywordToken;
    public static readonly RestrictKeywordToken RestrictKeyword = ObjectiveCTokens.RestrictKeywordToken;
    public static readonly ReturnKeywordToken ReturnKeyword = ObjectiveCTokens.ReturnKeywordToken;
    public static readonly ShortKeywordToken ShortKeyword = ObjectiveCTokens.ShortKeywordToken;
    public static readonly SignedKeywordToken SignedKeyword = ObjectiveCTokens.SignedKeywordToken;
    public static readonly SizeofKeywordToken SizeofKeyword = ObjectiveCTokens.SizeofKeywordToken;
    public static readonly StaticKeywordToken StaticKeyword = ObjectiveCTokens.StaticKeywordToken;
    public static readonly StructKeywordToken StructKeyword = ObjectiveCTokens.StructKeywordToken;
    public static readonly SwitchKeywordToken SwitchKeyword = ObjectiveCTokens.SwitchKeywordToken;
    public static readonly TypedefKeywordToken TypedefKeyword = ObjectiveCTokens.TypedefKeywordToken;
    public static readonly UnionKeywordToken UnionKeyword = ObjectiveCTokens.UnionKeywordToken;
    public static readonly UnsignedKeywordToken UnsignedKeyword = ObjectiveCTokens.UnsignedKeywordToken;
    public static readonly VoidKeywordToken VoidKeyword = ObjectiveCTokens.VoidKeywordToken;
    public static readonly VolatileKeywordToken VolatileKeyword = ObjectiveCTokens.VolatileKeywordToken;
    public static readonly WhileKeywordToken WhileKeyword = ObjectiveCTokens.WhileKeywordToken;
    public static readonly AlignasC11KeywordToken AlignasC11Keyword = ObjectiveCTokens.AlignasC11KeywordToken;
    public static readonly AlignOfC11KeywordToken AlignOfC11Keyword = ObjectiveCTokens.AlignOfC11KeywordToken;
    public static readonly AtomicC11KeywordToken AtomicC11Keyword = ObjectiveCTokens.AtomicC11KeywordToken;
    public static readonly BoolC99KeywordToken BoolC99Keyword = ObjectiveCTokens.BoolC99KeywordToken;
    public static readonly ComplexC99KeywordToken ComplexC99Keyword = ObjectiveCTokens.ComplexC99KeywordToken;
    public static readonly GenericC11KeywordToken GenericC11Keyword = ObjectiveCTokens.GenericC11KeywordToken;
    public static readonly ImaginaryC99KeywordToken ImaginaryC99Keyword = ObjectiveCTokens.ImaginaryC99KeywordToken;
    public static readonly NoreturnC11KeywordToken NoreturnC11Keyword = ObjectiveCTokens.NoreturnC11KeywordToken;
    public static readonly StaticAssertC11KeywordToken StaticAssertC11Keyword = ObjectiveCTokens.StaticAssertC11KeywordToken;
    public static readonly ThreadLocalC11KeywordToken ThreadLocalC11Keyword = ObjectiveCTokens.ThreadLocalC11KeywordToken;
    
    #endregion

    #region ObjectiveC

    public static readonly BridgeObjCArcKeywordToken BridgeObjCArcKeyword = ObjectiveCTokens.BridgeObjCArcKeywordToken;
    public static readonly BridgeTransferObjCArcKeywordToken BridgeTransferObjCArcKeyword = ObjectiveCTokens.BridgeTransferObjCArcKeywordToken;
    public static readonly BridgeRetainedObjCArcKeywordToken BridgeRetainedObjCArcKeyword = ObjectiveCTokens.BridgeRetainedObjCArcKeywordToken;
    public static readonly BridgeRetainObjCArcKeywordToken BridgeRetainObjCArcKeyword = ObjectiveCTokens.BridgeRetainObjCArcKeywordToken;
    public static readonly CovariantObjCKeywordToken CovariantObjCKeyword = ObjectiveCTokens.CovariantObjCKeywordToken;
    public static readonly ContravariantObjCKeywordToken ContravariantObjCKeyword = ObjectiveCTokens.ContravariantObjCKeywordToken;
    public static readonly KindOfObjCKeywordToken KindOfObjCKeyword = ObjectiveCTokens.KindOfObjCKeywordToken;
    public static readonly NotAKeywordObjCKeywordToken NotAKeywordObjCKeyword = ObjectiveCTokens.NotAKeywordObjCKeywordToken;
    public static readonly ClassObjCKeywordToken ClassObjCKeyword = ObjectiveCTokens.ClassObjCKeywordToken;
    public static readonly CompatibilityAliasObjCKeywordToken CompatibilityAliasObjCKeyword = ObjectiveCTokens.CompatibilityAliasObjCKeywordToken;
    public static readonly DefsObjCKeywordToken DefsObjCKeyword = ObjectiveCTokens.DefsObjCKeywordToken;
    public static readonly EncodeObjCKeywordToken EncodeObjCKeyword = ObjectiveCTokens.EncodeObjCKeywordToken;
    public static readonly EndObjCKeywordToken EndObjCKeyword = ObjectiveCTokens.EndObjCKeywordToken;
    public static readonly ImplementationObjCKeywordToken ImplementationObjCKeyword = ObjectiveCTokens.ImplementationObjCKeywordToken;
    public static readonly InterfaceObjCKeywordToken InterfaceObjCKeyword = ObjectiveCTokens.InterfaceObjCKeywordToken;
    public static readonly PrivateObjCKeywordToken PrivateObjCKeyword = ObjectiveCTokens.PrivateObjCKeywordToken;
    public static readonly ProtectedObjCKeywordToken ProtectedObjCKeyword = ObjectiveCTokens.ProtectedObjCKeywordToken;
    public static readonly ProtocolObjCKeywordToken ProtocolObjCKeyword = ObjectiveCTokens.ProtocolObjCKeywordToken;
    public static readonly PublicObjCKeywordToken PublicObjCKeyword = ObjectiveCTokens.PublicObjCKeywordToken;
    public static readonly SelectorObjCKeywordToken SelectorObjCKeyword = ObjectiveCTokens.SelectorObjCKeywordToken;
    public static readonly ThrowObjCKeywordToken ThrowObjCKeyword = ObjectiveCTokens.ThrowObjCKeywordToken;
    public static readonly TryObjCKeywordToken TryObjCKeyword = ObjectiveCTokens.TryObjCKeywordToken;
    public static readonly CatchObjCKeywordToken CatchObjCKeyword = ObjectiveCTokens.CatchObjCKeywordToken;
    public static readonly FinallyObjCKeywordToken FinallyObjCKeyword = ObjectiveCTokens.FinallyObjCKeywordToken;
    public static readonly SynchronizedObjCKeywordToken SynchronizedObjCKeyword = ObjectiveCTokens.SynchronizedObjCKeywordToken;
    public static readonly AutoReleasePoolObjCKeywordToken AutoReleasePoolObjCKeyword = ObjectiveCTokens.AutoReleasePoolObjCKeywordToken;
    public static readonly PropertyObjCKeywordToken PropertyObjCKeyword = ObjectiveCTokens.PropertyObjCKeywordToken;
    public static readonly PackageObjCKeywordToken PackageObjCKeyword = ObjectiveCTokens.PackageObjCKeywordToken;
    public static readonly RequiredObjCKeywordToken RequiredObjCKeyword = ObjectiveCTokens.RequiredObjCKeywordToken;
    public static readonly OptionalObjCKeywordToken OptionalObjCKeyword = ObjectiveCTokens.OptionalObjCKeywordToken;
    public static readonly SynthesizeObjCKeywordToken SynthesizeObjCKeyword = ObjectiveCTokens.SynthesizeObjCKeywordToken;
    public static readonly DynamicObjCKeywordToken DynamicObjCKeyword = ObjectiveCTokens.DynamicObjCKeywordToken;
    public static readonly ImportObjCKeywordToken ImportObjCKeyword = ObjectiveCTokens.ImportObjCKeywordToken;
    public static readonly AvailableObjCKeywordToken AvailableObjCKeyword = ObjectiveCTokens.AvailableObjCKeywordToken;
    
    #endregion

    #endregion

    #region Trigraphs

    public static readonly HashTrigraphToken HashTrigraph = ObjectiveCTokens.HashTrigraphToken;
    public static readonly OpeningSquareBracketTrigraphToken OpeningSquareBracketTrigraph = ObjectiveCTokens.OpeningSquareBracketTrigraphToken;
    public static readonly BackslashTrigraphToken BackslashTrigraph = ObjectiveCTokens.BackslashTrigraphToken;
    public static readonly ClosingSquareBracketTrigraphToken ClosingSquareBracketTrigraph = ObjectiveCTokens.ClosingSquareBracketTrigraphToken;
    public static readonly CaretTrigraphToken CaretTrigraph = ObjectiveCTokens.CaretTrigraphToken;
    public static readonly OpeningCurlyBraceTrigraphToken OpeningCurlyBraceTrigraph = ObjectiveCTokens.OpeningCurlyBraceTrigraphToken;
    public static readonly VerticalSlashTrigraphToken VerticalSlashTrigraph = ObjectiveCTokens.VerticalSlashTrigraphToken;
    public static readonly ClosingCurlyBraceTrigraphToken ClosingCurlyBraceTrigraph = ObjectiveCTokens.ClosingCurlyBraceTrigraphToken;
    public static readonly TildeTrigraphToken TildeTrigraph = ObjectiveCTokens.TildeTrigraphToken;

    #endregion

    #endregion

    #region InternalNodes

    #endregion
}
