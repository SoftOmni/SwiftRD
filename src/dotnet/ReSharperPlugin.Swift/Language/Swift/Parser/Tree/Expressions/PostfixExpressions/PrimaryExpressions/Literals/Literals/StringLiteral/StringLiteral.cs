using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Semantics.Type.BuiltinTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals;

public class StringLiteral : Literal<String, string>
{
    public StringLiteral(IEditableBuffer buffer, NodeType nodeType)
        : base(buffer, nodeType)
    { }

    public StringLiteral(SwiftInternalNode parent, IEditableBuffer buffer, NodeType nodeType)
        : base(parent, buffer, nodeType)
    { }

    public override string GetValueCopy()
    {
        throw new System.NotImplementedException();
    }

    public override void SetValue(string newValue)
    {
        throw new System.NotImplementedException();
    }
}