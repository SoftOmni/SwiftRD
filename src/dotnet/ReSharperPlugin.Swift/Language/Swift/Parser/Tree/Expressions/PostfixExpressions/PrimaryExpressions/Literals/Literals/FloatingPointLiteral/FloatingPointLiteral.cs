

using ExtendedNumerics;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Semantics.Type.BuiltinTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals;

public class FloatingPointLiteral : Literal<Double, BigDecimal>
{
    public FloatingPointLiteral(IEditableBuffer buffer)
        : base(buffer, SwiftNodeTypes.FloatingPointLiteral)
    { }

    public FloatingPointLiteral(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.FloatingPointLiteral)
    { }

    public override BigDecimal GetValueCopy()
    {
        throw new System.NotImplementedException();
    }

    public override void SetValue(BigDecimal newValue)
    {
        throw new System.NotImplementedException();
    }
}