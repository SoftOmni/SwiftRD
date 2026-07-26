using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Switches.SwitchCases;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LabeledStatements;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Switches;

public interface IReadOnlySwitchStatement : IReadOnlyBranchStatement, IReadOnlyLabelableStatement, IReadOnlyList<IReadOnlySwitchCase>
{
    Switch Switch { get; }
    
    IReadOnlyExpression ConditionExpression { get; }
    
    LeftCurlyBrace CasesStartCurlyBrace { get; }
    
    IReadOnlyList<IReadOnlySwitchCase> SwitchCases { get; }
    
    RightCurlyBrace CasesEndCurlyBrace { get; }
}
