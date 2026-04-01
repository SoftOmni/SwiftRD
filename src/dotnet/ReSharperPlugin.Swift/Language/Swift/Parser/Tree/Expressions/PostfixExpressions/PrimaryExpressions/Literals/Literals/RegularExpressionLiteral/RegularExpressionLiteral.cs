using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Semantics.Type;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals;

public class Regex : Type;

public class RegexCs;

public class RegularExpressionLiteral : Literal<Regex, RegexCs>
{
    public RegularExpressionLiteral(IEditableBuffer buffer)
        : base(buffer, SwiftNodeTypes.RegularExpressionLiteral)
    { }

    public RegularExpressionLiteral(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.RegularExpressionLiteral)
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