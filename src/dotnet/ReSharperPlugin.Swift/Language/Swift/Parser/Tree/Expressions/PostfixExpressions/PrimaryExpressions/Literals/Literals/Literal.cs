using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Semantics.Type;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals;

public abstract class Literal<TSwiftType, TCSharpValueType> : LiteralExpressionLeafNode, ILiteral<TSwiftType, TCSharpValueType> where TSwiftType : Type
{
    public TSwiftType Type { get; }
    
    public TCSharpValueType Value { get; }

    public abstract TCSharpValueType GetValueCopy();

    public abstract void SetValue(TCSharpValueType newValue);

    protected Literal(IEditableBuffer buffer, NodeType nodeType)
        : base(buffer, nodeType)
    { }

    protected Literal(SwiftInternalNode parent, IEditableBuffer buffer, NodeType nodeType)
        : base(parent, buffer, nodeType)
    { }
}