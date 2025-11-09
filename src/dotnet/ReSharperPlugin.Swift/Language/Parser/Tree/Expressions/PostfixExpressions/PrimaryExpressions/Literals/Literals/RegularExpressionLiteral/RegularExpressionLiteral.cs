using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Semantics.Type;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals;

public class Regex : Type;

public class RegexCs;

public class RegularExpressionLiteral : Literal<Regex, RegexCs>
{
    public RegularExpressionLiteral(IEditableBuffer buffer)
        : base(buffer, NodeTypes.NodeTypes.RegularExpressionLiteral)
    { }

    public RegularExpressionLiteral(ISwiftNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.RegularExpressionLiteral)
    { }

    public override RegexCs GetValueCopy()
    {
        throw new System.NotImplementedException();
    }

    public override void SetValue(RegexCs newValue)
    {
        throw new System.NotImplementedException();
    }
}