using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using JetBrains.Util;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

public abstract class SwiftNodeType : NodeType
{
    protected SwiftNodeType(string id, int index) : base(id, index, NodeTypeFlags.Token)
    {
        TokenRepresentation = id;
    }

    protected SwiftNodeType(string id, int index, NodeTypeFlags flags) : base(id, index, flags)
    {
        TokenRepresentation = id;
    }

    public virtual LeafElementBase Create(string token)
    {
        return Create(new EditableBuffer(token), TreeOffset.Zero, new TreeOffset(token.Length));
    }

    public abstract LeafElementBase Create(IEditableBuffer buffer, TreeOffset startOffset, TreeOffset endOffset);

    public abstract bool IsWhitespace { get; }

    public abstract bool IsComment { get; }

    public abstract bool IsStringLiteral { get; }

    public abstract bool IsConstantLiteral { get; }

    public abstract bool IsIdentifier { get; }

    public abstract bool IsKeyword { get; }

    public virtual string TokenRepresentation { get; }

    public virtual bool IsFiltered => false;

    public virtual string GetSampleText()
    {
        return TokenRepresentation;
    }

    public virtual string GetDescription() => TokenRepresentation.IsNullOrEmpty() ? ToString() : TokenRepresentation;
}