using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

public class ClosingSquareBracketDigraph : ObjectiveCLeafNode<ObjectiveCCompositeNode>, IObjectiveCPunctuator
{
    public const string Value = ":>";

    public ClosingSquareBracketDigraph()
        : base(new EditableBuffer(Value))
    { }

    internal ClosingSquareBracketDigraph(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => ObjectiveCNodeTypes.ClosingSquareBracketDigraph;

    public string AsString => Value;

    public static ClosingSquareBracketDigraph Create()
    {
        return new ClosingSquareBracketDigraph(new EditableBuffer(Value));
    }
}
