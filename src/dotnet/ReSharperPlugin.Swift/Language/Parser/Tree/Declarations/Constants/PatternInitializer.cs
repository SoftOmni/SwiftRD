using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Expressions;
using ReSharperPlugin.Swift.Language.Parser.Tree.Patterns;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Constants;

public class PatternInitializer : SwiftInternalNode
{
    public Pattern? Pattern { get; private set; }
    
    public Expression? Expression { get; private set; }
    
    public PatternInitializer(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public PatternInitializer(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public PatternInitializer(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public PatternInitializer(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}