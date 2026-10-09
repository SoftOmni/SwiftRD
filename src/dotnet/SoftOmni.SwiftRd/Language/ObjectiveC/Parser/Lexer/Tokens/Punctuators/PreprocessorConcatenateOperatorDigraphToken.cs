using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class PreprocessorConcatenateOperatorDigraphToken : PunctuatorToken<PreprocessorConcatenateOperatorDigraph>
{
    internal PreprocessorConcatenateOperatorDigraphToken()
        : base(ObjectiveCTokens.PreprocessorConcatenateOperatorDigraphId, ObjectiveCTokens.PreprocessorConcatenateOperatorDigraphIndex)
    { }
}