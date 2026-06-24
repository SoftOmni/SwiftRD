using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;
using SoftOmni.SwiftRd.Language.Swift.Semantics.PrimitiveLiterals;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals;

public class TrueBooleanLiteral : BooleanLiteral
{
    public TrueBooleanLiteral()
        : base(new EditableBuffer("true"), true, new PrimitiveLiteralTypeResolutionContext())
    { }
    
    internal TrueBooleanLiteral(IEditableBuffer buffer, IPrimitiveLiteralTypeResolutionContext primitiveLiteralTypeResolutionContext)
        : base(buffer, true, primitiveLiteralTypeResolutionContext)
    { }
    
    /* TODO: think of more efficient internal node API for literals
       SwiftCompositeNode might need a */

    public override NodeType NodeType => SwiftNodeTypes.True;

    public override IType ReturnType => PrimitiveLiteralTypeResolutionContext.DefaultBooleanLiteralType.Type;

    public override bool IsTrue() => true;

    public override bool IsFalse() => false;
}
