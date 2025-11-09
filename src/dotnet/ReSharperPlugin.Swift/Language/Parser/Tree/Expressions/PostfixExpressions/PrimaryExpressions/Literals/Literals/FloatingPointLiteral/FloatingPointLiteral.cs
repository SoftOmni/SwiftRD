

using ExtendedNumerics;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Semantics.Type.BuiltinTypes;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals;

public class FloatingPointLiteral : Literal<Double, BigDecimal>
{
    public FloatingPointLiteral(IEditableBuffer buffer)
        : base(buffer, NodeTypes.NodeTypes.FloatingPointLiteral)
    { }

    public FloatingPointLiteral(ISwiftNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.FloatingPointLiteral)
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