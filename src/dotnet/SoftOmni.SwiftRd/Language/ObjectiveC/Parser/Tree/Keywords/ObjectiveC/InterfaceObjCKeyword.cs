using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.ObjectiveC;

public class InterfaceObjCKeyword : ObjectiveCLeafNode<ObjectiveCCompositeNode>, IObjectiveCObjCKeyword
{
    public const string Value = "@interface";

    public InterfaceObjCKeyword()
        : base(new EditableBuffer(Value))
    { }

    internal InterfaceObjCKeyword(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => ObjectiveCNodeTypes.InterfaceObjCKeyword;

    public string KeywordValue => Value;

    public static InterfaceObjCKeyword Create()
    {
        return new InterfaceObjCKeyword(new EditableBuffer(Value));
    }
}