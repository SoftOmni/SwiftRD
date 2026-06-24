using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions;

public abstract class PostfixExpressionInternalNode : SwiftCompositeNode, IPostfixExpression
{
    protected PostfixExpressionInternalNode(IEditableBuffer buffer)
        : base(buffer)
    { }

    protected PostfixExpressionInternalNode(SwiftCompositeNode parent, int index, IEditableBuffer editableBuffer, IEnumerable<ISwiftNode<SwiftCompositeNode>>? children = null)
        : base(parent, index, editableBuffer, children)
    { }

    protected PostfixExpressionInternalNode(SwiftCompositeNode parent, int index, int textIndex, int lengthInParent, IEnumerable<ISwiftNode<SwiftCompositeNode>>? children = null)
        : base(parent, index, textIndex, lengthInParent, children)
    { }

    protected PostfixExpressionInternalNode(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children)
        : base(buffer, children)
    { }
    
    public abstract IType ReturnType { get; }
    
    IReadOnlyType IReadOnlyBaseExpression.ReturnType => ReturnType;
}
