using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.GetterSetterBlocks.KeywordBlocks.Clauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.GetterSetterBlocks.RegularBlocks;

public class DiscreteGetterSetterGetterSetterKeywordBlock : SwiftCompositeNode,
    IDiscreteGetterSetterGetterSetterKeywordBlock
{
    public LeftCurlyBrace GetterSetterClauseStart { get; }

    public IGetterKeywordClause GetterClause { get; }

    public ISetterKeywordClause? SetterClause { get; }

    public RightCurlyBrace GetterSetterClauseEnd { get; }

    internal DiscreteGetterSetterGetterSetterKeywordBlock(IEditableBuffer buffer,
        IEnumerable<ISwiftNode<SwiftCompositeNode>> children, LeftCurlyBrace getterSetterClauseStart,
        IGetterKeywordClause getterClause, ISetterKeywordClause? setterClause, RightCurlyBrace getterSetterClauseEnd)
        : base(buffer, children)
    {
        GetterSetterClauseStart = getterSetterClauseStart;
        GetterClause = getterClause;
        SetterClause = setterClause;
        GetterSetterClauseEnd = getterSetterClauseEnd;
    }

    IReadOnlyGetterKeywordClause IReadOnlyDiscreteGetterSetterGetterSetterKeywordBlock.GetterClause => GetterClause;

    IReadOnlySetterKeywordClause? IReadOnlyDiscreteGetterSetterGetterSetterKeywordBlock.SetterClause => SetterClause;

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

    public void ChangeGetterClause(IGetterKeywordClause newGetterClause)
    {
        throw new NotImplementedException();
    }

    public void SetSetterClauseTo(ISetterKeywordClause? setterClause)
    {
        throw new NotImplementedException();
    }

    public void RemoveSetterClause()
    {
        throw new NotImplementedException();
    }
}
