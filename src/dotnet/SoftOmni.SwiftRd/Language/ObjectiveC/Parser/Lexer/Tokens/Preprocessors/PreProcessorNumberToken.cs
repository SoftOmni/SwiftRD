using System.Numerics;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Base;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Literals;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Preprocessors;

public sealed class PreProcessorNumberToken : ObjectiveCTokenNodeType
{
    internal PreProcessorNumberToken()
        : base(ObjectiveCTokens.PreProcessorNumberTokenId, ObjectiveCTokens.PreProcessorNumberTokenIndex)
    { }

    public override bool IsConstantLiteral => true;

    public override string TokenRepresentation => ObjectiveCTokens.PreProcessorNumberTokenId;

    public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        throw new System.NotImplementedException();
    }
}

public class PreProcessorBackingNumberToken(BigInteger valueOfContents, string value)
: TokenLiteralBacker<BigInteger>(valueOfContents, value, ObjectiveCTokens.PreProcessorNumberTokenIndex);
