using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.C;

public class ComplexC99Keyword : ObjectiveCLeafNode<ObjectiveCCompositeNode>, IObjectiveCCKeyword
{
    public const string Value = "_Complex";

    public ComplexC99Keyword()
        : base(new EditableBuffer(Value))
    { }

    internal ComplexC99Keyword(IEditableBuffer buffer)
        : base(buffer)
    { }

    public IObjectiveCCKeyword.CStandard Standard => IObjectiveCCKeyword.CStandard.C99;

    public override NodeType NodeType => ObjectiveCNodeTypes.ComplexC99Keyword;

    public string KeywordValue => Value;

    public static ComplexC99Keyword Create()
    {
        return new ComplexC99Keyword(new EditableBuffer(Value));
    }
}
