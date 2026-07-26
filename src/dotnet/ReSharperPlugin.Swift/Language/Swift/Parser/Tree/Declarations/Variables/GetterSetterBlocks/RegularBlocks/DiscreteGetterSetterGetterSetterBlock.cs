using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.GetterSetterBlocks.RegularBlocks.Clauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.GetterSetterBlocks.RegularBlocks;

public class DiscreteGetterSetterGetterSetterBlock : SwiftCompositeNode,
    IDiscreteGetterSetterGetterSetterBlock
{
    public LeftCurlyBrace GetterSetterClauseStart { get; }

    public IGetterClause GetterClause { get; }

    public ISetterClause? SetterClause { get; }

    public RightCurlyBrace GetterSetterClauseEnd { get; }

    internal DiscreteGetterSetterGetterSetterBlock(IEditableBuffer buffer,
        IEnumerable<ISwiftNode<SwiftCompositeNode>> children, LeftCurlyBrace getterSetterClauseStart,
        IGetterClause getterClause, ISetterClause? setterClause, RightCurlyBrace getterSetterClauseEnd)
        : base(buffer, children)
    {
        GetterSetterClauseStart = getterSetterClauseStart;
        GetterClause = getterClause;
        SetterClause = setterClause;
        GetterSetterClauseEnd = getterSetterClauseEnd;
    }

    IReadOnlyGetterClause IReadOnlyDiscreteGetterSetterGetterSetterBlock.GetterClause => GetterClause;

    IReadOnlySetterClause? IReadOnlyDiscreteGetterSetterGetterSetterBlock.SetterClause => SetterClause;

    public bool IsGetterFirst()
    {
        return SetterClause is null || SetterClause.ParentIndex < GetterClause.ParentIndex;
    }

    public bool IsSetterFirst()
    {
        return SetterClause is not null && SetterClause.ParentIndex > GetterClause.ParentIndex;
    }

    public bool CanSwapPositions()
    {
        throw new NotImplementedException();
    }

    public void SwapPositions()
    {
        throw new NotImplementedException();
    }

    public void ChangeGetterClause(IGetterClause newGetterClause)
    {
        throw new NotImplementedException();
    }

    public void SetSetterClauseTo(ISetterClause? setterClause)
    {
        throw new NotImplementedException();
    }

    public void RemoveSetterClause()
    {
        throw new NotImplementedException();
    }
}
