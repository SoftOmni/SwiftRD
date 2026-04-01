using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers.Composite;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes.Keywords.Declarations;

public class SafeNoteType : DeclarationNodeType
{
    internal SafeNoteType()
        : base(SwiftTokens.SafeId, SwiftTokens.SafeIndex)
    { }

    public override LeafElementBase Create(IEditableBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        return Safe.Create();
    }
}