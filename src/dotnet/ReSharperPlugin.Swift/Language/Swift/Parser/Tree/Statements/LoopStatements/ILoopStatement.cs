using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.CodeBlocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.ControlTransferStatements;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LabeledStatements;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements;

public interface ILoopStatement : IReadOnlyLoopStatement, ILabelableStatement
{
    new ICodeBlock CodeBlock { get; }

    void ChangeCodeBlock(ICodeBlock newCodeBlock);    
    
    new IReadOnlyList<IControlTransferStatement> LoopControlTransferStatements { get; }
}
