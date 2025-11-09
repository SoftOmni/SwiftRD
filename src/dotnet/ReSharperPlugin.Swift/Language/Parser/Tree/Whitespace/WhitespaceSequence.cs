using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Whitespace;

public class WhitespaceSequence : SwiftLeafNode
{
    public WhitespaceSequence(IEditableBuffer buffer) : base(buffer, NodeTypes.NodeTypes.Whitespace)
    { }

    public WhitespaceSequence(ISwiftNode parent, IEditableBuffer buffer) : base(parent, buffer, NodeTypes.NodeTypes.Whitespace)
    { }
}