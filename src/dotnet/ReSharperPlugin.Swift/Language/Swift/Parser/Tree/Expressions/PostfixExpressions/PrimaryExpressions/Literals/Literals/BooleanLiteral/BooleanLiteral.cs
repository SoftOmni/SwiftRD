using System;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;
using ReSharperPlugin.Swift.Language.Semantics.Type.BuiltinTypes;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals;

public class BooleanLiteral : Literal<Bool, Boolean>
{
    public BooleanLiteral(IEditableBuffer buffer, NodeType nodeType)
        : base(buffer, nodeType)
    { }

    public BooleanLiteral(SwiftInternalNode parent, IEditableBuffer buffer, NodeType nodeType)
        : base(parent, buffer, nodeType)
    { }

    public override bool GetValueCopy()
    {
        throw new NotImplementedException();
    }

    public override void SetValue(bool newValue)
    {
        throw new NotImplementedException();
    }
}