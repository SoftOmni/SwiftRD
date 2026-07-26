using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.LineControlStatements;

public class LineControlStatement : SwiftCompositeNode, ILineControlStatement
{
    public ReservedSourceLocationKeyword SourceLocationKeyword { get; }
    
    public LeftParenthesis ArgumentsStart { get; }
    
    public RightParenthesis ArgumentsEnd { get; }

    internal LineControlStatement(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children, 
        ReservedSourceLocationKeyword sourceLocationKeyword, LeftParenthesis argumentsStart, RightParenthesis argumentsEnd)
        : base(buffer, children)
    {
        SourceLocationKeyword = sourceLocationKeyword;
        ArgumentsStart = argumentsStart;
        ArgumentsEnd = argumentsEnd;
    }
}
