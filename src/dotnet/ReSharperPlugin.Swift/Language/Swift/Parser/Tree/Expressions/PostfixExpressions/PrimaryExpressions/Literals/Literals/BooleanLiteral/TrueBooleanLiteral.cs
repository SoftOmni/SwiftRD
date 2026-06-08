using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals;

public class TrueBooleanLiteral : BooleanLiteral
{
    public TrueBooleanLiteral()
        : base(new EditableBuffer("true"), true)
    { }
    
    internal TrueBooleanLiteral(IEditableBuffer buffer)
        : base(buffer, true)
    { }

    internal TrueBooleanLiteral(IEditableBuffer underlyingBuffer, SwiftCompositeNode parentNode, int parentIndex, int parentTextIndex)
        : base(underlyingBuffer, parentNode, parentIndex, parentTextIndex, true)
    { }

    public override NodeType NodeType => SwiftNodeTypes.True;

    public override bool IsTrue() => true;

    public override bool IsFalse() => false;
}