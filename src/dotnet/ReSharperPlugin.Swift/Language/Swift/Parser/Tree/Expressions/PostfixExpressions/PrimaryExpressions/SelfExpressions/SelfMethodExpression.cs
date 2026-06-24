using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ISelfExpressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.SelfExpressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace ReSharperPlugin.Swift.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.SelfExpressions;

public class SelfMethodExpression : SwiftCompositeNode, ISelfMethodExpression
{
    public SelfLowercase SelfLowercase { get; }

    public Period Period { get; }

    public IIdentifier MethodName { get; }

    internal SelfMethodExpression(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        SelfLowercase selfLowercase, Period period, IIdentifier methodName)
        : base(buffer, children)
    {
        SelfLowercase = selfLowercase;
        Period = period;
        MethodName = methodName;

        ReturnType = UnknownType.Instance;
    }

    IReadOnlyIdentifier IReadOnlySelfMethodExpression.MethodName => MethodName;

    public IType ReturnType { get; }

    IReadOnlyType IReadOnlyBaseExpression.ReturnType => ReturnType;

    public void ChangeMethodName(IIdentifier newMethodName)
    {
        throw new System.NotImplementedException();
    }
}
