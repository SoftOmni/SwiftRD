using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.CodeBlocks;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements;

public interface ILoopStatement : IReadOnlyLoopStatement, IStatement
{
    new ICodeBlock CodeBlock { get; }
}
