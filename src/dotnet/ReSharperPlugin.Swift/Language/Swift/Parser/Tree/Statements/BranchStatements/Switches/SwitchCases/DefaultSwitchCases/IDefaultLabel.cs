using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Switches.SwitchCases.DefaultSwitchCases;

public interface IDefaultLabel : IReadOnlyDefaultLabel
{
    new IAttributeGroup? AttributeGroup { get; }

    void SetAttributeGroup(IAttributeGroup? newAttributeGroup);

    void RemoveAttributeGroup();
}
