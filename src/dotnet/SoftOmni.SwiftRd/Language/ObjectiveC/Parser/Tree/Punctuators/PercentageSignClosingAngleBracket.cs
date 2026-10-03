using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

public class PercentageSignClosingAngleBracket : ObjectiveCLeafNode<ObjectiveCCompositeNode>, IObjectiveCPunctuator
{
    public const string Value = "%>";

    public PercentageSignClosingAngleBracket()
        : base(new EditableBuffer(Value))
    { }

    internal PercentageSignClosingAngleBracket(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => ObjectiveCNodeTypes.PercentageSignClosingAngleBracket;

    public string AsString => Value;

    public static PercentageSignClosingAngleBracket Create()
    {
        return new PercentageSignClosingAngleBracket(new EditableBuffer(Value));
    }
}
