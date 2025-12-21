using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Constants;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Statements.LoopStatements.Conditions;

public class LetOptionalBindingCondition : OptionalBindingCondition
{
    public Let? Let { get; internal set; }
    
    public LetOptionalBindingCondition(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public LetOptionalBindingCondition(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public LetOptionalBindingCondition(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public LetOptionalBindingCondition(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}