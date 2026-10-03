using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.ObjectiveC;

public class CompatibilityAliasObjCKeyword : ObjectiveCLeafNode<ObjectiveCCompositeNode>, IObjectiveCObjCKeyword
{
    public const string Value = "@compatibility_alias";

    public CompatibilityAliasObjCKeyword()
        : base(new EditableBuffer(Value))
    { }

    internal CompatibilityAliasObjCKeyword(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => ObjectiveCNodeTypes.CompatibilityAliasObjCKeyword;

    public string KeywordValue => Value;

    public static CompatibilityAliasObjCKeyword Create()
    {
        return new CompatibilityAliasObjCKeyword(new EditableBuffer(Value));
    }
}