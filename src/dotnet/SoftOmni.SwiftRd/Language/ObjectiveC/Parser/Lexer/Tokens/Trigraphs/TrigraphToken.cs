using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Base;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Trigraphs;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Trigraphs;

public abstract class TrigraphToken(string name, int index)
    : ObjectiveCTokenNodeType(name, index)
{
    public abstract char ReplacementCharacter { get; }

    public override string TokenRepresentation { get; } = name;
}

public abstract class TrigraphToken<TAstLeafNode>(string name, int index)
    : TrigraphToken(name, index)
where TAstLeafNode : LeafElementBase, ITrigraph, new()
{
    public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        CheckAgainstValue(TokenRepresentation, buffer, Name);
        return new TAstLeafNode();
    }
}
