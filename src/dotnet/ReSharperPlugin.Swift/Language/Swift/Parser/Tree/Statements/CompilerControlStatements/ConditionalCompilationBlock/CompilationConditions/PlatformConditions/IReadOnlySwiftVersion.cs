using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.IntegerLiterals;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.CompilationConditions.PlatformConditions;

public interface IReadOnlySwiftVersion : ISwiftInternalNode<SwiftCompositeNode>, 
    IReadOnlyList<IReadOnlyIntegerLiteral>
{
    IReadOnlyList<IReadOnlyIntegerLiteral> Values { get; }
    
    IReadOnlyList<Period> ValueSeparators { get; }
    
    new IReadOnlyIntegerLiteral this[int index] { get; }
}
