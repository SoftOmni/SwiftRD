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

    public static StartOfFileToken StartOfFile => ObjectiveCTokens.StartOfFileToken;
    public static EndOfFileToken EndOfFile => ObjectiveCTokens.EndOfFileToken;
    public static EmptyToken EmptyToken => ObjectiveCTokens.EmptyToken;

    #endregion

    #region WhitespaceAndComments

    public static NewLineToken NewLine => ObjectiveCTokens.NewlineToken;
    public static WhitespaceToken Whitespace => ObjectiveCTokens.WhitespaceToken;
    public static LineCommentToken LineComment => ObjectiveCTokens.LineCommentToken;
    public static BlockCommentToken BlockComment => ObjectiveCTokens.BlockCommentToken;

    #endregion

    #region Identifiers

    public static IdentifierToken Identifier => ObjectiveCTokens.IdentifierToken;

    #endregion

    #region Punctuators

    #region C

    public static OpeningSquareBracketToken OpeningSquareBracket => ObjectiveCTokens.OpeningSquareBracketToken;
    
    public static ClosingSquareBracketToken ClosingSquareBracket => ObjectiveCTokens.ClosingSquareBracketToken;
    
    public static OpeningParenthesisToken OpeningParenthesis => ObjectiveCTokens.OpeningParenthesisToken;
    
    public static ClosingParenthesisToken ClosingParenthesis => ObjectiveCTokens.ClosingParenthesisToken;
    
    public static OpeningCurlyBraceToken OpeningCurlyBrace => ObjectiveCTokens.OpeningCurlyBraceToken;
    
    public static ClosingCurlyBraceToken ClosingCurlyBrace => ObjectiveCTokens.ClosingCurlyBraceToken;
    
    public static DotOperatorToken DotOperator => ObjectiveCTokens.DotOperatorToken;
    
    public static ArrowOperatorToken ArrowOperator => ObjectiveCTokens.ArrowOperatorToken;
    
    public static IncrementOperatorToken IncrementOperator => ObjectiveCTokens.IncrementOperatorToken;
    
    public static DecrementOperatorToken DecrementOperator => ObjectiveCTokens.DecrementOperatorToken;
    
    public static BitwiseAndOperatorToken BitwiseAndOperator => ObjectiveCTokens.BitwiseAndOperatorToken;
    
    public static MultiplyOrPointerOperatorToken MultiplyOrPointerOperator => ObjectiveCTokens.MultiplyOrPointerOperatorToken;
    
    public static AddOrIdentityOperatorToken AddOrIdentityOperator => ObjectiveCTokens.AddOrIdentityOperatorToken;
    
    public static SubtractOrInverseOperatorToken SubtractOrInverseOperator => ObjectiveCTokens.SubtractOrInverseOperatorToken;
    
    public static BitwiseNotOperatorToken BitwiseNotOperator => ObjectiveCTokens.BitwiseNotOperatorToken;
    
    public static LogicalNotOperatorToken LogicalNotOperator => ObjectiveCTokens.LogicalNotOperatorToken;
    
    public static DivideOperatorToken DivideOperator => ObjectiveCTokens.DivideOperatorToken;
    
    public static ModulusOperatorToken ModulusOperator => ObjectiveCTokens.ModulusOperatorToken;
    
    public static RightShiftOperatorToken RightShiftOperator => ObjectiveCTokens.RightShiftOperatorToken;
    
    public static LeftShiftOperatorToken LeftShiftOperator => ObjectiveCTokens.LeftShiftOperatorToken;
    
    public static LesserThanOperatorToken LesserThanOperator => ObjectiveCTokens.LesserThanOperatorToken;
    
    public static GreaterThanOperatorToken GreaterThanOperator => ObjectiveCTokens.GreaterThanOperatorToken;
    
    public static LesserThanOrEqualsOperatorToken LesserThanOrEqualsOperator => ObjectiveCTokens.LesserThanOrEqualsOperatorToken;
    
    public static GreaterThanOrEqualsOperatorToken GreaterThanOrEqualsOperator => ObjectiveCTokens.GreaterThanOrEqualsOperatorToken;
    
    public static EqualityOperatorToken EqualityOperator => ObjectiveCTokens.EqualityOperatorToken;
    
    public static NotEqualsOperatorToken NotEqualsOperator => ObjectiveCTokens.NotEqualsOperatorToken;
    
    public static BitwiseXorOperatorToken BitwiseXorOperator => ObjectiveCTokens.BitwiseXorOperatorToken;
    
    public static BitwiseOrOperatorToken BitwiseOrOperator => ObjectiveCTokens.BitwiseOrOperatorToken;
    
    public static LogicalAndOperatorToken LogicalAndOperator => ObjectiveCTokens.LogicalAndOperatorToken;
    
    public static LogicalOrOperatorToken LogicalOrOperator => ObjectiveCTokens.LogicalOrOperatorToken;

    public static TernaryOperatorQuestionResponseSeparatorToken TernaryOperatorQuestionResponseSeparator =>
        ObjectiveCTokens.TernaryOperatorQuestionResponseSeparatorToken;

    public static ColonToken Colon => ObjectiveCTokens.ColonToken;
    
    public static SemicolonToken Semicolon => ObjectiveCTokens.SemicolonToken;
    
    public static TriplePeriodToken TriplePeriod => ObjectiveCTokens.TriplePeriodToken;
    
    public static AssignmentOperatorToken AssignmentOperator => ObjectiveCTokens.AssignmentOperatorToken;
    
    public static CompoundMultiplyOperatorToken CompoundMultiplyOperator => ObjectiveCTokens.CompoundMultiplyOperatorToken;
    
    public static CompoundDivideOperatorToken CompoundDivideOperator => ObjectiveCTokens.CompoundDivideOperatorToken;
    
    public static CompoundModulusOperatorToken CompoundModulusOperator => ObjectiveCTokens.CompoundModulusOperatorToken;
    
    public static CompoundAddOperatorToken CompoundAddOperator => ObjectiveCTokens.CompoundAddOperatorToken;
    
    public static CompoundSubtractOperatorToken CompoundSubtractOperator => ObjectiveCTokens.CompoundSubtractOperatorToken;
    
    public static CompoundRightShiftOperatorToken CompoundRightShiftOperator => ObjectiveCTokens.CompoundRightShiftOperatorToken;
    
    public static CompoundLeftShiftOperatorToken CompoundLeftShiftOperator => ObjectiveCTokens.CompoundLeftShiftOperatorToken;
    
    public static CompoundBitwiseAndOperatorToken CompoundBitwiseAndOperator => ObjectiveCTokens.CompoundBitwiseAndOperatorToken;
    
    public static CompoundBitwiseXorOperatorToken CompoundBitwiseXorOperator => ObjectiveCTokens.CompoundBitwiseXorOperatorToken;
    
    public static CompoundBitwiseOrOperatorToken CompoundBitwiseOrOperator => ObjectiveCTokens.CompoundBitwiseOrOperatorToken;
    
    public static CommaToken Comma => ObjectiveCTokens.CommaToken;
    
    public static HashtagToken Hashtag => ObjectiveCTokens.HashtagToken;
    
    public static DoubleHashtagToken DoubleHashtag => ObjectiveCTokens.DoubleHashtagToken;
    
    public static OpeningSquareBracketDigraphToken OpeningSquareBracketDigraph => ObjectiveCTokens.OpeningSquareBracketDigraphToken;
    
    public static ClosingSquareBracketDigraphToken ClosingSquareBracketDigraph => ObjectiveCTokens.ClosingSquareBracketDigraphToken;
    
    public static OpeningCurlyBraceDigraphToken OpeningCurlyBraceDigraph => ObjectiveCTokens.OpeningCurlyBraceDigraphToken;
    
    public static ClosingCurlyBraceDigraphToken ClosingCurlyBraceDigraph => ObjectiveCTokens.ClosingCurlyBraceDigraphToken;

    public static PreprocessorFunctionArgumentValueDigraphToken PreprocessorFunctionArgumentValueDigraph =>
        ObjectiveCTokens.PreprocessorFunctionArgumentValueDigraphToken;

    public static PreprocessorConcatenateOperatorDigraphToken PreprocessorConcatenateOperatorDigraph =>
        ObjectiveCTokens.PreprocessorConcatenateOperatorDigraphToken;

    #endregion

    #region ObjectiveC

    public static AtToken At => ObjectiveCTokens.AtToken;

    #endregion

    #endregion

    #region Keywords

    #region C

    public static AutoKeywordToken AutoKeyword => ObjectiveCTokens.AutoKeywordToken;

    public static BreakKeywordToken BreakKeyword => ObjectiveCTokens.BreakKeywordToken;

    public static CaseKeywordToken CaseKeyword => ObjectiveCTokens.CaseKeywordToken;

    public static CharKeywordToken CharKeyword => ObjectiveCTokens.CharKeywordToken;

    public static ConstKeywordToken ConstKeyword => ObjectiveCTokens.ConstKeywordToken;

    public static ContinueKeywordToken ContinueKeyword => ObjectiveCTokens.ContinueKeywordToken;

    public static DefaultKeywordToken DefaultKeyword => ObjectiveCTokens.DefaultKeywordToken;

    public static DoKeywordToken DoKeyword => ObjectiveCTokens.DoKeywordToken;

    public static DoubleKeywordToken DoubleKeyword => ObjectiveCTokens.DoubleKeywordToken;

    public static ElseKeywordToken ElseKeyword => ObjectiveCTokens.ElseKeywordToken;

    public static EnumKeywordToken EnumKeyword => ObjectiveCTokens.EnumKeywordToken;

    public static ExternKeywordToken ExternKeyword => ObjectiveCTokens.ExternKeywordToken;

    public static FloatKeywordToken FloatKeyword => ObjectiveCTokens.FloatKeywordToken;

    public static ForKeywordToken ForKeyword => ObjectiveCTokens.ForKeywordToken;

    public static GotoKeywordToken GotoKeyword => ObjectiveCTokens.GotoKeywordToken;

    public static IfKeywordToken IfKeyword => ObjectiveCTokens.IfKeywordToken;

    public static InlineKeywordToken InlineKeyword => ObjectiveCTokens.InlineKeywordToken;

    public static IntKeywordToken IntKeyword => ObjectiveCTokens.IntKeywordToken;

    public static LongKeywordToken LongKeyword => ObjectiveCTokens.LongKeywordToken;

    public static RegisterKeywordToken RegisterKeyword => ObjectiveCTokens.RegisterKeywordToken;

    public static RestrictKeywordToken RestrictKeyword => ObjectiveCTokens.RestrictKeywordToken;

    public static ReturnKeywordToken ReturnKeyword => ObjectiveCTokens.ReturnKeywordToken;

    public static ShortKeywordToken ShortKeyword => ObjectiveCTokens.ShortKeywordToken;

    public static SignedKeywordToken SignedKeyword => ObjectiveCTokens.SignedKeywordToken;

    public static SizeofKeywordToken SizeofKeyword => ObjectiveCTokens.SizeofKeywordToken;

    public static StaticKeywordToken StaticKeyword => ObjectiveCTokens.StaticKeywordToken;

    public static StructKeywordToken StructKeyword => ObjectiveCTokens.StructKeywordToken;

    public static SwitchKeywordToken SwitchKeyword => ObjectiveCTokens.SwitchKeywordToken;

    public static TypedefKeywordToken TypedefKeyword => ObjectiveCTokens.TypedefKeywordToken;

    public static UnionKeywordToken UnionKeyword => ObjectiveCTokens.UnionKeywordToken;

    public static UnsignedKeywordToken UnsignedKeyword => ObjectiveCTokens.UnsignedKeywordToken;

    public static VoidKeywordToken VoidKeyword => ObjectiveCTokens.VoidKeywordToken;

    public static VolatileKeywordToken VolatileKeyword => ObjectiveCTokens.VolatileKeywordToken;

    public static WhileKeywordToken WhileKeyword => ObjectiveCTokens.WhileKeywordToken;

    public static AlignasC11KeywordToken AlignasC11Keyword => ObjectiveCTokens.AlignasC11KeywordToken;

    public static AlignOfC11KeywordToken AlignOfC11Keyword => ObjectiveCTokens.AlignOfC11KeywordToken;

    public static AtomicC11KeywordToken AtomicC11Keyword => ObjectiveCTokens.AtomicC11KeywordToken;

    public static BoolC99KeywordToken BoolC99Keyword => ObjectiveCTokens.BoolC99KeywordToken;

    public static ComplexC99KeywordToken ComplexC99Keyword => ObjectiveCTokens.ComplexC99KeywordToken;

    public static GenericC11KeywordToken GenericC11Keyword => ObjectiveCTokens.GenericC11KeywordToken;

    public static ImaginaryC99KeywordToken ImaginaryC99Keyword => ObjectiveCTokens.ImaginaryC99KeywordToken;

    public static NoreturnC11KeywordToken NoreturnC11Keyword => ObjectiveCTokens.NoreturnC11KeywordToken;

    public static StaticAssertC11KeywordToken StaticAssertC11Keyword => ObjectiveCTokens.StaticAssertC11KeywordToken;

    public static ThreadLocalC11KeywordToken ThreadLocalC11Keyword => ObjectiveCTokens.ThreadLocalC11KeywordToken;

    #endregion

    #region ObjectiveC

    public static BridgeObjCArcKeywordToken BridgeObjCArcKeyword => ObjectiveCTokens.BridgeObjCArcKeywordToken;

    public static BridgeTransferObjCArcKeywordToken BridgeTransferObjCArcKeyword => ObjectiveCTokens.BridgeTransferObjCArcKeywordToken;

    public static BridgeRetainedObjCArcKeywordToken BridgeRetainedObjCArcKeyword => ObjectiveCTokens.BridgeRetainedObjCArcKeywordToken;

    public static BridgeRetainObjCArcKeywordToken BridgeRetainObjCArcKeyword => ObjectiveCTokens.BridgeRetainObjCArcKeywordToken;

    public static CovariantObjCKeywordToken CovariantObjCKeyword => ObjectiveCTokens.CovariantObjCKeywordToken;

    public static ContravariantObjCKeywordToken ContravariantObjCKeyword => ObjectiveCTokens.ContravariantObjCKeywordToken;

    public static KindOfObjCKeywordToken KindOfObjCKeyword => ObjectiveCTokens.KindOfObjCKeywordToken;

    public static NotAKeywordObjCKeywordToken NotAKeywordObjCKeyword => ObjectiveCTokens.NotAKeywordObjCKeywordToken;

    public static ClassObjCKeywordToken ClassObjCKeyword => ObjectiveCTokens.ClassObjCKeywordToken;

    public static CompatibilityAliasObjCKeywordToken CompatibilityAliasObjCKeyword => ObjectiveCTokens.CompatibilityAliasObjCKeywordToken;

    public static DefsObjCKeywordToken DefsObjCKeyword => ObjectiveCTokens.DefsObjCKeywordToken;

    public static EncodeObjCKeywordToken EncodeObjCKeyword => ObjectiveCTokens.EncodeObjCKeywordToken;

    public static EndObjCKeywordToken EndObjCKeyword => ObjectiveCTokens.EndObjCKeywordToken;

    public static ImplementationObjCKeywordToken ImplementationObjCKeyword => ObjectiveCTokens.ImplementationObjCKeywordToken;

    public static InterfaceObjCKeywordToken InterfaceObjCKeyword => ObjectiveCTokens.InterfaceObjCKeywordToken;

    public static PrivateObjCKeywordToken PrivateObjCKeyword => ObjectiveCTokens.PrivateObjCKeywordToken;

    public static ProtectedObjCKeywordToken ProtectedObjCKeyword => ObjectiveCTokens.ProtectedObjCKeywordToken;

    public static ProtocolObjCKeywordToken ProtocolObjCKeyword => ObjectiveCTokens.ProtocolObjCKeywordToken;

    public static PublicObjCKeywordToken PublicObjCKeyword => ObjectiveCTokens.PublicObjCKeywordToken;

    public static SelectorObjCKeywordToken SelectorObjCKeyword => ObjectiveCTokens.SelectorObjCKeywordToken;

    public static ThrowObjCKeywordToken ThrowObjCKeyword => ObjectiveCTokens.ThrowObjCKeywordToken;

    public static TryObjCKeywordToken TryObjCKeyword => ObjectiveCTokens.TryObjCKeywordToken;

    public static CatchObjCKeywordToken CatchObjCKeyword => ObjectiveCTokens.CatchObjCKeywordToken;

    public static FinallyObjCKeywordToken FinallyObjCKeyword => ObjectiveCTokens.FinallyObjCKeywordToken;

    public static SynchronizedObjCKeywordToken SynchronizedObjCKeyword => ObjectiveCTokens.SynchronizedObjCKeywordToken;

    public static AutoReleasePoolObjCKeywordToken AutoReleasePoolObjCKeyword => ObjectiveCTokens.AutoReleasePoolObjCKeywordToken;

    public static PropertyObjCKeywordToken PropertyObjCKeyword => ObjectiveCTokens.PropertyObjCKeywordToken;

    public static PackageObjCKeywordToken PackageObjCKeyword => ObjectiveCTokens.PackageObjCKeywordToken;

    public static RequiredObjCKeywordToken RequiredObjCKeyword => ObjectiveCTokens.RequiredObjCKeywordToken;

    public static OptionalObjCKeywordToken OptionalObjCKeyword => ObjectiveCTokens.OptionalObjCKeywordToken;

    public static SynthesizeObjCKeywordToken SynthesizeObjCKeyword => ObjectiveCTokens.SynthesizeObjCKeywordToken;

    public static DynamicObjCKeywordToken DynamicObjCKeyword => ObjectiveCTokens.DynamicObjCKeywordToken;

    public static ImportObjCKeywordToken ImportObjCKeyword => ObjectiveCTokens.ImportObjCKeywordToken;

    public static AvailableObjCKeywordToken AvailableObjCKeyword => ObjectiveCTokens.AvailableObjCKeywordToken;

    #endregion

    #endregion

    #region Trigraphs

    public static HashTrigraphToken HashTrigraph => ObjectiveCTokens.HashTrigraphToken;

    public static OpeningSquareBracketTrigraphToken OpeningSquareBracketTrigraph => ObjectiveCTokens.OpeningSquareBracketTrigraphToken;

    public static BackslashTrigraphToken BackslashTrigraph => ObjectiveCTokens.BackslashTrigraphToken;

    public static ClosingSquareBracketTrigraphToken ClosingSquareBracketTrigraph => ObjectiveCTokens.ClosingSquareBracketTrigraphToken;

    public static CaretTrigraphToken CaretTrigraph => ObjectiveCTokens.CaretTrigraphToken;

    public static OpeningCurlyBraceTrigraphToken OpeningCurlyBraceTrigraph => ObjectiveCTokens.OpeningCurlyBraceTrigraphToken;

    public static VerticalSlashTrigraphToken VerticalSlashTrigraph => ObjectiveCTokens.VerticalSlashTrigraphToken;

    public static ClosingCurlyBraceTrigraphToken ClosingCurlyBraceTrigraph => ObjectiveCTokens.ClosingCurlyBraceTrigraphToken;

    public static TildeTrigraphToken TildeTrigraph => ObjectiveCTokens.TildeTrigraphToken;

    #endregion

    #endregion

    #region InternalNodes

    #endregion
}
