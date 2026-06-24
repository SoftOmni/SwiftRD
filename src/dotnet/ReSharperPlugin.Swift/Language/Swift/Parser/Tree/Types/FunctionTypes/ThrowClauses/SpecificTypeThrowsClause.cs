using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.FunctionTypes.ThrowClauses;

public class SpecificTypeThrowsClause : SwiftCompositeNode, ISpecificTypeThrowsClause
{
    public Throws Throws { get; }

    public LeftParenthesis LeftParenthesis { get; }
    
    public IType ErrorType { get; }

    public RightParenthesis RightParenthesis { get; }
    
    internal SpecificTypeThrowsClause(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        Throws throws, LeftParenthesis leftParenthesis, IType errorType, RightParenthesis rightParenthesis)
        : base(buffer, children)
    {
        Throws = throws;
        LeftParenthesis = leftParenthesis;
        ErrorType = errorType;
        RightParenthesis = rightParenthesis;
    }

    IReadOnlyType IReadOnlySpecificTypeThrowsClause.ErrorType => ErrorType;

    public void ChangeErrorType(IType type)
    {
        int errorTypeIndex = ErrorType.ParentIndex;
        ErrorType.DetachFromParent();

        AttachChild(errorTypeIndex, type);
    }
}
