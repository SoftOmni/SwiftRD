using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Wildcards;

public class WildcardExpression : SwiftCompositeNode, IWildcardExpression
{

    public Wildcard Wildcard { get; }

    public IType ReturnType { get; internal set; }

    internal WildcardExpression(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        Wildcard wildcard)
        : base(buffer, children)
    {
        Wildcard = wildcard;
        ReturnType = SetDefaultReturnType();
    }

    IReadOnlyType IReadOnlyBaseExpression.ReturnType => ReturnType;

    internal void SetReturnType(IType newReturnType)
    {
        throw new NotImplementedException();
    }

    private static IType SetDefaultReturnType()
    {
        return UnknownType.Instance;
    }
}
