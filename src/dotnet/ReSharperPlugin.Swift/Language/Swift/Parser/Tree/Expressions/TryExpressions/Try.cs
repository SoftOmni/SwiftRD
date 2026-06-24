using System;
using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Whitespace;
using SoftOmni.SwiftRd.Technology;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.TryOperators;

public class Try : SwiftLeafNode<SwiftCompositeNode>, ISwiftKeywordNode<Try>
{
    public const string Keyword = "try";
    
    public IReadOnlyTryExpression? TryOperator { get; internal set; }
    
    public Try()
        : base(new EditableBuffer(Keyword))
    { }

    internal Try(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Try;

    public string KeywordValue => Keyword;

    public static Try Create()
    {
        return new Try(new EditableBuffer(Keyword));
    }

    public static ITryExpression CreateExpression(IReadOnlyTryExpression.ExpressionKind kind)
    {
        IEditableBuffer tryExpressionBuffer = new EditableBuffer(Keyword);
        IEditableBuffer tryKeywordBuffer = new SubEditableBuffer(tryExpressionBuffer, 0, Keyword.Length);
        Try @try = new(tryKeywordBuffer);

        TryExpression expression = new(tryKeywordBuffer, [@try], @try);
        expression.InsertChild(1, WhitespaceSequence.CreateFromValue(" "));
        switch (kind)
        {
            case IReadOnlyTryExpression.ExpressionKind.TryExpression:
                return expression;
            case IReadOnlyTryExpression.ExpressionKind.OptionalTryExpression:
                expression.MakeOptionalTryExpression();
                return expression;
            case IReadOnlyTryExpression.ExpressionKind.ForcedTryExpression:
                expression.MakeForcedTryExpression();
                return expression;
            default:
                throw new ArgumentOutOfRangeException(nameof(kind), kind, null);
        }
    }
}