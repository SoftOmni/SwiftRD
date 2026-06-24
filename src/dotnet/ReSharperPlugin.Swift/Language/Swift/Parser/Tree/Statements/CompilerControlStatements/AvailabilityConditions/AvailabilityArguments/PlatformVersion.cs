using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.AvailabilityConditions.AvailabilityArguments;

public class PlatformVersion : SwiftInternalNode
{
    public IntegerLiteral? Major { get; internal set; }
    
    public Period? MajorMinorPeriod { get; internal set; }
    
    public IntegerLiteral? Minor { get; internal set; }
    
    public Period? MinorRevisionPeriod { get; internal set; }
    
    public IntegerLiteral? Revision { get; internal set; }

    public PlatformVersion(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public PlatformVersion(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public PlatformVersion(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public PlatformVersion(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}