using ReSharperPlugin.Swift.Language.Parser.Tree.Identifiers;
using ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.TupleExpressions;

public class TupleElement
{
    public Identifier? Identifier { get; internal set; }
    
    public Colon? Colon { get; internal set; }
    
    public Expression? Expression { get; internal set; }
}