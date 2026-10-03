using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

public class OpeningAngleBracketPercentageSign : ObjectiveCLeafNode<ObjectiveCCompositeNode>, IObjectiveCPunctuator
{
    public const string Value = "<%";

    public OpeningAngleBracketPercentageSign()
        : base(new EditableBuffer(Value))
    { }

    internal OpeningAngleBracketPercentageSign(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => ObjectiveCNodeTypes.OpeningAngleBracketPercentageSign;

    public string AsString => Value;

    public static OpeningAngleBracketPercentageSign Create()
    {
        return new OpeningAngleBracketPercentageSign(new EditableBuffer(Value));
    }
}
