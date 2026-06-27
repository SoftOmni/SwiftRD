using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions.ClosureSignatures;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions;

public interface IReadOnlyClosureExpression : IReadOnlyPrimaryExpression
{
    LeftCurlyBrace LeftCurlyBrace { get; }
    
    IReadOnlyAttributeGroup? AttributeGroup { get; }
    
    IReadOnlyClosureSignature? Signature { get; }
    
    IReadOnlyList<IReadOnlyStatement> Statements { get; }
    
    RightCurlyBrace RightCurlyBrace { get; }
}
