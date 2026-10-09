using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

public class OpeningCurlyBraceDigraph : ObjectiveCLeafNode<ObjectiveCCompositeNode>, IObjectiveCPunctuator
{
    public const string Value = "<%";

    public OpeningCurlyBraceDigraph()
        : base(new EditableBuffer(Value))
    { }

    internal OpeningCurlyBraceDigraph(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => ObjectiveCNodeTypes.OpeningCurlyBraceDigraph;

    public string AsString => Value;

    public static OpeningCurlyBraceDigraph Create()
    {
        return new OpeningCurlyBraceDigraph(new EditableBuffer(Value));
    }
}
