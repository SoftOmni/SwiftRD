using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.ObjectiveC;

public class PropertyObjCKeyword : ObjectiveCLeafNode<ObjectiveCCompositeNode>, IObjectiveCObjCKeyword
{
    public const string Value = "@property";

    public PropertyObjCKeyword()
        : base(new EditableBuffer(Value))
    { }

    internal PropertyObjCKeyword(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => ObjectiveCNodeTypes.PropertyObjCKeyword;

    public string KeywordValue => Value;

    public static PropertyObjCKeyword Create()
    {
        return new PropertyObjCKeyword(new EditableBuffer(Value));
    }
}