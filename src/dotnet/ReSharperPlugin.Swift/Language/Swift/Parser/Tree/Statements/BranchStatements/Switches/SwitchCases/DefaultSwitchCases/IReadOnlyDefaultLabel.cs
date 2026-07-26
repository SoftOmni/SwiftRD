using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Switches.SwitchCases.DefaultSwitchCases;

public interface IReadOnlyDefaultLabel
{
    IReadOnlyAttributeGroup? AttributeGroup { get; }
    
    Default Default { get; }
    
    Colon DefaultCaseStartColon { get; }
}
