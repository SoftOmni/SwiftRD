using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Constants;

public class Initializer : SwiftCompositeNode, IInitializer
{
    public Equal AssignmentOperator { get; }

    public IExpression Expression { get; }

    internal Initializer(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        Equal assignmentOperator, IExpression expression)
        : base(buffer, children)
    {
        AssignmentOperator = assignmentOperator;
        Expression = expression;
    }

    IReadOnlyExpression IReadOnlyInitializer.Expression => Expression;

    public void ChangeExpression(IExpression newExpression)
    {
        throw new NotImplementedException();
    }
}
