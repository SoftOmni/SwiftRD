using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.CodeBlocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.ControlTransferStatements;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.Conditions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.WhileLoops;

public class WhileStatement : SwiftCompositeNode, IWhileStatement
{
    public While While { get;}

    public IConditionList ConditionList { get; }
    
    public ICodeBlock CodeBlock { get; }
    
    internal List<IControlTransferStatement> ControlTransferStatements { get; }

    internal WhileStatement(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children, 
        While @while, IConditionList conditionList, ICodeBlock codeBlock)
        : base(buffer, children)
    {
        While = @while;
        ConditionList = conditionList;
        CodeBlock = codeBlock;

        ControlTransferStatements = [];
    }
    
    IReadOnlyConditionList IReadOnlyWhileStatement.ConditionList => ConditionList;
    
    IReadOnlyCodeBlock IReadOnlyLoopStatement.CodeBlock => CodeBlock;

    public IReadOnlyList<IControlTransferStatement> LoopControlTransferStatements => ControlTransferStatements;

    IReadOnlyList<IReadOnlyControlTransferStatement> IReadOnlyLoopStatement.LoopControlTransferStatements =>
        LoopControlTransferStatements;

    public void ChangeCodeBlock(ICodeBlock newCodeBlock)
    {
        throw new NotImplementedException();
    }

    public void ChangeConditionList(IConditionList newConditionsList)
    {
        throw new NotImplementedException();
    }
}
