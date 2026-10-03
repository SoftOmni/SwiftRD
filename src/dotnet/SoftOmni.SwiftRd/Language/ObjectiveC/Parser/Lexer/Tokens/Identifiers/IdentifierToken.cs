using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Base;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Identifiers;

public class IdentifierToken : ObjectiveCTokenNodeType
{
    internal IdentifierToken()
        : base(ObjectiveCTokens.IdentifierId, ObjectiveCTokens.IdentifierIndex)
    { }

    public override string TokenRepresentation => ObjectiveCTokens.IdentifierId;

    public override bool IsIdentifier => true;

    public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        throw new System.NotImplementedException();
    }
}
