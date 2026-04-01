using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.InfixExpressions.TypeCastingOperators;

public abstract class TypeCastingOperator : SwiftInternalNode
{
    public IType Type { get; internal set; }
    
    protected TypeCastingOperator(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    protected TypeCastingOperator(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    protected TypeCastingOperator(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    protected TypeCastingOperator(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}