using System;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Semantics.Type.BuiltinTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals;

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