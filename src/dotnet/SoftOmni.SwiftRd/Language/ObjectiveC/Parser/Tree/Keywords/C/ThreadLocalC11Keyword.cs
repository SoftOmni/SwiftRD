using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.C;

public class ThreadLocalC11Keyword : ObjectiveCLeafNode<ObjectiveCCompositeNode>, IObjectiveCCKeyword
{
    public const string Value = "_Thread_local";

    public ThreadLocalC11Keyword()
        : base(new EditableBuffer(Value))
    { }

    internal ThreadLocalC11Keyword(IEditableBuffer buffer)
        : base(buffer)
    { }

    public IObjectiveCCKeyword.CStandard Standard => IObjectiveCCKeyword.CStandard.C11;

    public override NodeType NodeType => ObjectiveCNodeTypes.ThreadLocalC11Keyword;

    public string KeywordValue => Value;

    public static ThreadLocalC11Keyword Create()
    {
        return new ThreadLocalC11Keyword(new EditableBuffer(Value));
    }
}