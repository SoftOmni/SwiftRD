using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.C;

public class SignedKeyword : ObjectiveCLeafNode<ObjectiveCCompositeNode>, IObjectiveCCKeyword
{
    public const string Value = "signed";

    public SignedKeyword()
        : base(new EditableBuffer(Value))
    { }

    internal SignedKeyword(IEditableBuffer buffer)
        : base(buffer)
    { }

    public IObjectiveCCKeyword.CStandard Standard => IObjectiveCCKeyword.CStandard.C89;

    public override NodeType NodeType => ObjectiveCNodeTypes.SignedKeyword;

    public string KeywordValue => Value;

    public static SignedKeyword Create()
    {
        return new SignedKeyword(new EditableBuffer(Value));
    }
}