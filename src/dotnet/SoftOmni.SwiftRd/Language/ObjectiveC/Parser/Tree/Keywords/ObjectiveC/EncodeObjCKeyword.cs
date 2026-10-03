using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.ObjectiveC;

public class EncodeObjCKeyword : ObjectiveCLeafNode<ObjectiveCCompositeNode>, IObjectiveCObjCKeyword
{
    public const string Value = "@encode";

    public EncodeObjCKeyword()
        : base(new EditableBuffer(Value))
    { }

    internal EncodeObjCKeyword(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => ObjectiveCNodeTypes.EncodeObjCKeyword;

    public string KeywordValue => Value;

    public static EncodeObjCKeyword Create()
    {
        return new EncodeObjCKeyword(new EditableBuffer(Value));
    }
}