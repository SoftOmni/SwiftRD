using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.C;

public class VolatileKeyword : ObjectiveCLeafNode<ObjectiveCCompositeNode>, IObjectiveCCKeyword
{
    public const string Value = "volatile";

    public VolatileKeyword()
        : base(new EditableBuffer(Value))
    { }

    internal VolatileKeyword(IEditableBuffer buffer)
        : base(buffer)
    { }

    public IObjectiveCCKeyword.CStandard Standard => IObjectiveCCKeyword.CStandard.C89;

    public override NodeType NodeType => ObjectiveCNodeTypes.VolatileKeyword;

    public string KeywordValue => Value;

    public static VolatileKeyword Create()
    {
        return new VolatileKeyword(new EditableBuffer(Value));
    }
}