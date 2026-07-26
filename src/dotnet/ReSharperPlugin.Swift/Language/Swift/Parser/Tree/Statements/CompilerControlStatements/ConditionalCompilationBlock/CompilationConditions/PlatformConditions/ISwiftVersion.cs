using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.IntegerLiterals;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.CompilationConditions.PlatformConditions;

public interface ISwiftVersion : IReadOnlySwiftVersion, IList<IIntegerLiteral>
{
    new IReadOnlyList<IIntegerLiteral> Values { get; }
    
    new int Count { get; }

    new IEnumerator<IIntegerLiteral> GetEnumerator();
    
    new IIntegerLiteral this[int index] { get; set; }
}
