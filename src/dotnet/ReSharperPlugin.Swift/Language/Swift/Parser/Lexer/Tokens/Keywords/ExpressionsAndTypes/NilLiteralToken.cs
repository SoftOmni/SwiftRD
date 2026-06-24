using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Literals;
using SoftOmni.SwiftRd.Language.Semantics.Type.BuiltinTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ExpressionsAndTypes;

public class NilLiteralToken : SwiftLiteral
{
    public NilLiteralToken()
        : base(SwiftTokens.NilId, SwiftTokens.NilIndex)
    { }

    public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        throw new System.NotImplementedException();
    }

    public override bool IsConstantLiteral => true;

    public override bool ExpressionAndTypeUsable => true;

    public override string TokenRepresentation => SwiftTokens.NilId;
}

public class NilBackingLiteralToken : TokenLiteralBacker<Nil, object?>
{
    public NilBackingLiteralToken()
        : base(Nil.Instance, null, Keyword, SwiftTokens.FalseIndex)
    { }

    public const string Keyword = "nil";
}
