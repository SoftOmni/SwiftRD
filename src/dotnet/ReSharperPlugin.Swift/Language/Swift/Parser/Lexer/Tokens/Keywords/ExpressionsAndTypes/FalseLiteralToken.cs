using System;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Semantics.Type.BuiltinTypes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Literals;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ExpressionsAndTypes;

public class FalseLiteralToken : SwiftLiteral
{
    public FalseLiteralToken()
        : base(SwiftTokens.FalseId, SwiftTokens.FalseIndex)
    { }

    public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        throw new NotImplementedException();
    }

    public override bool IsConstantLiteral => true;

    public override bool ExpressionAndTypeUsable => true;

    public override string TokenRepresentation => SwiftTokens.FalseId;
}

public class FalseBackingLiteralToken : TokenLiteralBacker<Bool, bool>
{
    public FalseBackingLiteralToken()
        : base(Bool.Instance, false, Keyword, SwiftTokens.FalseIndex)
    { }

    public const string Keyword = "false";
}
