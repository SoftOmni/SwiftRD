using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals;

public class FalseBooleanLiteral : BooleanLiteral
{
    public FalseBooleanLiteral()
        : base(new EditableBuffer("false"), false)
    { }
    
    internal FalseBooleanLiteral(IEditableBuffer buffer)
        : base(buffer, false)
    { }

    internal FalseBooleanLiteral(IEditableBuffer underlyingBuffer, SwiftCompositeNode parentNode, int parentIndex, int parentTextIndex)
        : base(underlyingBuffer, parentNode, parentIndex, parentTextIndex, false)
    { }

    public override NodeType NodeType => SwiftNodeTypes.False;

    public override bool IsTrue() => false;

    public override bool IsFalse() => true;
}