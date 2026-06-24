using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ISuperClassExpressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.SuperClassExpressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace ReSharperPlugin.Swift.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.SuperClassExpressions;

public class SuperClassMethodExpression : SwiftCompositeNode, ISuperClassMethodExpression
{
    public Super Super { get; }

    public Period Period { get; }

    public IIdentifier MethodName { get; }

    internal SuperClassMethodExpression(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        Super super, Period period, IIdentifier methodName)
        : base(buffer, children)
    {
        Super = super;
        Period = period;
        MethodName = methodName;

        ReturnType = UnknownType.Instance;
    }

    IReadOnlyIdentifier IReadOnlySuperClassMethodExpression.MethodName => MethodName;

    public IType ReturnType { get; }

    IReadOnlyType IReadOnlyBaseExpression.ReturnType => ReturnType;

    public void ChangeMethodName(IIdentifier newMethodName)
    {
        throw new System.NotImplementedException();
    }
}
