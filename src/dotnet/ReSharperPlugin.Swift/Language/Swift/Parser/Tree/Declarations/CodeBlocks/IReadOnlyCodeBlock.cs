using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.StatementGroups;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.CodeBlocks;

public interface ICodeBlockUsage;

public interface IReadOnlyCodeBlock : IReadOnlyDeclaration, IReadOnlyList<IReadOnlyStatement>
{
    LeftCurlyBrace LeftCurlyBrace { get; }
    
    IReadOnlyStatementGroup StatementGroup { get; }
    
    RightCurlyBrace RightCurlyBrace { get; }
    
    new IReadOnlyStatement this[int index] { get; }
}
