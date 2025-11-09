using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Enumerations.Cases;
using ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Initializers;
using ReSharperPlugin.Swift.Language.Parser.Tree.Patterns;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Statements.LoopStatements.Conditions;

public class CaseCondition : SwiftInternalNode, ICondition
{
    public Case? Case { get; internal set; }
    
    public Pattern? Pattern { get; internal set; }
    
    public Initializer? Initializer { get; internal set; }
    
    public CaseCondition(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public CaseCondition(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public CaseCondition(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public CaseCondition(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}