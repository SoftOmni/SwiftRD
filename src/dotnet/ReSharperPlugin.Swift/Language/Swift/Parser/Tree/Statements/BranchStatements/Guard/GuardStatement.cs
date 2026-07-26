using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.CodeBlocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Ifs;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.Conditions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Guard;

public class GuardStatement : SwiftCompositeNode, IGuardStatement
{
    public Guard Guard { get; }

    public IConditionList Conditions { get; }

    public Else Else { get; }

    public ICodeBlock CodeBlock { get; }

    internal GuardStatement(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        Guard guard, IConditionList conditions, Else @else, ICodeBlock codeBlock)
        : base(buffer, children)
    {
        Guard = guard;
        Conditions = conditions;
        Else = @else;
        CodeBlock = codeBlock;
    }

    IReadOnlyConditionList IReadOnlyGuardStatement.Conditions => Conditions;

    IReadOnlyCodeBlock IReadOnlyGuardStatement.CodeBlock => CodeBlock;

    public void ChangeConditionsList(IConditionList newConditionList)
    {
        throw new NotImplementedException();
    }

    public void ChanceCodeBlock(ICodeBlock newCodeBlock)
    {
        throw new NotImplementedException();
    }
}