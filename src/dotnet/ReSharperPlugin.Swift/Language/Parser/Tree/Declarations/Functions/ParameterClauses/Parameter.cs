using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Attributes;
using ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Functions.ParameterClauses.ParameterModifiers;
using ReSharperPlugin.Swift.Language.Parser.Tree.Expressions;
using ReSharperPlugin.Swift.Language.Parser.Tree.Identifiers;
using ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;
using ReSharperPlugin.Swift.Language.Parser.Tree.Types;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Functions.ParameterClauses;

public class Parameter : SwiftInternalNode
{
    public Identifier? ExternalParameterName { get; internal set; }
    
    public Identifier? LocalParameterName { get; internal set; }
    
    public Colon? Colon { get; private set; }
    
    public AttributeGroup? AttributeGroup { get; private set; }
    
    public ParameterModifier? ParameterModifier { get; private set; }
    
    public IType? Type { get; private set; }
    
    public Ellipsis? Ellipsis { get; private set; }
    
    public Expression? DefaultExpression { get; private set; }

    public Parameter(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public Parameter(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public Parameter(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public Parameter(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}