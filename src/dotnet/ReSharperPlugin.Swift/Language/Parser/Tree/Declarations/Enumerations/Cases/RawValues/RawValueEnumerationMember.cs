using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Statements.CompilerControlStatements;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Enumerations.Cases.RawValues;

public abstract class RawValueEnumerationMember : SwiftInternalNode
{
    public IRawValueEnumerationMember? Member { get; internal set; }

    protected RawValueEnumerationMember(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    protected RawValueEnumerationMember(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    protected RawValueEnumerationMember(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    protected RawValueEnumerationMember(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}