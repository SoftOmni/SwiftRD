using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.TupleExpressions;

public class TupleElement
{
    public Identifier? Identifier { get; internal set; }
    
    public Colon? Colon { get; internal set; }
    
    public Expression? Expression { get; internal set; }
}