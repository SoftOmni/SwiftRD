using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.CodeBlocks;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Subscripts;

public interface ICodeBlockSubscriptDeclaration : IReadOnlyCodeBlockSubscriptDeclaration, ISubscriptDeclaration
{
    new ICodeBlock CodeBlock { get; }

    void ChangeCodeBlock(ICodeBlock newCodeBlock);
}
