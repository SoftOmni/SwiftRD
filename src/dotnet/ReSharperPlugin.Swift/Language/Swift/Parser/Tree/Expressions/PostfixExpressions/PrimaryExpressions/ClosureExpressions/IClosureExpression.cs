using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions.ClosureSignatures;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions;

public interface IClosureExpression : IReadOnlyClosureExpression, IPrimaryExpression
{
    new IAttributeGroup? AttributeGroup { get; }

    new IClosureSignature? Signature { get; }
    
    new IReadOnlyList<IStatement> Statements { get; }
    
    void SetAttributeGroupTo(IAttributeGroup? attributeGroup);

    void RemoveAttributeGroup();

    void SetClosureSignatureTo(IClosureSignature? closureSignature);

    void RemoveClosureSignature();
}
