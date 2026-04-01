using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.KeyPathExpressions;

public class KeyPathComponent : SwiftInternalNode
{
    public Identifier? Identifier { get; internal set; }

    private List<IKeyPathPostfix> _keyPathPostfixes = [];
        
    public KeyPathComponent(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public KeyPathComponent(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public KeyPathComponent(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public KeyPathComponent(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}