using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Identifiers;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.KeyPathExpressions;

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

    public KeyPathComponent(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public KeyPathComponent(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}