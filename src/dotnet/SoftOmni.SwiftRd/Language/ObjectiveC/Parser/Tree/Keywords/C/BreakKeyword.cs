using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.C;

public class BreakKeyword : ObjectiveCLeafNode<ObjectiveCCompositeNode>, IObjectiveCCKeyword
{
    public const string Value = "break";

    public BreakKeyword()
        : base(new EditableBuffer(Value))
    { }

    internal BreakKeyword(IEditableBuffer buffer)
        : base(buffer)
    { }
    
    public override NodeType NodeType => ObjectiveCNodeTypes.BreakKeyword;

    public IObjectiveCCKeyword.CStandard Standard => IObjectiveCCKeyword.CStandard.C89;

    public string KeywordValue => Value;

    public static BreakKeyword Create()
    {
        return new BreakKeyword(new EditableBuffer(Value));
    }
}
