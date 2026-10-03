using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

public class PercentageSignColonPercentageSignColon : ObjectiveCLeafNode<ObjectiveCCompositeNode>, IObjectiveCPunctuator
{
    public const string Value = "%:%:";

    public PercentageSignColonPercentageSignColon()
        : base(new EditableBuffer(Value))
    { }

    internal PercentageSignColonPercentageSignColon(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType => ObjectiveCNodeTypes.PercentageSignColonPercentageSignColon;

    public string AsString => Value;

    public static PercentageSignColonPercentageSignColon Create()
    {
        return new PercentageSignColonPercentageSignColon(new EditableBuffer(Value));
    }
}
