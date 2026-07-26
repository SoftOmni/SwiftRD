using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.CodeBlocks;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.DeferStatements;

public interface IReadOnlyDeferStatement : IReadOnlyStatement
{
    Defer Defer { get; }
    
    IReadOnlyCodeBlock CodeBlock { get; }
}
