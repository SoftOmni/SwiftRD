using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.ExplicitMemberExpressions;

public class ExplicitMemberExpressionBasedOnConditionalCompilation
    : SwiftCompositeNode, IExplicitMemberExpressionBasedOnConditionalCompilation
{
    public IPostfixExpression PostfixExpression { get; }

    public IConditionalCompilationBlock ConditionalCompilationBlock { get; }

    internal ExplicitMemberExpressionBasedOnConditionalCompilation(IEditableBuffer buffer,
        IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IPostfixExpression postfixExpression, IConditionalCompilationBlock conditionalCompilationBlock)
        : base(buffer, children)
    {
        PostfixExpression = postfixExpression;
        ConditionalCompilationBlock = conditionalCompilationBlock;

        ReturnType = UnknownType.Instance;
    }

    IReadOnlyPostfixExpression IReadOnlyExplicitMemberExpression.PostfixExpression => PostfixExpression;

    IReadOnlyConditionalCompilationBlock IReadOnlyExplicitMemberExpressionBasedOnConditionalCompilation.ConditionalCompilationBlock =>
        ConditionalCompilationBlock;

    public IType ReturnType { get; }

    IReadOnlyType IReadOnlyBaseExpression.ReturnType => ReturnType;

    public void ChangePostfixExpression(IPostfixExpression newPostfixExpression)
    {
        throw new NotImplementedException();
    }

    public void ChangeConditionalCompilationBlock(IConditionalCompilationBlock newConditionalCompilationBlock)
    {
        throw new NotImplementedException();
    }
}
