using System;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.NodeTypes;

public class InternalNodeType : SwiftNodeType
{
    internal InternalNodeType() : base(NodeTypes.InternalNodeId, NodeTypes.InternalNodeIndex)
    { }

    public override LeafElementBase Create(IEditableBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        throw new NotSupportedException();
    }

    public override bool IsWhitespace => false;

    public override bool IsComment => false;

    public override bool IsStringLiteral => false;

    public override bool IsConstantLiteral => false;

    public override bool IsIdentifier => false;

    public override bool IsKeyword => false;

    public override string TokenRepresentation => "INTERNAL_NODE_TYPE";
}