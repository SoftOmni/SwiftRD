using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.ObjectiveC;

public class BridgeTransferObjCArcKeyword : ObjectiveCLeafNode<ObjectiveCCompositeNode>, IObjectiveCObjCKeyword
{
    public const string Value = "__bridge_transfer";

    public BridgeTransferObjCArcKeyword()
        : base(new EditableBuffer(Value))
    { }

    internal BridgeTransferObjCArcKeyword(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => ObjectiveCNodeTypes.BridgeTransferObjCArcKeyword;

    public string KeywordValue => Value;

    public static BridgeTransferObjCArcKeyword Create()
    {
        return new BridgeTransferObjCArcKeyword(new EditableBuffer(Value));
    }
}