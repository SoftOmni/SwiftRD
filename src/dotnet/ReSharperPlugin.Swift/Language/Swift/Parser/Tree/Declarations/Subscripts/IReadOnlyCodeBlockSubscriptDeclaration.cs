using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.CodeBlocks;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Subscripts;

public interface IReadOnlyCodeBlockSubscriptDeclaration : IReadOnlySubscriptDeclaration
{
    IReadOnlyCodeBlock CodeBlock { get; }
}
