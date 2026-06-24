using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.StatementGroups;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.CodeBlocks;

public interface ICodeBlock : IReadOnlyCodeBlock, IDeclaration<ICodeBlockUsage>, IList<IStatement>
{
    new IStatementGroup StatementGroup { get; }
    
    new IStatement this[int index] { get; set; }
    
    new int Count { get; }

    new bool IsReadOnly { get; }
    
    new void Clear();

    new IEnumerator<IStatement> GetEnumerator();
}
