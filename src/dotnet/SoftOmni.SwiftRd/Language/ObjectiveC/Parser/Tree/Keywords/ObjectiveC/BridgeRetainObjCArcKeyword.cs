using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.ObjectiveC;

public class BridgeRetainObjCArcKeyword : ObjectiveCLeafNode<ObjectiveCCompositeNode>, IObjectiveCObjCKeyword
{
    public const string Value = "__bridge_retain";

    public BridgeRetainObjCArcKeyword()
        : base(new EditableBuffer(Value))
    { }

    internal BridgeRetainObjCArcKeyword(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => ObjectiveCNodeTypes.BridgeRetainObjCArcKeyword;

    public string KeywordValue => Value;

    public static BridgeRetainObjCArcKeyword Create()
    {
        return new BridgeRetainObjCArcKeyword(new EditableBuffer(Value));
    }
}