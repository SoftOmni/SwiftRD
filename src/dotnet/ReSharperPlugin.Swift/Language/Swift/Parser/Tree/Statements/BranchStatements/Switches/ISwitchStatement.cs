using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Switches.SwitchCases;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LabeledStatements;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Switches;

public interface ISwitchStatement : IBranchStatement, IReadOnlySwitchStatement, ILabelableStatement, IList<ISwitchCase>
{
    new IExpression ConditionExpression { get; }

    void ChangeConditionExpression(IExpression expression);
    
    new IReadOnlyList<ISwitchCase> SwitchCases { get; }
    
    new int Count { get; }

    new IEnumerator<ISwitchCase> GetEnumerator();
    
    new ISwitchCase this[int index] { get; set; }
}
