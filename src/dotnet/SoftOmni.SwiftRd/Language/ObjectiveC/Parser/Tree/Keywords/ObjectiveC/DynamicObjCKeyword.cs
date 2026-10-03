using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.ObjectiveC;

public class DynamicObjCKeyword : ObjectiveCLeafNode<ObjectiveCCompositeNode>, IObjectiveCObjCKeyword
{
    public const string Value = "@dynamic";

    public DynamicObjCKeyword()
        : base(new EditableBuffer(Value))
    { }

    internal DynamicObjCKeyword(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => ObjectiveCNodeTypes.DynamicObjCKeyword;

    public string KeywordValue => Value;

    public static DynamicObjCKeyword Create()
    {
        return new DynamicObjCKeyword(new EditableBuffer(Value));
    }
}