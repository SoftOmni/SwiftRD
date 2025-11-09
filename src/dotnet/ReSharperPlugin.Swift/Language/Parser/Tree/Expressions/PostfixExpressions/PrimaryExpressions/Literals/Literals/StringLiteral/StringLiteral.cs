using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Semantics.Type.BuiltinTypes;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals;

public class StringLiteral : Literal<String, string>
{
    public StringLiteral(IEditableBuffer buffer, NodeType nodeType)
        : base(buffer, nodeType)
    { }

    public StringLiteral(ISwiftNode parent, IEditableBuffer buffer, NodeType nodeType)
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