using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.CodeBlocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.ControlTransferStatements;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.WhileLoops;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.RepeatWhileStatements;

public class RepeatWhileStatement : SwiftCompositeNode, IRepeatWhileStatement
{
    public Repeat Repeat { get; }
    
    public ICodeBlock CodeBlock { get; }
    
    public While While { get; }
    
    public IExpression ConditionExpression { get; }
    
    internal List<IControlTransferStatement> ControlTransferStatements { get; }

    internal RepeatWhileStatement(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children, 
        Repeat repeat, ICodeBlock codeBlock, While @while, IExpression conditionExpression)
        : base(buffer, children)
    {
        Repeat = repeat;
        CodeBlock = codeBlock;
        While = @while;
        ConditionExpression = conditionExpression;

        ControlTransferStatements = [];
    }

    IReadOnlyCodeBlock IReadOnlyLoopStatement.CodeBlock => CodeBlock;

    IReadOnlyExpression IReadOnlyRepeatWhileStatement.ConditionExpression => ConditionExpression;

    public IReadOnlyList<IControlTransferStatement> LoopControlTransferStatements => ControlTransferStatements;

    IReadOnlyList<IReadOnlyControlTransferStatement> IReadOnlyLoopStatement.LoopControlTransferStatements => LoopControlTransferStatements;

    public void ChangeCodeBlock(ICodeBlock newCodeBlock)
    {
        throw new NotImplementedException();
    }
}
