using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions.
    ClosureSignatures;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.
    ClosureExpressions;

public class ClosureExpression : SwiftCompositeNode, IClosureExpression
{
    public LeftCurlyBrace LeftCurlyBrace { get; }
    
    public IAttributeGroup? AttributeGroup { get; }

    public IClosureSignature? Signature { get; }

    private readonly List<IStatement> _statements;

    public RightCurlyBrace RightCurlyBrace { get; }

    internal ClosureExpression(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        LeftCurlyBrace leftCurlyBrace,
        List<IStatement> statements, RightCurlyBrace rightCurlyBrace)
        : base(buffer, children)
    {
        LeftCurlyBrace = leftCurlyBrace;
        _statements = statements;
        RightCurlyBrace = rightCurlyBrace;
    }

    internal ClosureExpression(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        LeftCurlyBrace leftCurlyBrace,
        IAttributeGroup? attributeGroup, List<IStatement> statements, RightCurlyBrace rightCurlyBrace)
        : base(buffer, children)
    {
        LeftCurlyBrace = leftCurlyBrace;
        AttributeGroup = attributeGroup;
        _statements = statements;
        RightCurlyBrace = rightCurlyBrace;
    }

    internal ClosureExpression(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        LeftCurlyBrace leftCurlyBrace,
        IClosureSignature? signature, List<IStatement> statements, RightCurlyBrace rightCurlyBrace)
        : base(buffer, children)
    {
        LeftCurlyBrace = leftCurlyBrace;
        Signature = signature;
        _statements = statements;
        RightCurlyBrace = rightCurlyBrace;
    }

    internal ClosureExpression(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        LeftCurlyBrace leftCurlyBrace,
        IAttributeGroup? attributeGroup, IClosureSignature? signature, List<IStatement> statements,
        RightCurlyBrace rightCurlyBrace)
        : base(buffer, children)
    {
        LeftCurlyBrace = leftCurlyBrace;
        AttributeGroup = attributeGroup;
        Signature = signature;
        _statements = statements;
        RightCurlyBrace = rightCurlyBrace;
    }

    IReadOnlyAttributeGroup? IReadOnlyClosureExpression.AttributeGroup => AttributeGroup;

    IReadOnlyClosureSignature? IReadOnlyClosureExpression.Signature => Signature;

    public IReadOnlyList<IStatement> Statements => _statements;

    IReadOnlyList<IReadOnlyStatement> IReadOnlyClosureExpression.Statements => Statements;

    public IType ReturnType
    {
        get
        {
            if (Signature is IClauseBasedClosureSignature clauseBasedClosureSignature)
            {
                return clauseBasedClosureSignature.FunctionResult?.Type ?? UnknownType.Instance;
            }
            
            return UnknownType.Instance;
        }
    }

    IReadOnlyType IReadOnlyBaseExpression.ReturnType => ReturnType;

    public void SetAttributeGroupTo(IAttributeGroup? attributeGroup)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAttributeGroup()
    {
        throw new System.NotImplementedException();
    }

    public void SetClosureSignatureTo(IClosureSignature? closureSignature)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveClosureSignature()
    {
        throw new System.NotImplementedException();
    }
}
