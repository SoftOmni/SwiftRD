using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.C;

public class CaseKeyword : ObjectiveCLeafNode<ObjectiveCCompositeNode>, IObjectiveCCKeyword
{
    public const string Value = "case";

    public CaseKeyword()
        : base(new EditableBuffer(Value))
    { }

    internal CaseKeyword(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => ObjectiveCNodeTypes.CaseKeyword;

    public IObjectiveCCKeyword.CStandard Standard => IObjectiveCCKeyword.CStandard.C89;

    public string KeywordValue => Value;

    public static CaseKeyword Create()
    {
        return new CaseKeyword(new EditableBuffer(Value));
    }
}