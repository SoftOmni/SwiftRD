using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.ObjectiveC;

public class CatchObjCKeyword : ObjectiveCLeafNode<ObjectiveCCompositeNode>, IObjectiveCObjCKeyword
{
    public const string Value = "@catch";

    public CatchObjCKeyword()
        : base(new EditableBuffer(Value))
    { }

    internal CatchObjCKeyword(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => ObjectiveCNodeTypes.CatchObjCKeyword;

    public string KeywordValue => Value;

    public static CatchObjCKeyword Create()
    {
        return new CatchObjCKeyword(new EditableBuffer(Value));
    }
}