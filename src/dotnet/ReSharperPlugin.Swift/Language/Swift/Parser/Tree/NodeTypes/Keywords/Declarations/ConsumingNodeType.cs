using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses.ParameterModifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes.Keywords.Declarations;

public class ConsumingNodeType : DeclarationNodeType
{
    internal ConsumingNodeType()
        : base(SwiftTokens.ConsumingId, SwiftTokens.ConsumingIndex)
    { }

    public override LeafElementBase Create(IEditableBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        return Consuming.Create();
    }
}
