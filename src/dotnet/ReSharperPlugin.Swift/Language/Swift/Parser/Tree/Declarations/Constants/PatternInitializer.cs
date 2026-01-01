using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;
using ReSharperPlugin.Swift.Language.Parser.Tree.Expressions;
using ReSharperPlugin.Swift.Language.Parser.Tree.Patterns;
using ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Constants;

public class PatternInitializer : SwiftInternalNode
{
    public Pattern? Pattern { get; private set; }
    
    public Equal? Equal { get; private set; }
    
    public Expression? Expression { get; private set; }
    
    public PatternInitializer(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public PatternInitializer(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public PatternInitializer(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public PatternInitializer(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}