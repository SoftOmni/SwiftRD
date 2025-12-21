using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens;
using ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.DeclarationModifiers.ActorIsolationModifiers;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.NodeTypes.Keywords.Declarations;

public class NonIsolatedNodeType : DeclarationNodeType
{
    internal NonIsolatedNodeType()
        : base(SwiftTokens.NonIsolatedId, SwiftTokens.NonIsolatedIndex)
    { }

    public override LeafElementBase Create(IEditableBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        return NonIsolated.Create();
    }
}