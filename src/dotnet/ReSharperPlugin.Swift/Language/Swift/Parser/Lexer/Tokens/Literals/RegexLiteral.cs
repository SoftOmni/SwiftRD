using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Semantics.Type.BuiltinTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Literals;

public class RegexLiteral()
    : SwiftLiteral(SwiftTokens.RegularExpressionLiteralId, SwiftTokens.RegularExpressionLiteralIndex)
{
    public override string TokenRepresentation { get; } = SwiftTokens.RegularExpressionLiteralId;
    
    public override bool IsConstantLiteral => true;

    public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        throw new System.NotImplementedException();
    }
}

public class RegexBackingLiteralToken(RegularExpression valueOfContents, string value)
    : TokenLiteralBacker<Regex, RegularExpression>(Regex.Instance, valueOfContents, value, SwiftTokens.FalseIndex)
{
    public const string Keyword = "false";
}