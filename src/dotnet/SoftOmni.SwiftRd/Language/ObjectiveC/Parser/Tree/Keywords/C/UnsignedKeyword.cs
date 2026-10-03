using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.C;

public class UnsignedKeyword : ObjectiveCLeafNode<ObjectiveCCompositeNode>, IObjectiveCCKeyword
{
    public const string Value = "unsigned";

    public UnsignedKeyword()
        : base(new EditableBuffer(Value))
    { }

    internal UnsignedKeyword(IEditableBuffer buffer)
        : base(buffer)
    { }

    public IObjectiveCCKeyword.CStandard Standard => IObjectiveCCKeyword.CStandard.C89;

    public override NodeType NodeType => ObjectiveCNodeTypes.UnsignedKeyword;

    public string KeywordValue => Value;

    public static UnsignedKeyword Create()
    {
        return new UnsignedKeyword(new EditableBuffer(Value));
    }
}