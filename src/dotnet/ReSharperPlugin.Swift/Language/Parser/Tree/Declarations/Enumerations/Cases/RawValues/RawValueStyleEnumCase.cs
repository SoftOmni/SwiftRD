using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals;
using ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Enumerations.Cases.RawValues;

public class RawValueStyleEnumCase : EnumerationCase
{
    public Equal? Equal { get; internal set; }
    
    public IRawValue? RawValue { get; internal set; }
    
    public RawValueStyleEnumCase(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public RawValueStyleEnumCase(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public RawValueStyleEnumCase(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public RawValueStyleEnumCase(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}