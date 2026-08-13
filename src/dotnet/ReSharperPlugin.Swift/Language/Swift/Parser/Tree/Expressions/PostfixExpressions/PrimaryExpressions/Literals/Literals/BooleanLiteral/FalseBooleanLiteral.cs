using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;
using SoftOmni.SwiftRd.Language.Swift.Semantics.PrimitiveLiterals;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.
    Literals;

public class FalseBooleanLiteral : BooleanLiteral
{
    public const string Keyword = "false";
    
    public FalseBooleanLiteral()
        : base(new EditableBuffer("false"), false, new PrimitiveLiteralTypeResolutionContext())
    { }

    internal FalseBooleanLiteral(IEditableBuffer buffer,
        IPrimitiveLiteralTypeResolutionContext primitiveLiteralTypeResolutionContext)
        : base(buffer, false, primitiveLiteralTypeResolutionContext)
    { }

    public override NodeType NodeType => SwiftNodeTypes.False;

    public override IType ReturnType => PrimitiveLiteralTypeResolutionContext.DefaultBooleanLiteralType.Type;

    public override bool IsTrue() => false;

    public override bool IsFalse() => true;
}
