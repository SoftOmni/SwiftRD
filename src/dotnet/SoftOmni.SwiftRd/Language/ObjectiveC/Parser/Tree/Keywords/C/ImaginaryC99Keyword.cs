using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords.C;

public class ImaginaryC99Keyword : ObjectiveCLeafNode<ObjectiveCCompositeNode>, IObjectiveCCKeyword
{
    public const string Value = "_Imaginary";

    public ImaginaryC99Keyword()
        : base(new EditableBuffer(Value))
    { }

    internal ImaginaryC99Keyword(IEditableBuffer buffer)
        : base(buffer)
    { }

    public IObjectiveCCKeyword.CStandard Standard => IObjectiveCCKeyword.CStandard.C99;

    public override NodeType NodeType => ObjectiveCNodeTypes.ImaginaryC99Keyword;

    public string KeywordValue => Value;

    public static ImaginaryC99Keyword Create()
    {
        return new ImaginaryC99Keyword(new EditableBuffer(Value));
    }
}
