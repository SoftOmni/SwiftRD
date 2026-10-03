using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.C;

public class LongKeyword : ObjectiveCLeafNode<ObjectiveCCompositeNode>, IObjectiveCCKeyword
{
    public const string Value = "long";

    public LongKeyword()
        : base(new EditableBuffer(Value))
    { }

    internal LongKeyword(IEditableBuffer buffer)
        : base(buffer)
    { }

    public IObjectiveCCKeyword.CStandard Standard => IObjectiveCCKeyword.CStandard.C89;

    public override NodeType NodeType => ObjectiveCNodeTypes.LongKeyword;

    public string KeywordValue => Value;

    public static LongKeyword Create()
    {
        return new LongKeyword(new EditableBuffer(Value));
    }
}