using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.ObjectiveC;

public class BridgeRetainedObjCArcKeyword : ObjectiveCLeafNode<ObjectiveCCompositeNode>, IObjectiveCObjCKeyword
{
    public const string Value = "__bridge_retained";

    public BridgeRetainedObjCArcKeyword()
        : base(new EditableBuffer(Value))
    { }

    internal BridgeRetainedObjCArcKeyword(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => ObjectiveCNodeTypes.BridgeRetainedObjCArcKeyword;

    public string KeywordValue => Value;

    public static BridgeRetainedObjCArcKeyword Create()
    {
        return new BridgeRetainedObjCArcKeyword(new EditableBuffer(Value));
    }
}