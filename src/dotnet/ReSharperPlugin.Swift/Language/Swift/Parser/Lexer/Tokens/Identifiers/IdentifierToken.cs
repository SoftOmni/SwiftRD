using System;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Base;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Identifiers;

public class IdentifierToken : SwiftTokenNodeType
{
    internal IdentifierToken()
        : base(SwiftTokens.IdentifierId, SwiftTokens.IdentifierIndex)
    { }

    public override string TokenRepresentation { get; } = SwiftTokens.IdentifierId;

    public override bool IsIdentifier => true;

    public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        throw new NotImplementedException();
    }
}
