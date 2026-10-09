using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

public class ClosingCurlyBraceDigraph : ObjectiveCLeafNode<ObjectiveCCompositeNode>, IObjectiveCPunctuator
{
    public const string Value = "%>";

    public ClosingCurlyBraceDigraph()
        : base(new EditableBuffer(Value))
    { }

    internal ClosingCurlyBraceDigraph(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => ObjectiveCNodeTypes.ClosingCurlyBraceDigraph;

    public string AsString => Value;

    public static ClosingCurlyBraceDigraph Create()
    {
        return new ClosingCurlyBraceDigraph(new EditableBuffer(Value));
    }
}
