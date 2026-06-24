using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ISuperClassExpressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.SuperClassExpressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace ReSharperPlugin.Swift.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.SuperClassExpressions;

public class SuperClassExpressionStandalone : SwiftCompositeNode, ISuperClassExpression
{
    public Super Super { get; }

    internal SuperClassExpressionStandalone(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        Super super)
        : base(buffer, children)
    {
        Super = super;

        ReturnType = UnknownType.Instance;
    }

    public IType ReturnType { get; }

    IReadOnlyType IReadOnlyBaseExpression.ReturnType => ReturnType;
}
