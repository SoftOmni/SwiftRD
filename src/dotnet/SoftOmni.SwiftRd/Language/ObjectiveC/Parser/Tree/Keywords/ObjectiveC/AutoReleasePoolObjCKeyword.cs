using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.ObjectiveC;

public class AutoReleasePoolObjCKeyword : ObjectiveCLeafNode<ObjectiveCCompositeNode>, IObjectiveCObjCKeyword
{
    public const string Value = "@autoreleasepool";

    public AutoReleasePoolObjCKeyword()
        : base(new EditableBuffer(Value))
    { }

    internal AutoReleasePoolObjCKeyword(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => ObjectiveCNodeTypes.AutoReleasePoolObjCKeyword;

    public string KeywordValue => Value;

    public static AutoReleasePoolObjCKeyword Create()
    {
        return new AutoReleasePoolObjCKeyword(new EditableBuffer(Value));
    }
}