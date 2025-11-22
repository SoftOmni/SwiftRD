using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Attributes;
using ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Statements.BranchStatements.Switches.SwitchCases.DefaultLabels;

public class DefaultLabel : SwitchCase
{
    public AttributeGroup? Attributes { get; internal set; }
    
    public Default? Default { get; internal set; }
    
    public Colon? Colon { get; internal set; }

    public DefaultLabel(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public DefaultLabel(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public DefaultLabel(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public DefaultLabel(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}