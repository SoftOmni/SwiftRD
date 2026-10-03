using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.C;

public class AlignOfC11Keyword : ObjectiveCLeafNode<ObjectiveCCompositeNode>, IObjectiveCCKeyword
{
    public const string Value = "_Alignof";

    public AlignOfC11Keyword()
        : base(new EditableBuffer(Value))
    { }

    internal AlignOfC11Keyword(IEditableBuffer buffer)
        : base(buffer)
    { }

    public IObjectiveCCKeyword.CStandard Standard => IObjectiveCCKeyword.CStandard.C11;

    public override NodeType NodeType => ObjectiveCNodeTypes.AlignOfC11Keyword;

    public string KeywordValue => Value;

    public static AlignOfC11Keyword Create()
    {
        return new AlignOfC11Keyword(new EditableBuffer(Value));
    }
}
