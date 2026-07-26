using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Switches.SwitchCases.
    DefaultSwitchCases;

public class DefaultLabel : SwiftCompositeNode, IDefaultLabel
{
    public IAttributeGroup? AttributeGroup { get; }

    public Default Default { get; }

    public Colon DefaultCaseStartColon { get; }

    internal DefaultLabel(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IAttributeGroup? attributeGroup, Default @default, Colon defaultCaseStartColon)
        : base(buffer, children)
    {
        AttributeGroup = attributeGroup;
        Default = @default;
        DefaultCaseStartColon = defaultCaseStartColon;
    }

    IReadOnlyAttributeGroup? IReadOnlyDefaultLabel.AttributeGroup => AttributeGroup;

    public void SetAttributeGroup(IAttributeGroup? newAttributeGroup)
    {
        throw new NotImplementedException();
    }

    public void RemoveAttributeGroup()
    {
        throw new NotImplementedException();
    }
}
